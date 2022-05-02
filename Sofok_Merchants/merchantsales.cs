using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFOK_System
{
    public partial class merchantsales : Form
    {
        public merchantsales()
        {
            InitializeComponent();
        }

        private void merchantsales_Load(object sender, EventArgs e)
        {
            populatedatagridview();


            revenueBindingSource.DataSource = new List<revenue>();
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "MONTH",
                Labels = new[] {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "REVENUE",
                LabelFormatter = value => value.ToString("C")
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
        }

        void populatedatagridview()
        {
            //laman ng datagridview for visual representation lungs
            bestproductsdatagrid.Rows.Add("sample", "12", "₱ 00.00");
            bestproductsdatagrid.Rows.Add("sample", "9", "₱ 00.00");
            bestproductsdatagrid.Rows.Add("sample", "5", "₱ 00.00");
            bestproductsdatagrid.Rows.Add("sample", "2", "₱ 00.00");

        }

        private void bunifuLabel11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            //Initialize Data
            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            var years = (from o in revenueBindingSource.DataSource as List<revenue>
                         select new { Year = o.Year }).Distinct();

            foreach(var year in years)
            {
                List<double> values = new List<double>();
                for(int month = 1; month <= 12; month++)
                {
                    double value = 0;
                    var data = from o in revenueBindingSource.DataSource as List<revenue>
                               where o.Year.Equals(year.Year) && o.Month.Equals(month)
                               orderby o.Month ascending
                               select new { o.Value, o.Month };
                    if (data.SingleOrDefault() != null)
                        value = data.SingleOrDefault().Value;
                    values.Add(value);
                }
                series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<double>(values) });
            }
            cartesianChart1.Series = series;
        }
    }
}
