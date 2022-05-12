
namespace CTP_WinForms.Forms
{
    partial class HomeForm
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
            this.lineChart = new MindFusion.Charting.WinForms.LineChart();
            this.chbShowLegend = new System.Windows.Forms.CheckBox();
            this.chbShowYCoords = new System.Windows.Forms.CheckBox();
            this.chbShowXCoords = new System.Windows.Forms.CheckBox();
            this.chbShowYTicks = new System.Windows.Forms.CheckBox();
            this.chbShowXTicks = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxLineType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxGridType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbYAxisMin = new System.Windows.Forms.TrackBar();
            this.tbXAxisMin = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tbYAxisMax = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tbXAxisMax = new System.Windows.Forms.TrackBar();
            this.chbShowXRangeSelector = new System.Windows.Forms.CheckBox();
            this.chbShowYRangeSelector = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbYAxisMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXAxisMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYAxisMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXAxisMax)).BeginInit();
            this.SuspendLayout();
            // 
            // lineChart
            // 
            this.lineChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineChart.LegendTitle = "Legend";
            this.lineChart.Location = new System.Drawing.Point(12, 12);
            this.lineChart.Name = "lineChart";
            this.lineChart.Padding = new System.Windows.Forms.Padding(5);
            this.lineChart.ShowLegend = true;
            this.lineChart.Size = new System.Drawing.Size(904, 261);
            this.lineChart.SubtitleFontName = null;
            this.lineChart.SubtitleFontSize = null;
            this.lineChart.SubtitleFontStyle = null;
            this.lineChart.TabIndex = 1;
            this.lineChart.Text = "lineChart1";
            this.lineChart.TitleFontName = null;
            this.lineChart.TitleFontSize = null;
            this.lineChart.TitleFontStyle = null;
            // 
            // chbShowLegend
            // 
            this.chbShowLegend.AutoSize = true;
            this.chbShowLegend.Checked = true;
            this.chbShowLegend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowLegend.Location = new System.Drawing.Point(191, 298);
            this.chbShowLegend.Name = "chbShowLegend";
            this.chbShowLegend.Size = new System.Drawing.Size(92, 17);
            this.chbShowLegend.TabIndex = 28;
            this.chbShowLegend.Text = "Show Legend";
            this.chbShowLegend.UseVisualStyleBackColor = true;
            this.chbShowLegend.CheckedChanged += new System.EventHandler(this.chbShowLegend_CheckedChanged);
            // 
            // chbShowYCoords
            // 
            this.chbShowYCoords.AutoSize = true;
            this.chbShowYCoords.Checked = true;
            this.chbShowYCoords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowYCoords.Location = new System.Drawing.Point(38, 371);
            this.chbShowYCoords.Name = "chbShowYCoords";
            this.chbShowYCoords.Size = new System.Drawing.Size(122, 17);
            this.chbShowYCoords.TabIndex = 27;
            this.chbShowYCoords.Text = "Show Y Coordinates";
            this.chbShowYCoords.UseVisualStyleBackColor = true;
            this.chbShowYCoords.CheckedChanged += new System.EventHandler(this.chbShowYCoords_CheckedChanged);
            // 
            // chbShowXCoords
            // 
            this.chbShowXCoords.AutoSize = true;
            this.chbShowXCoords.Checked = true;
            this.chbShowXCoords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowXCoords.Location = new System.Drawing.Point(38, 347);
            this.chbShowXCoords.Name = "chbShowXCoords";
            this.chbShowXCoords.Size = new System.Drawing.Size(122, 17);
            this.chbShowXCoords.TabIndex = 26;
            this.chbShowXCoords.Text = "Show X Coordinates";
            this.chbShowXCoords.UseVisualStyleBackColor = true;
            this.chbShowXCoords.CheckedChanged += new System.EventHandler(this.chbShowXCoords_CheckedChanged);
            // 
            // chbShowYTicks
            // 
            this.chbShowYTicks.AutoSize = true;
            this.chbShowYTicks.Checked = true;
            this.chbShowYTicks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowYTicks.Location = new System.Drawing.Point(38, 324);
            this.chbShowYTicks.Name = "chbShowYTicks";
            this.chbShowYTicks.Size = new System.Drawing.Size(92, 17);
            this.chbShowYTicks.TabIndex = 25;
            this.chbShowYTicks.Text = "Show Y Ticks";
            this.chbShowYTicks.UseVisualStyleBackColor = true;
            this.chbShowYTicks.CheckedChanged += new System.EventHandler(this.chbShowYTicks_CheckedChanged);
            // 
            // chbShowXTicks
            // 
            this.chbShowXTicks.AutoSize = true;
            this.chbShowXTicks.Checked = true;
            this.chbShowXTicks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowXTicks.Location = new System.Drawing.Point(38, 300);
            this.chbShowXTicks.Name = "chbShowXTicks";
            this.chbShowXTicks.Size = new System.Drawing.Size(92, 17);
            this.chbShowXTicks.TabIndex = 24;
            this.chbShowXTicks.Text = "Show X Ticks";
            this.chbShowXTicks.UseVisualStyleBackColor = true;
            this.chbShowXTicks.CheckedChanged += new System.EventHandler(this.chbShowXTicks_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Line Type:";
            // 
            // cbxLineType
            // 
            this.cbxLineType.FormattingEnabled = true;
            this.cbxLineType.Location = new System.Drawing.Point(422, 293);
            this.cbxLineType.Name = "cbxLineType";
            this.cbxLineType.Size = new System.Drawing.Size(121, 21);
            this.cbxLineType.TabIndex = 41;
            this.cbxLineType.SelectedIndexChanged += new System.EventHandler(this.cbxLineType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Grid Type:";
            // 
            // cbxGridType
            // 
            this.cbxGridType.FormattingEnabled = true;
            this.cbxGridType.Location = new System.Drawing.Point(635, 292);
            this.cbxGridType.Name = "cbxGridType";
            this.cbxGridType.Size = new System.Drawing.Size(121, 21);
            this.cbxGridType.TabIndex = 39;
            this.cbxGridType.SelectedIndexChanged += new System.EventHandler(this.cbxGridType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "YAxis Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "XAxis Min";
            // 
            // tbYAxisMin
            // 
            this.tbYAxisMin.Location = new System.Drawing.Point(412, 395);
            this.tbYAxisMin.Name = "tbYAxisMin";
            this.tbYAxisMin.Size = new System.Drawing.Size(104, 45);
            this.tbYAxisMin.TabIndex = 54;
            this.tbYAxisMin.Scroll += new System.EventHandler(this.tbYAxisMin_Scroll);
            // 
            // tbXAxisMin
            // 
            this.tbXAxisMin.Location = new System.Drawing.Point(415, 347);
            this.tbXAxisMin.Name = "tbXAxisMin";
            this.tbXAxisMin.Size = new System.Drawing.Size(104, 45);
            this.tbXAxisMin.TabIndex = 53;
            this.tbXAxisMin.Scroll += new System.EventHandler(this.tbXAxisMin_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "YAxis Max";
            // 
            // tbYAxisMax
            // 
            this.tbYAxisMax.Location = new System.Drawing.Point(636, 395);
            this.tbYAxisMax.Maximum = 20;
            this.tbYAxisMax.Minimum = 1;
            this.tbYAxisMax.Name = "tbYAxisMax";
            this.tbYAxisMax.Size = new System.Drawing.Size(104, 45);
            this.tbYAxisMax.TabIndex = 51;
            this.tbYAxisMax.Value = 20;
            this.tbYAxisMax.Scroll += new System.EventHandler(this.tbYAxisMax_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "XAxis Max";
            // 
            // tbXAxisMax
            // 
            this.tbXAxisMax.Location = new System.Drawing.Point(635, 347);
            this.tbXAxisMax.Maximum = 20;
            this.tbXAxisMax.Name = "tbXAxisMax";
            this.tbXAxisMax.Size = new System.Drawing.Size(104, 45);
            this.tbXAxisMax.TabIndex = 49;
            this.tbXAxisMax.Value = 12;
            this.tbXAxisMax.Scroll += new System.EventHandler(this.tbXAxisMax_Scroll);
            // 
            // chbShowXRangeSelector
            // 
            this.chbShowXRangeSelector.AutoSize = true;
            this.chbShowXRangeSelector.Checked = true;
            this.chbShowXRangeSelector.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowXRangeSelector.Location = new System.Drawing.Point(191, 324);
            this.chbShowXRangeSelector.Name = "chbShowXRangeSelector";
            this.chbShowXRangeSelector.Size = new System.Drawing.Size(140, 17);
            this.chbShowXRangeSelector.TabIndex = 68;
            this.chbShowXRangeSelector.Text = "Show X Range Selector";
            this.chbShowXRangeSelector.UseVisualStyleBackColor = true;
            this.chbShowXRangeSelector.CheckedChanged += new System.EventHandler(this.chbShowXRangeSelector_CheckedChanged);
            // 
            // chbShowYRangeSelector
            // 
            this.chbShowYRangeSelector.AutoSize = true;
            this.chbShowYRangeSelector.Checked = true;
            this.chbShowYRangeSelector.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowYRangeSelector.Location = new System.Drawing.Point(191, 352);
            this.chbShowYRangeSelector.Name = "chbShowYRangeSelector";
            this.chbShowYRangeSelector.Size = new System.Drawing.Size(140, 17);
            this.chbShowYRangeSelector.TabIndex = 69;
            this.chbShowYRangeSelector.Text = "Show Y Range Selector";
            this.chbShowYRangeSelector.UseVisualStyleBackColor = true;
            this.chbShowYRangeSelector.CheckedChanged += new System.EventHandler(this.chbShowYRangeSelector_CheckedChanged);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 443);
            this.Controls.Add(this.chbShowYRangeSelector);
            this.Controls.Add(this.chbShowXRangeSelector);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbYAxisMin);
            this.Controls.Add(this.tbXAxisMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbYAxisMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbXAxisMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxLineType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxGridType);
            this.Controls.Add(this.chbShowLegend);
            this.Controls.Add(this.chbShowYCoords);
            this.Controls.Add(this.chbShowXCoords);
            this.Controls.Add(this.chbShowYTicks);
            this.Controls.Add(this.chbShowXTicks);
            this.Controls.Add(this.lineChart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeForm";
            this.Text = "HOME";
            ((System.ComponentModel.ISupportInitialize)(this.tbYAxisMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXAxisMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYAxisMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXAxisMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chbShowLegend;
        private System.Windows.Forms.CheckBox chbShowYCoords;
        private System.Windows.Forms.CheckBox chbShowXCoords;
        private System.Windows.Forms.CheckBox chbShowYTicks;
        private System.Windows.Forms.CheckBox chbShowXTicks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxLineType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxGridType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar tbYAxisMin;
        private System.Windows.Forms.TrackBar tbXAxisMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbYAxisMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbXAxisMax;
        public MindFusion.Charting.WinForms.LineChart lineChart;
        private System.Windows.Forms.CheckBox chbShowXRangeSelector;
        private System.Windows.Forms.CheckBox chbShowYRangeSelector;
    }
}