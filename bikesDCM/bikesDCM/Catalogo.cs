using bikesDCM.Conector;
using bikesDCM.Constantes;
using bikesDCM.masRecursos;
using MySql.Data.MySqlClient;
using System.Drawing.Text;

namespace bikesDCM
{
    public partial class Catalogo : Form
    {
        // Instancia única del formulario Catalogo
        private static Catalogo _instance;

        // Conector básico para acceder a la base de datos
        private BasicConector connector;

        // Propiedad que devuelve la instancia única del formulario Catalogo
        public static Catalogo Instance
        {
            get { return _instance; }
        }

        // Constructor de la clase Catalogo
        public Catalogo()
        {
            InitializeComponent();
            _instance = this;
            ConfigurarFuentePersonalizada(42f);
        }

        // Método para configurar una fuente personalizada
        private void ConfigurarFuentePersonalizada(float tamano)
        {
            try
            {
                string rutaFuente = Constants.rutaFuente;

                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(rutaFuente);

                Font fuentePersonalizada = new Font(pfc.Families[0], tamano, FontStyle.Regular);

                lblTitulo.Font = fuentePersonalizada;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la fuente personalizada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método invocado al cargar el formulario Catalogo
        public void Catalogo_Load(object sender, EventArgs e)
        {
            // Carga las motos en el catálogo utilizando el ItemLoader
            ItemLoader itemLoader = new ItemLoader(this);
            itemLoader.LoadMotos();
        }

        // Método invocado al hacer clic en el icono del carrito
        private void imgCarrito_Click(object sender, EventArgs e)
        {
            // Muestra el formulario del carrito en la posición del mouse
            Point mousePosition = Cursor.Position;
            CarritoForm carritoForm = CarritoForm.Instance;
            carritoForm.StartPosition = FormStartPosition.Manual;
            carritoForm.Location = mousePosition;
            DialogResult result = carritoForm.ShowDialog();
        }

        // Método invocado al hacer clic en el botón "Insertar"
        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Muestra el formulario de inserción en la posición del mouse
            Point mousePosition = Cursor.Position;
            InsertarForm insertarForm = new InsertarForm();
            insertarForm.StartPosition = FormStartPosition.Manual;
            insertarForm.Location = mousePosition;
            DialogResult result = insertarForm.ShowDialog();

            // Recarga el catálogo después de insertar una moto
            Catalogo.Instance.Catalogo_Load(sender, e);
        }

        // Método invocado al hacer clic en el botón "Buscar"
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtiene los criterios de búsqueda del usuario
            string marca = comboBoxMarca.Text;
            string tipo = comboBoxTipo.Text;
            string cilindrada = textBoxCilindrada.Text;

            // Construye la consulta SQL basada en los criterios de búsqueda
            string consultaSql = "SELECT * FROM moto WHERE 1 = 1";

            if (!string.IsNullOrEmpty(marca))
            {
                consultaSql += " AND moto.marca = @marca";
            }

            if (!string.IsNullOrEmpty(tipo))
            {
                consultaSql += " AND moto.tipo = @tipo";
            }

            if (!string.IsNullOrEmpty(cilindrada))
            {
                consultaSql += " AND moto.cilindrada >= @cilindrada";
            }

            // Ejecuta la consulta y muestra los resultados en el catálogo
            EjecutarConsulta(consultaSql, marca, tipo, cilindrada);
        }

        // Método para ejecutar una consulta y mostrar los resultados en el catálogo
        private void EjecutarConsulta(string consultaSql, string marca, string tipo, string cilindrada)
        {
            connector = new BasicConector();
            using (MySqlConnection conn = connector.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(consultaSql, conn))
                {
                    if (!string.IsNullOrEmpty(marca))
                    {
                        cmd.Parameters.AddWithValue("@marca", marca);
                    }

                    if (!string.IsNullOrEmpty(tipo))
                    {
                        cmd.Parameters.AddWithValue("@tipo", tipo);
                    }

                    if (!string.IsNullOrEmpty(cilindrada))
                    {
                        cmd.Parameters.AddWithValue("@cilindrada", cilindrada);
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Limpia los controles en el panel principal antes de mostrar los resultados
                        panelMainBikes.Controls.Clear();

                        while (reader.Read())
                        {
                            int motoId = reader.GetInt32(reader.GetOrdinal("id"));
                            string urlImagen = reader.GetString(reader.GetOrdinal("url_imagen"));

                            // Crea y muestra un elemento de moto en el catálogo
                            ItemLoader.CreateItem(motoId, urlImagen);
                        }
                    }
                }
            }
        }

        // Método invocado al hacer clic en el botón "Grafico"
        private void btnGrafico_Click(object sender, EventArgs e)
        {
            // Muestra el formulario de gráfico
            GraficoForm graficoForm = new GraficoForm();
            graficoForm.ShowDialog();
        }
    }
}
