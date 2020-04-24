using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace fluentApps.Data.Base.NH
{
    public class Schema
    {
        public void Update()
        {


        }

        
        
        /// <summary>
        /// Exposes the ISession used within the DAO.
        /// </summary>
        private ISession NHibernateSession
        {
            get
            {
                return SessionManager.Instance.GetSession();
            }
        }

    }
}
