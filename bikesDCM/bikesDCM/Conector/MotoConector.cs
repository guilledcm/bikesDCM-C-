﻿using bikesDCM.modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

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
            using (MySqlConnection conn = new BasicConector().GetConnection())
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM moto;";
                ReadQueryResult(cmd);
            }
        }

            public void EliminarMoto(int id)
            {
                using (MySqlConnection conn = new BasicConector().GetConnection())
                {

                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM moto WHERE id = @MotoId";

                    cmd.Parameters.AddWithValue("@MotoId", id);

                    cmd.ExecuteNonQuery();
                }

            }

            public void InsertarMoto(Moto nuevaMoto)
            {
                using (MySqlConnection conn = connector.GetConnection())
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO moto (Marca, Tipo, Cilindrada, Precio) " +
                                      "VALUES (@Marca, @Tipo, @Cilindrada, @Precio)";

                    cmd.Parameters.AddWithValue("@Marca", nuevaMoto.Marca);
                    cmd.Parameters.AddWithValue("@Tipo", nuevaMoto.Tipo);
                    cmd.Parameters.AddWithValue("@Cilindrada", nuevaMoto.Cilindrada);
                    cmd.Parameters.AddWithValue("@Precio", nuevaMoto.Precio);

                    cmd.ExecuteNonQuery();
                }

                LoadListFromDatabase();
                
        }


        public void ModificarMoto(Moto moto)
        {
            int id = moto.Id;
            Moto motoSeleccionada = MotoConector._instance.motos.Motos.FirstOrDefault(m => m.Id == id);

            
        }


        public int ObtenerPrecioMoto(int itemId)
        {
            Moto motoSeleccionada = MotoConector._instance.motos.Motos.FirstOrDefault(m => m.Id == itemId);

            if (motoSeleccionada != null)
            {
                return motoSeleccionada.Precio;
            }

            return 0; 
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
