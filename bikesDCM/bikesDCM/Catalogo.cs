using bikesDCM.Conector;
using bikesDCM.Constantes;
using bikesDCM.masRecursos;
using MySql.Data.MySqlClient;
using System.Drawing.Text;

namespace bikesDCM
{
    public partial class Catalogo : Form
    {
        private static Catalogo _instance;
        private BasicConector connector;
        public static Catalogo Instance
        {
            get { return _instance; }
        }
        public Catalogo()
        {
            InitializeComponent();
            _instance = this;
            ConfigurarFuentePersonalizada(42f);

        }

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


        public void Catalogo_Load(object sender, EventArgs e)
        {
            ItemLoader itemLoader = new ItemLoader(this);
            itemLoader.LoadMotos();
        }

        private void imgCarrito_Click(object sender, EventArgs e)
        {
            Point mousePosition = Cursor.Position;

            CarritoForm carritoForm = CarritoForm.Instance;

            carritoForm.StartPosition = FormStartPosition.Manual;
            carritoForm.Location = mousePosition;

            DialogResult result = carritoForm.ShowDialog();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Point mousePosition = Cursor.Position;

            InsertarForm insertarForm = new InsertarForm();
            insertarForm.StartPosition = FormStartPosition.Manual;
            insertarForm.Location = mousePosition;

            DialogResult result = insertarForm.ShowDialog();

            Catalogo.Instance.Catalogo_Load(sender, e);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string marca = comboBoxMarca.Text;
            string tipo = comboBoxTipo.Text;
            string cilindrada = textBoxCilindrada.Text;

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

            EjecutarConsulta(consultaSql, marca, tipo, cilindrada);
        }
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
                        panelMainBikes.Controls.Clear();

                        while (reader.Read())
                        {
                            int motoId = reader.GetInt32(reader.GetOrdinal("id"));
                            string urlImagen = reader.GetString(reader.GetOrdinal("url_imagen"));

                            ItemLoader.CreateItem(motoId, urlImagen);
                        }
                    }
                }
            }
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            GraficoForm graficoForm = new GraficoForm();
            graficoForm.ShowDialog();
        }
    }
}
