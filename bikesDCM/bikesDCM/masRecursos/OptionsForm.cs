using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bikesDCM
{
    internal class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Opciones";
            this.Size = new Size(250, 100);

            Button btnModificar = new Button();
            btnModificar.Text = "Modificar";
            btnModificar.DialogResult = DialogResult.Yes;
            btnModificar.Location = new Point(20, 20);
            btnModificar.Click += (sender, e) => this.Close();

            Button btnBorrar = new Button();
            btnBorrar.Text = "Borrar";
            btnBorrar.DialogResult = DialogResult.No;
            btnBorrar.Location = new Point(120, 20);
            btnBorrar.Click += (sender, e) => this.Close();

            this.Controls.Add(btnModificar);
            this.Controls.Add(btnBorrar);
        }
    }
}
