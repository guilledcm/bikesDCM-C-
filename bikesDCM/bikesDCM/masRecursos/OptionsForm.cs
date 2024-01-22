using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bikesDCM
{
    internal class OptionsForm : Form
    {

        public int MotoPrecio { get; set; }
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Opciones";
            this.Size = new Size(550, 100);
            this.BackColor = Color.Gray;

            Button btnModificar = new Button();
            btnModificar.Text = "Modificar";
            btnModificar.DialogResult = DialogResult.Yes;
            btnModificar.Location = new Point(20, 20);
            btnModificar.Click += (sender, e) => this.Close();

            Button btnBorrar = new Button();
            btnBorrar.Text = "Borrar";
            btnBorrar.DialogResult = DialogResult.No;
            btnBorrar.Location = new Point(220, 20);
            btnBorrar.Click += (sender, e) => this.Close();

            Button btnAnadirCarrito = new Button();
            btnAnadirCarrito.Text = "Carrito";
            btnAnadirCarrito.DialogResult = DialogResult.Continue;
            btnAnadirCarrito.Location = new Point(420, 20);
            btnAnadirCarrito.Click += (sender, e) => this.Close();

            this.Controls.Add(btnModificar);
            this.Controls.Add(btnBorrar);
            this.Controls.Add(btnAnadirCarrito);
        }
    }
}
