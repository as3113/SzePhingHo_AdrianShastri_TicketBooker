using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TicketTest
{
    internal static class DbConnection
    {
        // Use Lazy<T> to initialize database connection when it is first accessed
        private static readonly Lazy<SqlConnection> lazyConnection = new Lazy<SqlConnection>(() =>
        {
            SqlConnection connection = new SqlConnection(getConnectionString());
            connection.Open();
            return connection; // return single instance of connection
        });

        // Method to construct and return the connection string for SQL server database connection
        private static string getConnectionString()
        {
            // Define the values of server host, database name, username, and password.  
            // Values maybe different for different individual's system
            string server = "Server=localhost;";
            string dbName = "Database=vanierAECWinter2023;";
            string username = "User=sa;";
            string password = "Password=1234;"; // key in your SQL server password

            // Combine the strings above database connection string
            string connectionString = string.Format("{0}{1}{2}{3}", server, dbName, username, password);
            return connectionString;
        }
        public static SqlConnection Connection => lazyConnection.Value; // access to the lazily initialized database connection

        // Method to be used in other classes for single database connection
        public static SqlCommand CreateCommand()
        {
            return Connection.CreateCommand();
        }
    }
}
