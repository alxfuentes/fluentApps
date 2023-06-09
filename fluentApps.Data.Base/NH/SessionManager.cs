﻿using System;
using System.Runtime.Remoting.Messaging;
using System.Web;
using NHibernate;
using NHibernate.Cache;
using FluentNHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System.Collections.Generic;

using fluentApps.Utils;

namespace fluentApps.Data.Base.NH
{
    public sealed class SessionManager
    {
        private const string TRANSACTION_KEY = "CONTEXT_TRANSACTION";
        private const string SESSION_KEY = "CONTEXT_SESSION";
        private ISessionFactory sessionFactory;

        #region Thread-safe, lazy Singleton

        /// <summary>
        /// This is a thread-safe, lazy singleton.  See http://www.yoda.arachsys.com/csharp/singleton.html
        /// for more details about its implementation.
        /// </summary>
        public static SessionManager Instance
        {
            get
            {
                return Nested.NHibernateSessionManager;
            }
        }

        /// <summary>
        /// Initializes the NHibernate session factory upon instantiation.
        /// </summary>
        private SessionManager()
        {
            InitSessionFactory();
        }

        /// <summary>
        /// Assists with ensuring thread-safe, lazy singleton
        /// </summary>
        private class Nested
        {
            static Nested() { }
            internal static readonly SessionManager NHibernateSessionManager =
                new SessionManager();
        }

        #endregion

        private void InitSessionFactory()
        {
            // String connectionString = "Server=FDWWINDEV;Database=fluentApps;User Id=sa;Password=fdw/sa;"; //  
            String connectionString = cnString();

            var cfg = FluentNHibernate.Cfg.Db.MsSqlConfiguration
                .MsSql2008
                .ConnectionString(c => c.Is(connectionString)).ShowSql();

            try
            {
                List<string> assemblies = new List<string>();

                assemblies.Add("fluentApps.Data.Core");
                assemblies.Add("fluentApps.Data.Enterprise");
                assemblies.Add("fluentApps.Data.Dashboard");

                // sessionFactory = Fluently
                var fluentConfig = Fluently
                .Configure()
                .Database(cfg)
                .Mappings(m =>
                {
                    foreach (var assembly in assemblies)
                    {
                        //load each assembly in config file
                        m.FluentMappings.AddFromAssembly(System.Reflection.Assembly.Load(assembly));
                    }
                    m.FluentMappings.Conventions.AddFromAssemblyOf<Conventions.ReferenceConvention>();
                });

                //.ExposeConfiguration( conf => new SchemaUpdate(conf).Execute(false,true))
                var nhConfig = fluentConfig.BuildConfiguration();
                sessionFactory = nhConfig.BuildSessionFactory();

                new SchemaUpdate(nhConfig)
                    .Execute(false, true);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("SessionManager Init Exception:");
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Allows you to register an interceptor on a new session.  This may not be called if there is already
        /// an open session attached to the HttpContext.  If you have an interceptor to be used, modify
        /// the HttpModule to call this before calling BeginTransaction().
        /// </summary>
        public void RegisterInterceptor(IInterceptor interceptor)
        {
            ISession session = ContextSession;

            if (session != null && session.IsOpen)
            {
                throw new CacheException("You cannot register an interceptor once a session has already been opened");
            }

            GetSession(interceptor);
        }

        public ISession GetSession()
        {
            return GetSession(null);
        }

        /// <summary>
        /// Gets a session with or without an interceptor.  This method is not called directly; instead,
        /// it gets invoked from other public methods.
        /// </summary>
        private ISession GetSession(IInterceptor interceptor)
        {
            ISession session = ContextSession;

            if (session == null)
            {
                if (interceptor != null)
                {
                    session = sessionFactory.OpenSession(interceptor);
                }
                else
                {
                    session = sessionFactory.OpenSession();
                }

                ContextSession = session;
            }

            Check.Ensure(session != null, "session was null");

            return session;
        }

        /// <summary>
        /// Flushes anything left in the session and closes the connection.
        /// </summary>
        public void CloseSession()
        {
            ISession session = ContextSession;

            if (session != null && session.IsOpen)
            {
                session.Flush();
                session.Close();
            }

            ContextSession = null;
        }

        public void BeginTransaction()
        {
            ITransaction transaction = ContextTransaction;

            if (transaction == null)
            {
                transaction = GetSession().BeginTransaction();
                ContextTransaction = transaction;
            }
        }

        public void CommitTransaction()
        {
            ITransaction transaction = ContextTransaction;

            try
            {
                if (HasOpenTransaction())
                {
                    transaction.Commit();
                    ContextTransaction = null;
                }
            }
            catch (HibernateException)
            {
                RollbackTransaction();
                throw;
            }
        }

        public bool HasOpenTransaction()
        {
            ITransaction transaction = ContextTransaction;

            return transaction != null && !transaction.WasCommitted && !transaction.WasRolledBack;
        }

        public void RollbackTransaction()
        {
            ITransaction transaction = ContextTransaction;

            try
            {
                if (HasOpenTransaction())
                {
                    transaction.Rollback();
                }

                ContextTransaction = null;
            }
            finally
            {
                CloseSession();
            }
        }

        /// <summary>
        /// If within a web context, this uses <see cref="HttpContext" /> instead of the WinForms 
        /// specific <see cref="CallContext" />.  Discussion concerning this found at 
        /// http://forum.springframework.net/showthread.php?t=572.
        /// </summary>
        private ITransaction ContextTransaction
        {
            get
            {
                if (IsInWebContext())
                {
                    return (ITransaction)HttpContext.Current.Items[TRANSACTION_KEY];
                }
                else
                {
                    return (ITransaction)CallContext.GetData(TRANSACTION_KEY);
                }
            }
            set
            {
                if (IsInWebContext())
                {
                    HttpContext.Current.Items[TRANSACTION_KEY] = value;
                }
                else
                {
                    CallContext.SetData(TRANSACTION_KEY, value);
                }
            }
        }

        /// <summary>
        /// If within a web context, this uses <see cref="HttpContext" /> instead of the WinForms 
        /// specific <see cref="CallContext" />.  Discussion concerning this found at 
        /// http://forum.springframework.net/showthread.php?t=572.
        /// </summary>
        private ISession ContextSession
        {
            get
            {
                if (IsInWebContext())
                {
                    return (ISession)HttpContext.Current.Items[SESSION_KEY];
                }
                else
                {
                    return (ISession)CallContext.GetData(SESSION_KEY);
                }
            }
            set
            {
                if (IsInWebContext())
                {
                    HttpContext.Current.Items[SESSION_KEY] = value;
                }
                else
                {
                    CallContext.SetData(SESSION_KEY, value);
                }
            }
        }

        private bool IsInWebContext()
        {
            return HttpContext.Current != null;
        }

        ///<summary>
        ///Obtener connectionString
        ///</summary>
        private String cnString()
        {
            try
            {
                fluentApps.Data.Base.Connection cnn = new fluentApps.Data.Base.Connection();
                return cnn.GetConnectionData("fluentAppsConnectionString").ConnectionString;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("The file could not be read:");
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }
    }
}
