using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_ENE.Data.DataAccess
{
    public class BDConnection
    {
        private const string SERVER = "localhost";
        private const string DATABASE = "eneprog2";
        private const string USER_ID = "root";
        private const string PASSWORD = "";

        public MySqlConnection ObtainConnection()
        {
            string connectionString = $"Server={SERVER};Database={DATABASE};User ID={USER_ID};Password={PASSWORD};";
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }

        

    }
}
