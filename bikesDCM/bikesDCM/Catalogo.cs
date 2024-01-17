using bikesDCM.masRecursos;

namespace bikesDCM
{
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            ItemLoader itemLoader = new ItemLoader(this);
            itemLoader.LoadMotos();
        }
    }
}
