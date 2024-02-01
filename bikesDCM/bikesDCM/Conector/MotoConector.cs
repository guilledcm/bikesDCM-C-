using bikesDCM.modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using bikesDCM.masRecursos;

namespace bikesDCM.Conector
{

    internal class MotoConector
    {
        // Lista de motos
        public MotoList motos { get; set; }

        // Conector básico para operaciones con la base de datos
        private BasicConector connector;

        // Instancia única de MotoConector (patrón Singleton)
        public static MotoConector _instance = new MotoConector();

        // Constructor privado para Singleton
        private MotoConector()
        {
            connector = new BasicConector();
            motos = new MotoList();
        }

        // Cargar la lista de motos desde la base de datos
        public void LoadListFromDatabase()
        {
            using (MySqlConnection conn = new BasicConector().GetConnection())
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM moto;";
                ReadQueryResult(cmd);
            }
        }

        // Eliminar una moto por su ID
        public void EliminarMoto(int id)
        {
            connector = new BasicConector();

            using (MySqlConnection conn = connector.GetConnection())
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM moto WHERE id = @MotoId";

                cmd.Parameters.AddWithValue("@MotoId", id);

                cmd.ExecuteNonQuery();
            }

            LoadListFromDatabase();
        }

        // Insertar una nueva moto en la base de datos
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

        // Actualizar la información de una moto en la base de datos
        public void ActualizarMoto(int id, string marca, string tipo, int cilindrada, int precio)
        {
            connector = new BasicConector();
            using (MySqlConnection conn = connector.GetConnection())
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE moto SET Marca = @Marca, Tipo = @Tipo, Cilindrada = @Cilindrada, Precio = @Precio WHERE Id = @Id";

                cmd.Parameters.AddWithValue("@Marca", marca);
                cmd.Parameters.AddWithValue("@Tipo", tipo);
                cmd.Parameters.AddWithValue("@Cilindrada", cilindrada);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
            }

            LoadListFromDatabase();
        }

        // Obtener el precio de una moto por su ID
        public int ObtenerPrecioMoto(int itemId)
        {
            Moto motoSeleccionada = MotoConector._instance.motos.Motos.FirstOrDefault(m => m.Id == itemId);

            if (motoSeleccionada != null)
            {
                return motoSeleccionada.Precio;
            }

            return 0;
        }

        // Agregar una moto al carrito
        public void AddCarritoMoto(int itemId)
        {
            int precio = ObtenerPrecioMoto(itemId);
            CarritoForm carritoForm = CarritoForm.Instance;

            carritoForm.AgregarAlCarrito(precio);
            carritoForm.ActualizarVista();
        }

        // Leer el resultado de una consulta y agregar motos a la lista
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
