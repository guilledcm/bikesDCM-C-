using bikesDCM.Conector;
using bikesDCM.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bikesDCM.masRecursos
{
    public partial class ModificarForm : Form
    {
        private Moto motoSeleccionada;

        public ModificarForm(int id)
        {
            InitializeComponent();
            this.motoSeleccionada = MotoConector._instance.motos.GetMotoById(id);

            comboBoxMarca.Text = motoSeleccionada.Marca;
            comboBoxTipo.Text = motoSeleccionada.Tipo;
            textBoxCilindrada.Text = motoSeleccionada.Cilindrada.ToString();
            textBoxPrecio.Text = motoSeleccionada.Precio.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nuevaMarca = comboBoxMarca.Text;
            string nuevoTipo = comboBoxTipo.Text;
            int nuevaCilindrada = int.Parse(textBoxCilindrada.Text);
            int nuevoPrecio = int.Parse(textBoxPrecio.Text);

            MotoConector._instance.ActualizarMoto(motoSeleccionada.Id,nuevaMarca,nuevoTipo,nuevaCilindrada,nuevoPrecio);

            this.Close();
        }
    }
}
