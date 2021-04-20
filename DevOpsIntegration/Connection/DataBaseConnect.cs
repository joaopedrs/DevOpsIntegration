using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DevOpsIntegration.Connection
{
    public class DataBaseConnect
    {
        public SqlConnection Connect()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string connetionString = configuration.AppSettings.Settings["connectionString"].Value;
            SqlConnection cnn = new SqlConnection(connetionString);
            return cnn;
        }

        public SqlConnection TestConnect(string connection)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string connetionString = connection;
            SqlConnection cnn = new SqlConnection(connetionString);
            return cnn;
        }
    }
}