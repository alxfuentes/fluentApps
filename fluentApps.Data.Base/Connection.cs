using System;
using System.Configuration;

namespace fluentApps.Data.Base
{
    public class Connection
    {
        public Connection()
        {
        }

        public ConnectionData GetConnectionData(string CnnId)
        {
            string cnnString = "";
            ConnectionData returnCnn = new ConnectionData();

            try
            {
                cnnString = ConfigurationManager.ConnectionStrings[CnnId].ConnectionString;

                returnCnn.ConnectionId = CnnId;
                returnCnn.ConnectionString = cnnString;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
            }
            return returnCnn;
        }
    }

    public class ConnectionData
    {
        public string ConnectionId { get; set; }
        public string ConnectionName { get; set; }
        public string Server { get; set; }
        public string Database { get; set; }
        public bool Trusted { get; set; } 
        public string UserId { get; set; }
        public string Password { get; set; }
        public string ConnectionString { get; set; }
    }
}
