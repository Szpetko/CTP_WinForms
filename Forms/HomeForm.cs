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

        //Main Form
        public HomeForm()
        {
            InitializeComponent();

            // reading path from a file
            using (StreamReader sr = new StreamReader("path.txt"))
            {
                path = sr.ReadLine();
            }

            // create line brushes
            firstBrush = new SolidBrush(Color.FromArgb(102, 154, 204));
            secondBrush = new SolidBrush(Color.FromArgb(0, 0, 99));

            lineChart.LegendRenderer.Background = new SolidBrush(Color.FromArgb(220, 220, 220));
            lineChart.Theme.DataLabelsBackground = new SolidBrush(Color.White);
            lineChart.Theme.DataLabelsBorderStroke = new SolidBrush(Color.Gray);

            // load data
            IList<double> listA = new List<double>();
            List<double> listB = new List<double>();
            List<double> listC = new List<double>();

            // firs row from data
            string[] titles;

            // opening file from a path
            using (var sr = new StreamReader(path))
            {
                // reading and spliting title data
                var line_titles = sr.ReadLine();
                titles = line_titles.Split(',');

                while (!sr.EndOfStream)
                {
                    // reading and spliting main data
                    var line = sr.ReadLine();
                    var values = line.Split(',');

                    // saving data to lists
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
                { Title = "Series " + titles[1] });

            lineChart.Series.Add(
                new Series2D(listA, listC, null)
                { Title = "Series " + titles[2] });

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
            lineChart.XScrollRangeMin = -1;
            lineChart.XScrollRangeMax = listA.Max() + 1;
            lineChart.PinGrid = false;

            lineChart.ShowYRangeSelector = true;
            lineChart.YScrollRangeMin = -1;
            lineChart.YScrollRangeMax = listB.Max() + 1;

            lineChart.Title = "";
            lineChart.XAxis.Title = titles[0];
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

        //Buttons
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

        private void chbShowXRangeSelector_CheckedChanged(object sender, EventArgs e)
        {
            lineChart.ShowXRangeSelector = !lineChart.ShowXRangeSelector;
            lineChart.Invalidate();
        }

        private void chbShowYRangeSelector_CheckedChanged(object sender, EventArgs e)
        {
            lineChart.ShowYRangeSelector = !lineChart.ShowYRangeSelector;
            lineChart.Invalidate();
        }
    }
}