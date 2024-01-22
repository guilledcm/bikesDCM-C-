using bikesDCM.masRecursos;

namespace bikesDCM
{
    public partial class Catalogo : Form
    {
        private static Catalogo _instance;
        public Catalogo()
        {
            InitializeComponent();
            _instance = this;
        }
        public static Catalogo Instance
        {
            get { return _instance; }
        }

        public void Catalogo_Load(object sender, EventArgs e)
        {
            ItemLoader itemLoader = new ItemLoader(this);
            itemLoader.LoadMotos();
        }

        private void imgCarrito_Click(object sender, EventArgs e)
        {
            Point mousePosition = Cursor.Position;

            CarritoForm carritoForm = new CarritoForm();

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
    }
}
