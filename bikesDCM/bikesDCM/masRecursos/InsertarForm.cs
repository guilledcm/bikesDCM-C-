using bikesDCM.Conector;
using bikesDCM.modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bikesDCM
{
    public partial class InsertarForm : Form
    {
        // Propiedad que contiene la nueva moto creada
        public Moto NuevaMoto { get; set; }

        // Constructor del formulario InsertarForm
        public InsertarForm()
        {
            InitializeComponent();
        }

        // Manejador de eventos para el clic en el botón "Go"
        private void btnGo_Click(object sender, EventArgs e)
        {
            // Obtener datos del formulario
            string marca = comboBoxMarca.Text;
            string tipo = comboBoxTipo.Text;
            int cilindrada = Convert.ToInt32(textBoxCilindrada.Text);
            int precio = Convert.ToInt32(textBoxPrecio.Text);

            // Crear una nueva instancia de Moto con los datos ingresados
            NuevaMoto = new Moto(marca, tipo, cilindrada, precio);

            // Insertar la nueva moto en la base de datos utilizando el conector
            MotoConector._instance.InsertarMoto(NuevaMoto);

            // Establecer el resultado del cuadro de diálogo como OK y cerrar el formulario
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
