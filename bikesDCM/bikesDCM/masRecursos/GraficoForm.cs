using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
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

namespace bikesDCM.masRecursos
{
    public partial class GraficoForm : Form
    {
        private PlotView plotView;
        private BasicConector connector;

        public GraficoForm()
        {
            InitializeComponent();
            InicializarComponentesPersonalizados();
            ConfigurarGrafico();
        }

        private void InicializarComponentesPersonalizados()
        {
            plotView = new PlotView();
            plotView.Dock = DockStyle.Fill;
            Controls.Add(plotView);
        }

        private void ConfigurarGrafico()
        {
            var plotModel = new PlotModel { Title = "motoGraphic" };

            var categoryAxis = new CategoryAxis { Position = AxisPosition.Bottom, Title = "Marcas" };
            plotModel.Axes.Add(categoryAxis);

            var valueAxis = new LinearAxis { Position = AxisPosition.Left, Minimum = 0, Title = "Cantidad de Motos" };
            plotModel.Axes.Add(valueAxis);

            plotView.Model = plotModel;
        }

        private void CargarDatosGrafico()
        {
            connector = new BasicConector();
            using (MySqlConnection conn = connector.GetConnection())
            {
                string[] marcas = { "ducati", "husqvarna", "honda" };

                foreach (var marca in marcas)
                {
                    string consultaSql = $"SELECT COUNT(*) FROM moto WHERE moto.marca = @marca";

                    using (MySqlCommand cmd = new MySqlCommand(consultaSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@marca", marca);

                        conn.Open();
                        int cantidadMotos = Convert.ToInt32(cmd.ExecuteScalar());
                        conn.Close();

                        AgregarBarraAlGrafico(marca, cantidadMotos);
                    }
                }
            }
        }

        private void AgregarBarraAlGrafico(string marca, int cantidadMotos)
        {
            var plotModel = (PlotModel)plotView.Model;
            var categoryAxis = plotModel.Axes[0] as CategoryAxis;

            if (!categoryAxis.Labels.Contains(marca))
            {
                categoryAxis.Labels.Add(marca);
            }

            var barSeries = new BarSeries
            {
                Items = { new BarItem { Value = cantidadMotos } },
                Title = marca
            };

            plotModel.Series.Add(barSeries);

            plotView.InvalidatePlot(true);
        }
    }
}
