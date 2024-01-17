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
    }
}
