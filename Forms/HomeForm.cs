using MindFusion.Charting;
using MindFusion.Drawing;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace CTP_WinForms.Forms
{
    public partial class HomeForm : Form
    {
        private string path = "data.csv";
        private SolidBrush firstBrush;
        private SolidBrush secondBrush;

        public HomeForm()
        {
            InitializeComponent();

            // read path
            using (StreamReader sw = new StreamReader("path.txt"))
            {
                path = sw.ReadLine();
            }

            // create line brushes
            firstBrush = new SolidBrush(Color.FromArgb(102, 154, 204));
            secondBrush = new SolidBrush(Color.FromArgb(0, 0, 99));

            lineChart.LegendRenderer.Background = new SolidBrush(Color.FromArgb(220, 220, 220));
            lineChart.Theme.DataLabelsBackground = new SolidBrush(Color.White);
            lineChart.Theme.DataLabelsBorderStroke = new SolidBrush(Color.Gray);

            //load data
            IList<double> listA = new List<double>();
            List<double> listB = new List<double>();
            List<double> listC = new List<double>();

            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    NumberFormatInfo provider = new NumberFormatInfo();
                    provider.NumberDecimalSeparator = ".";
                    listA.Add(Convert.ToDouble(values[0], provider));
                    listB.Add(Convert.ToDouble(values[1], provider));
                    listC.Add(Convert.ToDouble(values[2], provider));
                }
            }

            // create sample data series
            lineChart.Series.Add(
                new Series2D(listA, listB, null)
                { Title = "Series listB" });

            lineChart.Series.Add(
                new Series2D(listA, listC, null)
                { Title = "Series listC" });

            lineChart.XAxis.Interval = 0.2;

            // assign one brush per series
            lineChart.Plot.SeriesStyle = new MixedSeriesStyle()
            {
                CommonFills = new List<Brush>() { firstBrush, secondBrush },
                CommonStrokes = new List<Brush>() { firstBrush, secondBrush },
                UniformStrokeThickness = 5
            };

            // customize look
            lineChart.ShowXRangeSelector = true;
            lineChart.XScrollRangeMin = 0;
            lineChart.XScrollRangeMax = listA.Max();
            lineChart.PinGrid = false;

            lineChart.ShowYRangeSelector = true;
            lineChart.YScrollRangeMin = 0;
            lineChart.YScrollRangeMax = 12;

            lineChart.Title = "";
            lineChart.XAxis.Title = "t[s]";
            lineChart.YAxis.Title = "U[v]";

            // set up grid type combo box
            cbxGridType.Items.Add(GridType.Crossed);
            cbxGridType.Items.Add(GridType.Horizontal);
            cbxGridType.Items.Add(GridType.None);
            cbxGridType.Items.Add(GridType.Vertical);
            cbxGridType.SelectedIndex = 0;
            lineChart.GridType = GridType.Crossed;

            // set up line type combo box
            cbxLineType.Items.Add(LineType.Polyline);
            cbxLineType.Items.Add(LineType.Step);
            cbxLineType.Items.Add(LineType.Curve);
            cbxLineType.SelectedIndex = 0;
            lineChart.LineType = LineType.Polyline;
        }

        

        private void chbShowYCoords_CheckedChanged(object sender, EventArgs e)
        {
            lineChart.ShowYCoordinates = !lineChart.ShowYCoordinates;
            lineChart.Invalidate();
        }

        private void chbShowLegend_CheckedChanged(object sender, EventArgs e)
        {
            lineChart.ShowLegend = !lineChart.ShowLegend;
            lineChart.Invalidate();
        }

        private void chbShowDataLabels_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowDataLabels.Checked)
                lineChart.ShowDataLabels = LabelKinds.All;
            else
                lineChart.ShowDataLabels = LabelKinds.None;
            lineChart.Invalidate();
        }

        private void tbXAxisMax_Scroll(object sender, EventArgs e)
        {
            lineChart.XAxis.MaxValue = tbXAxisMax.Value;
            lineChart.Invalidate();
        }

        private void tbYAxisMax_Scroll(object sender, EventArgs e)
        {
            lineChart.YAxis.MaxValue = tbYAxisMax.Value;
            lineChart.Invalidate();
        }

        private void tbXAxisMin_Scroll(object sender, EventArgs e)
        {
            lineChart.XAxis.MinValue = tbXAxisMin.Value;
            lineChart.Invalidate();
        }

        private void tbYAxisMin_Scroll(object sender, EventArgs e)
        {
            lineChart.YAxis.MinValue = tbYAxisMin.Value;
            lineChart.Invalidate();
        }

        private void tbXRangeMin_Scroll(object sender, EventArgs e)
        {
            lineChart.XScrollRangeMin = tbXRangeMin.Value;
            lineChart.Invalidate();
        }

        private void tbXRangeMax_Scroll(object sender, EventArgs e)
        {
            lineChart.XScrollRangeMax = tbXRangeMax.Value;
            lineChart.Invalidate();
        }

        private void tbYRangeMax_Scroll(object sender, EventArgs e)
        {
            lineChart.YScrollRangeMax = tbYRangeMax.Value;
            lineChart.Invalidate();
        }

        private void chbShowXRange_CheckedChanged(object sender, EventArgs e)
        {
            lineChart.ShowXRangeSelector = chbShowXRange.Checked;
            lineChart.XScrollRangeMin = tbXRangeMin.Value = -50;
            lineChart.XScrollRangeMax = tbXRangeMax.Value = 50;
        }

        private void chbShowYRange_CheckedChanged(object sender, EventArgs e)
        {
            lineChart.ShowYRangeSelector = chbShowYRange.Checked;
            lineChart.YScrollRangeMin = tbYRangeMin.Value = -50;
            lineChart.YScrollRangeMax = tbYRangeMax.Value = 50;
        }

        private void tbYRangeMin_Scroll(object sender, EventArgs e)
        {
            lineChart.YScrollRangeMin = tbYRangeMin.Value;
            lineChart.Invalidate();
        }

        private void chbShowXTicks_CheckedChanged(object sender, EventArgs e)
        {
            lineChart.ShowXTicks = !lineChart.ShowXTicks;
            lineChart.Invalidate();
        }

        private void chbShowYTicks_CheckedChanged(object sender, EventArgs e)
        {
            lineChart.ShowYTicks = !lineChart.ShowYTicks;
            lineChart.Invalidate();
        }

        private void chbShowXCoords_CheckedChanged(object sender, EventArgs e)
        {
            lineChart.ShowXCoordinates = !lineChart.ShowXCoordinates;
            lineChart.Invalidate();
        }

        private void cbxGridType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lineChart.GridType = (GridType)cbxGridType.SelectedItem;
            lineChart.Invalidate();
        }

        private void cbxLineType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lineChart.LineType = (LineType)cbxLineType.SelectedItem;
            lineChart.Invalidate();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Filter = "(PDF *.pdf)|*.pdf";
            var result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                lineChart.ExportPdf(dlg.FileName);
            }
        }
    }
}