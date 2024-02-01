using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bikesDCM.Conector;
using MySql.Data.MySqlClient;
using OxyPlot.Axes;
using OxyPlot.WindowsForms;
using OxyPlot;

namespace bikesDCM.masRecursos
{
    public partial class GraficoForm : Form
    {
        // Conector básico para operaciones con la base de datos
        private BasicConector connector;

        // Constructor del formulario GraficoForm
        public GraficoForm()
        {
            InitializeComponent();
            CrearGrafico();
        }

        // Método para crear y configurar el gráfico de barras
        private void CrearGrafico()
        {
            // Crear un nuevo modelo de gráfico
            var model = new PlotModel
            {
                Title = "Cantidad de motos por marca",
                Subtitle = "Gráfico de Barras",
            };

            // Configurar ejes del gráfico
            var yAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Marca",
            };

            var xAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Cantidad",
                MinimumPadding = 0,
                AbsoluteMinimum = 0,
            };

            model.Axes.Add(yAxis);
            model.Axes.Add(xAxis);

            // Configurar la serie de barras
            var barSeries = new BarSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}",
                FillColor = OxyColor.FromRgb(173, 245, 215)
            };

            try
            {
                // Obtener datos de la base de datos y llenar el gráfico
                connector = new BasicConector();
                using (MySqlConnection conn = connector.GetConnection())
                {
                    string consulta = "SELECT marca, COUNT(*) AS Cantidad FROM moto GROUP BY marca ORDER BY marca;";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conn))
                    {
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Obtener datos de la consulta
                                string marca = reader["marca"].ToString();
                                int cantidad = Convert.ToInt32(reader["Cantidad"]);

                                // Agregar etiquetas al eje Y y valores a la serie de barras
                                yAxis.Labels.Add(marca);
                                barSeries.Items.Add(new BarItem { Value = cantidad });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar errores al cargar datos y mostrar un mensaje de error
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Agregar la serie de barras al modelo del gráfico
            model.Series.Add(barSeries);

            // Crear y configurar la vista del gráfico OxyPlot
            OxyPlot.WindowsForms.PlotView oxyPlotView = new OxyPlot.WindowsForms.PlotView
            {
                Model = model,
                Dock = DockStyle.Fill
            };

            // Agregar la vista del gráfico al formulario
            this.Controls.Add(oxyPlotView);
        }
    }
}
