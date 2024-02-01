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

        // Constructor que recibe el ID de la moto a modificar
        public ModificarForm(int id)
        {
            InitializeComponent();
            this.motoSeleccionada = MotoConector._instance.motos.GetMotoById(id);

            // Configurar los controles del formulario con los valores de la moto seleccionada
            comboBoxMarca.Text = motoSeleccionada.Marca;
            comboBoxTipo.Text = motoSeleccionada.Tipo;
            textBoxCilindrada.Text = motoSeleccionada.Cilindrada.ToString();
            textBoxPrecio.Text = motoSeleccionada.Precio.ToString();
        }

        // Manejador de eventos para el clic en el botón "Modificar"
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Obtener los nuevos valores ingresados por el usuario
            string nuevaMarca = comboBoxMarca.Text;
            string nuevoTipo = comboBoxTipo.Text;
            int nuevaCilindrada = int.Parse(textBoxCilindrada.Text);
            int nuevoPrecio = int.Parse(textBoxPrecio.Text);

            // Actualizar la moto en la base de datos utilizando el conector
            MotoConector._instance.ActualizarMoto(motoSeleccionada.Id, nuevaMarca, nuevoTipo, nuevaCilindrada, nuevoPrecio);

            // Cerrar el formulario de modificación
            this.Close();
        }
    }
}
