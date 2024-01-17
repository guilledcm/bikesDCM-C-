using bikesDCM.Conector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bikesDCM
{
    internal class ItemLoader
    {
        private Catalogo Catalogo;
        public ItemLoader(Catalogo catalogo)
        {
            Catalogo = catalogo;
        }
        public void LoadMotos()
        {
            Catalogo.panelMainBikes.Controls.Clear();
            MotoConector._instance.LoadListFromDatabase();
            MotoConector._instance.motos.Motos.ForEach(moto => {
                CreateItem(moto.Id, moto.url_imagen);
            });
        }

        public void LoadFeatured() { }
        public void CreateItem(int id, string url_imagen)
        {
            Button b = new Button();
            b.Size = new Size(210, 210);
            b.Margin = new Padding(20, 20, 3, 3);
            b.Cursor = Cursors.Hand;
            b.FlatStyle = FlatStyle.Popup;

            if (File.Exists(url_imagen))
            {
                Image myimage = new Bitmap(url_imagen);
                b.BackgroundImage = myimage;
                b.BackgroundImageLayout = ImageLayout.Stretch;
                b.TextAlign = ContentAlignment.BottomCenter;
                b.Parent = Catalogo.panelMainBikes;
            }
            else
            {
                // Manejar el caso en que la imagen no existe
                // Puedes mostrar una imagen predeterminada o realizar alguna acción adecuada.
            }
        }
    }
}
