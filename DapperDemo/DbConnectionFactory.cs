using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo.Interface
{
    public class DbConnectionFactory
    {
        private static readonly string connectionString;
        private static readonly string databaseType;

        static DbConnectionFactory()
        {
            //var collection = ConfigurationManager.ConnectionStrings["connectionString"];
            //connectionString = collection.ConnectionString;
            //databaseType = collection.ProviderName.ToLower();
            var collection = @"data source=SHADEVX64;initial catalog=IITDeduction;user id=sa;password=abc-123;MultipleActiveResultSets=True;App=EntityFramework";
            connectionString = collection;
            databaseType = "System.Data.SqlClient".ToLower();
        }

        public static IDbConnection CreateDbConnection()
        {
            IDbConnection connection = null;
            switch (databaseType)
            {
                case "system.data.sqlclient":
                    connection = new System.Data.SqlClient.SqlConnection(connectionString);
                    break;
                case "mysql":
                    //connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
                    break;
                case "oracle":
                    //connection = new Oracle.DataAccess.Client.OracleConnection(connectionString);
                    //connection = new System.Data.OracleClient.OracleConnection(connectionString);
                    break;
                case "db2":
                    connection = new System.Data.OleDb.OleDbConnection(connectionString);
                    break;
                default:
                    connection = new System.Data.SqlClient.SqlConnection(connectionString);
                    break;
            }
            return connection;
        }
    }
}
