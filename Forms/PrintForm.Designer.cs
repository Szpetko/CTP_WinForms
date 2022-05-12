
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
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_printPreview = new System.Windows.Forms.Button();
            this.btn_svg = new System.Windows.Forms.Button();
            this.btn_pdf = new System.Windows.Forms.Button();
            this.btn_img = new System.Windows.Forms.Button();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.chbShowYRangeSelector = new System.Windows.Forms.CheckBox();
            this.chbShowXRangeSelector = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxLineType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxGridType = new System.Windows.Forms.ComboBox();
            this.chbShowLegend = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(37, 295);
            this.btn_print.Margin = new System.Windows.Forms.Padding(2);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(129, 38);
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_printPreview
            // 
            this.btn_printPreview.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_printPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_printPreview.ForeColor = System.Drawing.Color.White;
            this.btn_printPreview.Location = new System.Drawing.Point(37, 338);
            this.btn_printPreview.Margin = new System.Windows.Forms.Padding(2);
            this.btn_printPreview.Name = "btn_printPreview";
            this.btn_printPreview.Size = new System.Drawing.Size(129, 38);
            this.btn_printPreview.TabIndex = 2;
            this.btn_printPreview.Text = "Print Preview";
            this.btn_printPreview.UseVisualStyleBackColor = false;
            this.btn_printPreview.Click += new System.EventHandler(this.btn_printPreview_Click);
            // 
            // btn_svg
            // 
            this.btn_svg.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_svg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_svg.ForeColor = System.Drawing.Color.White;
            this.btn_svg.Location = new System.Drawing.Point(170, 338);
            this.btn_svg.Margin = new System.Windows.Forms.Padding(2);
            this.btn_svg.Name = "btn_svg";
            this.btn_svg.Size = new System.Drawing.Size(129, 38);
            this.btn_svg.TabIndex = 4;
            this.btn_svg.Text = "Export to SVG";
            this.btn_svg.UseVisualStyleBackColor = false;
            this.btn_svg.Click += new System.EventHandler(this.btn_svg_Click);
            // 
            // btn_pdf
            // 
            this.btn_pdf.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pdf.ForeColor = System.Drawing.Color.White;
            this.btn_pdf.Location = new System.Drawing.Point(170, 295);
            this.btn_pdf.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(129, 38);
            this.btn_pdf.TabIndex = 3;
            this.btn_pdf.Text = "Export to PDF";
            this.btn_pdf.UseVisualStyleBackColor = false;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // btn_img
            // 
            this.btn_img.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_img.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_img.ForeColor = System.Drawing.Color.White;
            this.btn_img.Location = new System.Drawing.Point(170, 381);
            this.btn_img.Margin = new System.Windows.Forms.Padding(2);
            this.btn_img.Name = "btn_img";
            this.btn_img.Size = new System.Drawing.Size(129, 38);
            this.btn_img.TabIndex = 5;
            this.btn_img.Text = "Export to Image";
            this.btn_img.UseVisualStyleBackColor = false;
            this.btn_img.Click += new System.EventHandler(this.btn_img_Click);
            // 
            // panelDisplay
            // 
            this.panelDisplay.Location = new System.Drawing.Point(12, 12);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(904, 278);
            this.panelDisplay.TabIndex = 6;
            // 
            // chbShowYRangeSelector
            // 
            this.chbShowYRangeSelector.AutoSize = true;
            this.chbShowYRangeSelector.Checked = true;
            this.chbShowYRangeSelector.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowYRangeSelector.Location = new System.Drawing.Point(346, 361);
            this.chbShowYRangeSelector.Name = "chbShowYRangeSelector";
            this.chbShowYRangeSelector.Size = new System.Drawing.Size(140, 17);
            this.chbShowYRangeSelector.TabIndex = 76;
            this.chbShowYRangeSelector.Text = "Show Y Range Selector";
            this.chbShowYRangeSelector.UseVisualStyleBackColor = true;
            this.chbShowYRangeSelector.CheckedChanged += new System.EventHandler(this.chbShowYRangeSelector_CheckedChanged);
            // 
            // chbShowXRangeSelector
            // 
            this.chbShowXRangeSelector.AutoSize = true;
            this.chbShowXRangeSelector.Checked = true;
            this.chbShowXRangeSelector.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowXRangeSelector.Location = new System.Drawing.Point(346, 333);
            this.chbShowXRangeSelector.Name = "chbShowXRangeSelector";
            this.chbShowXRangeSelector.Size = new System.Drawing.Size(140, 17);
            this.chbShowXRangeSelector.TabIndex = 75;
            this.chbShowXRangeSelector.Text = "Show X Range Selector";
            this.chbShowXRangeSelector.UseVisualStyleBackColor = true;
            this.chbShowXRangeSelector.CheckedChanged += new System.EventHandler(this.chbShowXRangeSelector_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Line Type:";
            // 
            // cbxLineType
            // 
            this.cbxLineType.FormattingEnabled = true;
            this.cbxLineType.Location = new System.Drawing.Point(590, 301);
            this.cbxLineType.Name = "cbxLineType";
            this.cbxLineType.Size = new System.Drawing.Size(121, 21);
            this.cbxLineType.TabIndex = 73;
            this.cbxLineType.SelectedIndexChanged += new System.EventHandler(this.cbxLineType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Grid Type:";
            // 
            // cbxGridType
            // 
            this.cbxGridType.FormattingEnabled = true;
            this.cbxGridType.Location = new System.Drawing.Point(590, 330);
            this.cbxGridType.Name = "cbxGridType";
            this.cbxGridType.Size = new System.Drawing.Size(121, 21);
            this.cbxGridType.TabIndex = 71;
            this.cbxGridType.SelectedIndexChanged += new System.EventHandler(this.cbxGridType_SelectedIndexChanged);
            // 
            // chbShowLegend
            // 
            this.chbShowLegend.AutoSize = true;
            this.chbShowLegend.Checked = true;
            this.chbShowLegend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowLegend.Location = new System.Drawing.Point(346, 307);
            this.chbShowLegend.Name = "chbShowLegend";
            this.chbShowLegend.Size = new System.Drawing.Size(92, 17);
            this.chbShowLegend.TabIndex = 70;
            this.chbShowLegend.Text = "Show Legend";
            this.chbShowLegend.UseVisualStyleBackColor = true;
            this.chbShowLegend.CheckedChanged += new System.EventHandler(this.chbShowLegend_CheckedChanged);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 436);
            this.Controls.Add(this.chbShowYRangeSelector);
            this.Controls.Add(this.chbShowXRangeSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxLineType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxGridType);
            this.Controls.Add(this.chbShowLegend);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.btn_img);
            this.Controls.Add(this.btn_svg);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.btn_printPreview);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PrintForm";
            this.Text = "PRINT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_printPreview;
        private System.Windows.Forms.Button btn_svg;
        private System.Windows.Forms.Button btn_pdf;
        private System.Windows.Forms.Button btn_img;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.CheckBox chbShowYRangeSelector;
        private System.Windows.Forms.CheckBox chbShowXRangeSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxLineType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxGridType;
        private System.Windows.Forms.CheckBox chbShowLegend;
    }
}