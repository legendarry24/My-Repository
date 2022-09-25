using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_of_function
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            MyChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            MyChart.Series[0].Color = System.Drawing.Color.Red;
            // MyChart.ChartAreas[0].AxisX.MajorGrid.Interval = 0.05;
            // MyChart.ChartAreas[0].AxisY.MajorGrid.Interval = 0.05;
            MyChart.ChartAreas[0].AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            MyChart.ChartAreas[0].AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
        }
        private void goButton_Click(object sender, EventArgs e)
        {
            try
            {
                double min = double.Parse(inputMin.Text);
                double max = double.Parse(inputMax.Text);
                double step = double.Parse(inputStep.Text);

                for (double x = min; x <= max; x += step)
                {
                    MyChart.Series[0].Points.AddXY(x, -x * Math.Log(x, 2));
                }
            }
            catch (Exception)
            {
                goButton.Enabled = false;
            }
            finally
            {
                goButton.Enabled = true;
            }
        }
    }
}
