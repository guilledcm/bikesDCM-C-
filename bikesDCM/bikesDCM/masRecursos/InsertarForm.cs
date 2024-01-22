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
        public Moto NuevaMoto { get; set; }
        public InsertarForm()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string marca = comboBoxMarca.Text;
            string tipo = comboBoxTipo.Text;
            int cilindrada = Convert.ToInt32(textBoxCilindrada.Text);
            int precio = Convert.ToInt32(textBoxPrecio.Text);

            NuevaMoto = new Moto(marca, tipo, cilindrada, precio);

            MotoConector._instance.InsertarMoto(NuevaMoto);

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}

