using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bikesDCM
{
    public partial class CarritoForm : Form
    {
        // Instancia única del formulario (patrón Singleton)
        private static CarritoForm _instance;

        // Propiedad para acceder a la instancia única del formulario
        public static CarritoForm Instance
        {
            get
            {
                // Si la instancia no existe o está cerrada, crear una nueva instancia
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new CarritoForm();
                }
                return _instance;
            }
        }

        // Lista que almacena los precios en el carrito
        private List<int> preciosEnCarrito = new List<int>();

        // Constructor privado para el Singleton
        private CarritoForm()
        {
            InitializeComponent();
        }

        // Método para agregar un precio al carrito y actualizar la vista
        public void AgregarAlCarrito(int precio)
        {
            preciosEnCarrito.Add(precio);
            ActualizarVista();
        }

        // Método para actualizar la vista del carrito
        public void ActualizarVista()
        {
            // Limpiar los controles existentes en el flowLayoutPanel
            flowLayoutPanelCarrito.Controls.Clear();

            // Crear filas en el carrito para cada precio
            for (int i = 0; i < preciosEnCarrito.Count; i++)
            {
                FlowLayoutPanel fila = new FlowLayoutPanel();

                // Crear etiqueta para mostrar el precio
                Label labelPrecio = new Label();
                labelPrecio.Text = preciosEnCarrito[i].ToString();
                fila.Controls.Add(labelPrecio);

                // Crear botón para eliminar el precio del carrito
                Button btnEliminar = new Button();
                btnEliminar.Text = "X";
                btnEliminar.Tag = i;
                btnEliminar.Click += BtnEliminar_Click;
                fila.Controls.Add(btnEliminar);

                // Agregar la fila al flowLayoutPanel
                flowLayoutPanelCarrito.Controls.Add(fila);
            }

            // Mostrar el total de precios en el carrito
            Label labelTotal = new Label();
            labelTotal.Text = $"Total: {preciosEnCarrito.Sum().ToString()}";
            flowLayoutPanelCarrito.Controls.Add(labelTotal);
        }

        // Manejador de eventos para el clic en el botón eliminar
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Button btnEliminar = (Button)sender;
            int indice = (int)btnEliminar.Tag;

            // Verificar que el índice sea válido antes de eliminar
            if (indice >= 0 && indice < preciosEnCarrito.Count)
            {
                preciosEnCarrito.RemoveAt(indice);
                ActualizarVista();
            }
        }
    }
}
