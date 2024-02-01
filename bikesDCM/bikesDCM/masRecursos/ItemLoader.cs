using bikesDCM.Conector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO; // Necesario para la verificación de existencia del archivo

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
            // Limpiar los controles existentes en el panel principal
            Catalogo.panelMainBikes.Controls.Clear();

            // Cargar la lista de motos desde la base de datos
            MotoConector._instance.LoadListFromDatabase();

            // Iterar sobre la lista de motos y crear los elementos visuales correspondientes
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
            b.Tag = id; // Asignar el ID de la moto como Tag al botón

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
                case DialogResult.Yes:
                    // Modificar la moto
                    ModificarForm modificarForm = new ModificarForm(itemId);

                    modificarForm.StartPosition = FormStartPosition.Manual;
                    modificarForm.Location = mousePosition;

                    DialogResult result2 = modificarForm.ShowDialog();

                    Catalogo.Instance.Catalogo_Load(sender, e);
                    break;

                case DialogResult.No:
                    // Borrar la moto
                    DialogResult secondConfirmation = MessageBox.Show("¿Realmente quieres borrar esta PRECIOSIDAD?", "Confirmar Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (secondConfirmation == DialogResult.Yes)
                    {
                        MotoConector._instance.EliminarMoto(itemId);

                        // Eliminar el botón correspondiente de la lista de controles
                        foreach (Control control in Catalogo.Instance.panelMainBikes.Controls)
                        {
                            if (control is Button && Convert.ToInt32(control.Tag) == itemId)
                            {
                                Catalogo.Instance.panelMainBikes.Controls.Remove(control);
                                break;
                            }
                        }

                        // Eliminar la moto de la lista
                        MotoConector._instance.motos.Motos.RemoveAll(m => m.Id == itemId);

                        Catalogo.Instance.Catalogo_Load(sender, e);
                    }
                    break;

                case DialogResult.Continue:
                    // Añadir la moto al carrito
                    MotoConector._instance.AddCarritoMoto(itemId);
                    Catalogo.Instance.Catalogo_Load(sender, e);
                    break;
            }
        }
    }
}
