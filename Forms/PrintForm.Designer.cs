
namespace CTP_WinForms.Forms
{
    partial class PrintForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lineChartPrint = new MindFusion.Charting.WinForms.LineChart();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_printPreview = new System.Windows.Forms.Button();
            this.btn_svg = new System.Windows.Forms.Button();
            this.btn_pdf = new System.Windows.Forms.Button();
            this.btn_img = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lineChartPrint
            // 
            this.lineChartPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineChartPrint.LegendTitle = "Legend";
            this.lineChartPrint.Location = new System.Drawing.Point(12, 12);
            this.lineChartPrint.Name = "lineChartPrint";
            this.lineChartPrint.Padding = new System.Windows.Forms.Padding(5);
            this.lineChartPrint.ShowLegend = true;
            this.lineChartPrint.Size = new System.Drawing.Size(1238, 279);
            this.lineChartPrint.SubtitleFontName = null;
            this.lineChartPrint.SubtitleFontSize = null;
            this.lineChartPrint.SubtitleFontStyle = null;
            this.lineChartPrint.TabIndex = 0;
            this.lineChartPrint.Text = "lineChart1";
            this.lineChartPrint.Theme.UniformSeriesFill = new MindFusion.Drawing.SolidBrush("#FF90EE90");
            this.lineChartPrint.Theme.UniformSeriesStroke = new MindFusion.Drawing.SolidBrush("#FF000000");
            this.lineChartPrint.Theme.UniformSeriesStrokeThickness = 2D;
            this.lineChartPrint.TitleFontName = null;
            this.lineChartPrint.TitleFontSize = null;
            this.lineChartPrint.TitleFontStyle = null;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(12, 321);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(172, 47);
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            // 
            // btn_printPreview
            // 
            this.btn_printPreview.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_printPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_printPreview.ForeColor = System.Drawing.Color.White;
            this.btn_printPreview.Location = new System.Drawing.Point(12, 374);
            this.btn_printPreview.Name = "btn_printPreview";
            this.btn_printPreview.Size = new System.Drawing.Size(172, 47);
            this.btn_printPreview.TabIndex = 2;
            this.btn_printPreview.Text = "Print Preview";
            this.btn_printPreview.UseVisualStyleBackColor = false;
            // 
            // btn_svg
            // 
            this.btn_svg.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_svg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_svg.ForeColor = System.Drawing.Color.White;
            this.btn_svg.Location = new System.Drawing.Point(190, 374);
            this.btn_svg.Name = "btn_svg";
            this.btn_svg.Size = new System.Drawing.Size(172, 47);
            this.btn_svg.TabIndex = 4;
            this.btn_svg.Text = "Export to SVG";
            this.btn_svg.UseVisualStyleBackColor = false;
            // 
            // btn_pdf
            // 
            this.btn_pdf.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pdf.ForeColor = System.Drawing.Color.White;
            this.btn_pdf.Location = new System.Drawing.Point(190, 321);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(172, 47);
            this.btn_pdf.TabIndex = 3;
            this.btn_pdf.Text = "Export to PDF";
            this.btn_pdf.UseVisualStyleBackColor = false;
            // 
            // btn_img
            // 
            this.btn_img.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_img.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_img.ForeColor = System.Drawing.Color.White;
            this.btn_img.Location = new System.Drawing.Point(190, 427);
            this.btn_img.Name = "btn_img";
            this.btn_img.Size = new System.Drawing.Size(172, 47);
            this.btn_img.TabIndex = 5;
            this.btn_img.Text = "Export to Image";
            this.btn_img.UseVisualStyleBackColor = false;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 593);
            this.Controls.Add(this.btn_img);
            this.Controls.Add(this.lineChartPrint);
            this.Controls.Add(this.btn_svg);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.btn_printPreview);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MindFusion.Charting.WinForms.LineChart lineChartPrint;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_printPreview;
        private System.Windows.Forms.Button btn_svg;
        private System.Windows.Forms.Button btn_pdf;
        private System.Windows.Forms.Button btn_img;
    }
}