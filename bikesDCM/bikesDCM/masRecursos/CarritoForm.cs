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
        private static CarritoForm _instance;

        public static CarritoForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new CarritoForm();
                }
                return _instance;
            }
        }

        private List<int> preciosEnCarrito = new List<int>();

        private CarritoForm()
        {
            InitializeComponent();
        }

        public void AgregarAlCarrito(int precio)
        {
            preciosEnCarrito.Add(precio);
            ActualizarVista();
        }

        public void ActualizarVista()
        {
            flowLayoutPanelCarrito.Controls.Clear();

            for (int i = 0; i < preciosEnCarrito.Count; i++)
            {
                FlowLayoutPanel fila = new FlowLayoutPanel();

                Label labelPrecio = new Label();
                labelPrecio.Text = preciosEnCarrito[i].ToString();
                fila.Controls.Add(labelPrecio);


                Button btnEliminar = new Button();
                btnEliminar.Text = "X";
                btnEliminar.Tag = i; 
                btnEliminar.Click += BtnEliminar_Click; 
                fila.Controls.Add(btnEliminar);

                flowLayoutPanelCarrito.Controls.Add(fila);
            }

            Label labelTotal = new Label();
            labelTotal.Text = $"Total: {preciosEnCarrito.Sum().ToString()}";
            flowLayoutPanelCarrito.Controls.Add(labelTotal);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Button btnEliminar = (Button)sender;
            int indice = (int)btnEliminar.Tag;

            if (indice >= 0 && indice < preciosEnCarrito.Count)
            {
                preciosEnCarrito.RemoveAt(indice);
                ActualizarVista();
            }
        }
    }


}
