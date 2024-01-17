using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bikesDCM.Constantes;
using MySql.Data.MySqlClient;
using bikesDCM.Constantes;


namespace bikesDCM.Conector
{
    internal class BasicConector
    {
        private string connectionString;
        private MySqlConnection connection;

        public BasicConector()
        {
            connectionString = $"server={Constants.HOST}; port={Constants.PORT}; uid={Constants.USER}; " +
                $"pwd={Constants.PASSWORD}; database={Constants.DATABASE}";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error connecting to the database: {e.Message}");
            }
            return connection;
        }
    }

}
