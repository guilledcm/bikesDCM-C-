using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bikesDCM.Constantes; // Importación de Constantes
using MySql.Data.MySqlClient;
using bikesDCM.Constantes; // Importación duplicada de Constantes

namespace bikesDCM.Conector
{
    internal class BasicConector
    {
        private string connectionString;
        private MySqlConnection connection;

        // Constructor de la clase BasicConector
        public BasicConector()
        {
            // Construir la cadena de conexión utilizando las constantes proporcionadas
            connectionString = $"server={Constants.HOST}; port={Constants.PORT}; uid={Constants.USER}; " +
                $"pwd={Constants.PASSWORD}; database={Constants.DATABASE}";

            // Inicializar la conexión MySqlConnection con la cadena de conexión
            connection = new MySqlConnection(connectionString);
        }

        // Método para obtener la conexión MySqlConnection
        public MySqlConnection GetConnection()
        {
            try
            {
                // Verificar si la conexión no está abierta y abrirla si es necesario
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception e)
            {
                // Manejar errores de conexión e imprimir el mensaje de error
                Console.WriteLine($"Error connecting to the database: {e.Message}");
            }

            // Devolver la conexión MySqlConnection
            return connection;
        }
    }
}
