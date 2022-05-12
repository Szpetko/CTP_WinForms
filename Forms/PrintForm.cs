using CTP_WinFroms;
using MindFusion.Charting;
using System;
using System.Windows.Forms;

namespace CTP_WinForms.Forms
{
    public partial class PrintForm : Form
    {
        private Form activeForm;
        public HomeForm home = new CTP_WinForms.Forms.HomeForm();

        //Main Form
        public PrintForm()
        {
            InitializeComponent();

            // opening Home view
            OpenChildForm(home);

            // set up grid type combo box
            cbxGridType.Items.Add(GridType.Crossed);
            cbxGridType.Items.Add(GridType.Horizontal);
            cbxGridType.Items.Add(GridType.None);
            cbxGridType.Items.Add(GridType.Vertical);

            // set up line type combo box
            cbxLineType.Items.Add(LineType.Polyline);
            cbxLineType.Items.Add(LineType.Step);
            cbxLineType.Items.Add(LineType.Curve);
        }

        //Methods
        // opening form method
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Add(childForm);
            this.panelDisplay.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //Buttons
        private void btn_print_Click(object sender, EventArgs e)
        {
            // printing
            home.lineChart.Print();
        }

        private void btn_printPreview_Click(object sender, EventArgs e)
        {
            // opening preview to print
            home.lineChart.PrintPreview();
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            // opening windows file path finder/saver
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(PDF *.pdf)|*.pdf";
            var result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                // exporting to pdf
                home.lineChart.ExportPdf(dlg.FileName);
            }
        }

        private void btn_svg_Click(object sender, EventArgs e)
        {
            // opening windows file path finder/saver
            var dlg = new SaveFileDialog();
            dlg.Filter = "(SVG *.svg)|*.svg";
            var result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                // exporting to svg
                home.lineChart.ExportSvg(dlg.FileName);
            }
        }

        private void btn_img_Click(object sender, EventArgs e)
        {
            // opening windows file path finder/saver
            var dlg = new SaveFileDialog();
            dlg.Filter = "(BMP *.bmp)|*.bmp";
            var result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                // exporting to img
                home.lineChart.ExportImage(dlg.FileName);
            }
        }

        private void chbShowLegend_CheckedChanged(object sender, EventArgs e)
        {
            home.lineChart.ShowLegend = !home.lineChart.ShowLegend;
            home.lineChart.Invalidate();
        }

        private void chbShowXRangeSelector_CheckedChanged(object sender, EventArgs e)
        {
            home.lineChart.ShowXRangeSelector = !home.lineChart.ShowXRangeSelector;
            home.lineChart.Invalidate();
        }

        private void chbShowYRangeSelector_CheckedChanged(object sender, EventArgs e)
        {
            home.lineChart.ShowYRangeSelector = !home.lineChart.ShowYRangeSelector;
            home.lineChart.Invalidate();
        }

        private void cbxLineType_SelectedIndexChanged(object sender, EventArgs e)
        {
            home.lineChart.LineType = (LineType)cbxLineType.SelectedItem;
            home.lineChart.Invalidate();
        }

        private void cbxGridType_SelectedIndexChanged(object sender, EventArgs e)
        {
            home.lineChart.GridType = (GridType)cbxGridType.SelectedItem;
            home.lineChart.Invalidate();
        }
    }
}