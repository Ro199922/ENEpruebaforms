using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_ENE.Data
{
    public class DataBaseConnection
    {
        public DataBaseConnection()
        {
            string connectionString = "Server=localhost;Database=eneprog;User=root;Password=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Abre la conexión
                    connection.Open();

                    // Cierra la conexión
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
          
        }
        
    }
}
