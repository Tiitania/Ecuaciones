using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            datosBox.Text = "";


            this.chartA.Series.Clear();
            var SeriesAY = chartA.Series.Add("ValorY");
            SeriesAY.ChartType = SeriesChartType.Spline;
            SeriesAY.XValueType = ChartValueType.Single;
            chartA.Series["ValorY"].Color = Color.Red;


            string ecua = ecuacionBox.Text;
            string[] tokens = ecua.Split('^');
            double xini = -10.0;
            double y;


            for(int i = 1; i<=20; i++)
            {
                y = System.Math.Pow(xini, Double.Parse(tokens[1]));
                datosBox.Text = datosBox.Text + "    " + xini.ToString() + "    " + y.ToString() + Environment.NewLine;
                xini += 1.0;
                this.chartA.Series["ValorY"].Points.AddXY(xini, y);
            }
        }









        private void datosBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void chartA_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
