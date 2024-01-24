using bikesDCM.Conector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bikesDCM.masRecursos
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
            MotoConector._instance.motos.Motos.ForEach(moto =>
            {
                CreateItem(moto.Id, moto.url_imagen);
            });
        }

        public static void CreateItem(int id, string url_imagen)
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
            }

            b.Click += (sender, e) => Button_Click(sender, e, id);

            Catalogo.Instance.panelMainBikes.Controls.Add(b);
        }

        private static void Button_Click(object sender, EventArgs e, int itemId)
        {
            Point mousePosition = Cursor.Position;

            OptionsForm optionsForm = new OptionsForm();

            optionsForm.StartPosition = FormStartPosition.Manual;
            optionsForm.Location = mousePosition;

            DialogResult result = optionsForm.ShowDialog();


            switch (result)
            {
                //el yes es modificar
                case DialogResult.Yes:
                    ModificarForm modificarForm = new ModificarForm(itemId); 

                    modificarForm.StartPosition = FormStartPosition.Manual;
                    modificarForm.Location = mousePosition;

                    DialogResult result2 = modificarForm.ShowDialog();

                    Catalogo.Instance.Catalogo_Load(sender, e);
                    break;

                //el no es borrar
                case DialogResult.No:
                    MotoConector._instance.EliminarMoto(itemId);

                    foreach (Control control in Catalogo.Instance.panelMainBikes.Controls)
                    {
                        if (control is Button && Convert.ToInt32(control.Tag) == itemId)
                        {
                            Catalogo.Instance.panelMainBikes.Controls.Remove(control);
                            break;
                        }
                    }

                    MotoConector._instance.motos.Motos.RemoveAll(m => m.Id == itemId);

                    Catalogo.Instance.Catalogo_Load(sender, e);

                    break;

                //el continue es opcion para añadir al carrito
                case DialogResult.Continue:
                    MotoConector._instance.AddCarritoMoto(itemId);
                    Catalogo.Instance.Catalogo_Load(sender, e);
                    break;
            }
        }
    }
}
