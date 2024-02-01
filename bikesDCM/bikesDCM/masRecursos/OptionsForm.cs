using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Necesario para la clase Form

namespace bikesDCM
{
    // Clase interna OptionsForm hereda de Form
    internal class OptionsForm : Form
    {
        // Propiedad para almacenar el precio de la moto
        public int MotoPrecio { get; set; }

        // Constructor de la clase OptionsForm
        public OptionsForm()
        {
            // Inicializa el formulario
            InitializeComponent();
        }

        // Método para configurar y agregar controles al formulario
        private void InitializeComponent()
        {
            // Configuración del formulario
            this.Text = "Opciones";
            this.Size = new System.Drawing.Size(550, 100);
            this.BackColor = System.Drawing.Color.Gray;

            // Creación y configuración del botón "Modificar"
            Button btnModificar = new Button();
            btnModificar.Text = "Modificar";
            btnModificar.DialogResult = DialogResult.Yes;
            btnModificar.Location = new System.Drawing.Point(20, 20);
            btnModificar.Click += (sender, e) => this.Close(); // Cierra el formulario al hacer clic en el botón

            // Creación y configuración del botón "Borrar"
            Button btnBorrar = new Button();
            btnBorrar.Text = "Borrar";
            btnBorrar.DialogResult = DialogResult.No;
            btnBorrar.Location = new System.Drawing.Point(220, 20);
            btnBorrar.Click += (sender, e) => this.Close(); // Cierra el formulario al hacer clic en el botón

            // Creación y configuración del botón "Añadir al Carrito"
            Button btnAnadirCarrito = new Button();
            btnAnadirCarrito.Text = "Carrito";
            btnAnadirCarrito.DialogResult = DialogResult.Continue;
            btnAnadirCarrito.Location = new System.Drawing.Point(420, 20);
            btnAnadirCarrito.Click += (sender, e) => this.Close(); // Cierra el formulario al hacer clic en el botón

            // Agrega los botones al formulario
            this.Controls.Add(btnModificar);
            this.Controls.Add(btnBorrar);
            this.Controls.Add(btnAnadirCarrito);
        }
    }
}
