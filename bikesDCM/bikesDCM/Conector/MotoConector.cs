using bikesDCM.modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace bikesDCM.Conector
{
    internal class MotoConector
    {
        public MotoList motos { get; set; }
        private BasicConector connector;
        public static MotoConector _instance = new MotoConector();

        private MotoConector()
        {
            connector = new BasicConector();
            motos = new MotoList();
        }

        public void LoadListFromDatabase()
        {
            using (MySqlConnection conn = connector.GetConnection())
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM moto;";
                ReadQueryResult(cmd);
            }
        }

        public void ReadQueryResult(MySqlCommand cmd)
        {
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    motos.AddMoto(new Moto(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetInt32(3),
                        reader.GetInt32(4),
                        reader.GetString(5)
                    ));
                }
            }
        }
    }
}
