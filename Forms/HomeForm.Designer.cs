
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
            this.chbShowDataLabels = new System.Windows.Forms.CheckBox();
            this.chbShowYRange = new System.Windows.Forms.CheckBox();
            this.chbShowXRange = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbYRangeMin = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.tbYRangeMax = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.tbXRangeMin = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.tbXRangeMax = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbYAxisMin = new System.Windows.Forms.TrackBar();
            this.tbXAxisMin = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tbYAxisMax = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tbXAxisMax = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbYRangeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYRangeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXRangeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXRangeMax)).BeginInit();
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
            this.lineChart.Location = new System.Drawing.Point(13, 13);
            this.lineChart.Margin = new System.Windows.Forms.Padding(4);
            this.lineChart.Name = "lineChart";
            this.lineChart.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lineChart.ShowLegend = true;
            this.lineChart.Size = new System.Drawing.Size(1016, 279);
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
            this.chbShowLegend.Location = new System.Drawing.Point(13, 418);
            this.chbShowLegend.Margin = new System.Windows.Forms.Padding(4);
            this.chbShowLegend.Name = "chbShowLegend";
            this.chbShowLegend.Size = new System.Drawing.Size(116, 21);
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
            this.chbShowYCoords.Location = new System.Drawing.Point(13, 389);
            this.chbShowYCoords.Margin = new System.Windows.Forms.Padding(4);
            this.chbShowYCoords.Name = "chbShowYCoords";
            this.chbShowYCoords.Size = new System.Drawing.Size(157, 21);
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
            this.chbShowXCoords.Location = new System.Drawing.Point(13, 359);
            this.chbShowXCoords.Margin = new System.Windows.Forms.Padding(4);
            this.chbShowXCoords.Name = "chbShowXCoords";
            this.chbShowXCoords.Size = new System.Drawing.Size(157, 21);
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
            this.chbShowYTicks.Location = new System.Drawing.Point(13, 330);
            this.chbShowYTicks.Margin = new System.Windows.Forms.Padding(4);
            this.chbShowYTicks.Name = "chbShowYTicks";
            this.chbShowYTicks.Size = new System.Drawing.Size(114, 21);
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
            this.chbShowXTicks.Location = new System.Drawing.Point(13, 300);
            this.chbShowXTicks.Margin = new System.Windows.Forms.Padding(4);
            this.chbShowXTicks.Name = "chbShowXTicks";
            this.chbShowXTicks.Size = new System.Drawing.Size(114, 21);
            this.chbShowXTicks.TabIndex = 24;
            this.chbShowXTicks.Text = "Show X Ticks";
            this.chbShowXTicks.UseVisualStyleBackColor = true;
            this.chbShowXTicks.CheckedChanged += new System.EventHandler(this.chbShowXTicks_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 304);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Line Type:";
            // 
            // cbxLineType
            // 
            this.cbxLineType.FormattingEnabled = true;
            this.cbxLineType.Location = new System.Drawing.Point(280, 297);
            this.cbxLineType.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLineType.Name = "cbxLineType";
            this.cbxLineType.Size = new System.Drawing.Size(160, 24);
            this.cbxLineType.TabIndex = 41;
            this.cbxLineType.SelectedIndexChanged += new System.EventHandler(this.cbxLineType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 332);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Grid Type:";
            // 
            // cbxGridType
            // 
            this.cbxGridType.FormattingEnabled = true;
            this.cbxGridType.Location = new System.Drawing.Point(280, 327);
            this.cbxGridType.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGridType.Name = "cbxGridType";
            this.cbxGridType.Size = new System.Drawing.Size(160, 24);
            this.cbxGridType.TabIndex = 39;
            this.cbxGridType.SelectedIndexChanged += new System.EventHandler(this.cbxGridType_SelectedIndexChanged);
            // 
            // chbShowDataLabels
            // 
            this.chbShowDataLabels.AutoSize = true;
            this.chbShowDataLabels.Checked = true;
            this.chbShowDataLabels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowDataLabels.Location = new System.Drawing.Point(195, 378);
            this.chbShowDataLabels.Margin = new System.Windows.Forms.Padding(4);
            this.chbShowDataLabels.Name = "chbShowDataLabels";
            this.chbShowDataLabels.Size = new System.Drawing.Size(144, 21);
            this.chbShowDataLabels.TabIndex = 38;
            this.chbShowDataLabels.Text = "Show Data Labels";
            this.chbShowDataLabels.UseVisualStyleBackColor = true;
            this.chbShowDataLabels.CheckedChanged += new System.EventHandler(this.chbShowDataLabels_CheckedChanged);
            // 
            // chbShowYRange
            // 
            this.chbShowYRange.AutoSize = true;
            this.chbShowYRange.Checked = true;
            this.chbShowYRange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowYRange.Location = new System.Drawing.Point(496, 496);
            this.chbShowYRange.Margin = new System.Windows.Forms.Padding(4);
            this.chbShowYRange.Name = "chbShowYRange";
            this.chbShowYRange.Size = new System.Drawing.Size(179, 21);
            this.chbShowYRange.TabIndex = 66;
            this.chbShowYRange.Text = "Show Y Range Selector";
            this.chbShowYRange.UseVisualStyleBackColor = true;
            this.chbShowYRange.CheckedChanged += new System.EventHandler(this.chbShowYRange_CheckedChanged);
            // 
            // chbShowXRange
            // 
            this.chbShowXRange.AutoSize = true;
            this.chbShowXRange.Checked = true;
            this.chbShowXRange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowXRange.Location = new System.Drawing.Point(11, 496);
            this.chbShowXRange.Margin = new System.Windows.Forms.Padding(4);
            this.chbShowXRange.Name = "chbShowXRange";
            this.chbShowXRange.Size = new System.Drawing.Size(179, 21);
            this.chbShowXRange.TabIndex = 65;
            this.chbShowXRange.Text = "Show X Range Selector";
            this.chbShowXRange.UseVisualStyleBackColor = true;
            this.chbShowXRange.CheckedChanged += new System.EventHandler(this.chbShowXRange_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(496, 534);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 64;
            this.label9.Text = "Y Range Min";
            // 
            // tbYRangeMin
            // 
            this.tbYRangeMin.Location = new System.Drawing.Point(577, 534);
            this.tbYRangeMin.Margin = new System.Windows.Forms.Padding(4);
            this.tbYRangeMin.Maximum = 100;
            this.tbYRangeMin.Minimum = -100;
            this.tbYRangeMin.Name = "tbYRangeMin";
            this.tbYRangeMin.Size = new System.Drawing.Size(139, 56);
            this.tbYRangeMin.TabIndex = 63;
            this.tbYRangeMin.Value = -50;
            this.tbYRangeMin.Scroll += new System.EventHandler(this.tbYRangeMin_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(724, 534);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 62;
            this.label10.Text = "Y Range Max";
            // 
            // tbYRangeMax
            // 
            this.tbYRangeMax.Location = new System.Drawing.Point(813, 534);
            this.tbYRangeMax.Margin = new System.Windows.Forms.Padding(4);
            this.tbYRangeMax.Maximum = 100;
            this.tbYRangeMax.Minimum = -100;
            this.tbYRangeMax.Name = "tbYRangeMax";
            this.tbYRangeMax.Size = new System.Drawing.Size(139, 56);
            this.tbYRangeMax.TabIndex = 61;
            this.tbYRangeMax.Value = 50;
            this.tbYRangeMax.Scroll += new System.EventHandler(this.tbYRangeMax_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 534);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "X Range Min";
            // 
            // tbXRangeMin
            // 
            this.tbXRangeMin.Location = new System.Drawing.Point(92, 534);
            this.tbXRangeMin.Margin = new System.Windows.Forms.Padding(4);
            this.tbXRangeMin.Maximum = 100;
            this.tbXRangeMin.Minimum = -100;
            this.tbXRangeMin.Name = "tbXRangeMin";
            this.tbXRangeMin.Size = new System.Drawing.Size(139, 56);
            this.tbXRangeMin.TabIndex = 59;
            this.tbXRangeMin.Value = -50;
            this.tbXRangeMin.Scroll += new System.EventHandler(this.tbXRangeMin_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 534);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "X Range Max";
            // 
            // tbXRangeMax
            // 
            this.tbXRangeMax.Location = new System.Drawing.Point(328, 534);
            this.tbXRangeMax.Margin = new System.Windows.Forms.Padding(4);
            this.tbXRangeMax.Maximum = 100;
            this.tbXRangeMax.Minimum = -100;
            this.tbXRangeMax.Name = "tbXRangeMax";
            this.tbXRangeMax.Size = new System.Drawing.Size(139, 56);
            this.tbXRangeMax.TabIndex = 57;
            this.tbXRangeMax.Value = 50;
            this.tbXRangeMax.Scroll += new System.EventHandler(this.tbXRangeMax_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(496, 451);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "YAxis Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 451);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "XAxis Min";
            // 
            // tbYAxisMin
            // 
            this.tbYAxisMin.Location = new System.Drawing.Point(572, 451);
            this.tbYAxisMin.Margin = new System.Windows.Forms.Padding(4);
            this.tbYAxisMin.Name = "tbYAxisMin";
            this.tbYAxisMin.Size = new System.Drawing.Size(139, 56);
            this.tbYAxisMin.TabIndex = 54;
            this.tbYAxisMin.Scroll += new System.EventHandler(this.tbYAxisMin_Scroll);
            // 
            // tbXAxisMin
            // 
            this.tbXAxisMin.Location = new System.Drawing.Point(92, 451);
            this.tbXAxisMin.Margin = new System.Windows.Forms.Padding(4);
            this.tbXAxisMin.Name = "tbXAxisMin";
            this.tbXAxisMin.Size = new System.Drawing.Size(139, 56);
            this.tbXAxisMin.TabIndex = 53;
            this.tbXAxisMin.Scroll += new System.EventHandler(this.tbXAxisMin_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(724, 451);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "YAxis Max";
            // 
            // tbYAxisMax
            // 
            this.tbYAxisMax.Location = new System.Drawing.Point(813, 451);
            this.tbYAxisMax.Margin = new System.Windows.Forms.Padding(4);
            this.tbYAxisMax.Maximum = 52;
            this.tbYAxisMax.Minimum = 1;
            this.tbYAxisMax.Name = "tbYAxisMax";
            this.tbYAxisMax.Size = new System.Drawing.Size(139, 56);
            this.tbYAxisMax.TabIndex = 51;
            this.tbYAxisMax.Value = 26;
            this.tbYAxisMax.Scroll += new System.EventHandler(this.tbYAxisMax_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 451);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "XAxis Max";
            // 
            // tbXAxisMax
            // 
            this.tbXAxisMax.Location = new System.Drawing.Point(328, 451);
            this.tbXAxisMax.Margin = new System.Windows.Forms.Padding(4);
            this.tbXAxisMax.Maximum = 24;
            this.tbXAxisMax.Name = "tbXAxisMax";
            this.tbXAxisMax.Size = new System.Drawing.Size(139, 56);
            this.tbXAxisMax.TabIndex = 49;
            this.tbXAxisMax.Value = 12;
            this.tbXAxisMax.Scroll += new System.EventHandler(this.tbXAxisMax_Scroll);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 590);
            this.Controls.Add(this.chbShowYRange);
            this.Controls.Add(this.chbShowXRange);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbYRangeMin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbYRangeMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbXRangeMin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbXRangeMax);
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
            this.Controls.Add(this.chbShowDataLabels);
            this.Controls.Add(this.chbShowLegend);
            this.Controls.Add(this.chbShowYCoords);
            this.Controls.Add(this.chbShowXCoords);
            this.Controls.Add(this.chbShowYTicks);
            this.Controls.Add(this.chbShowXTicks);
            this.Controls.Add(this.lineChart);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.tbYRangeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYRangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXRangeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXRangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYAxisMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXAxisMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYAxisMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXAxisMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MindFusion.Charting.WinForms.LineChart lineChart;
        private System.Windows.Forms.CheckBox chbShowLegend;
        private System.Windows.Forms.CheckBox chbShowYCoords;
        private System.Windows.Forms.CheckBox chbShowXCoords;
        private System.Windows.Forms.CheckBox chbShowYTicks;
        private System.Windows.Forms.CheckBox chbShowXTicks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxLineType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxGridType;
        private System.Windows.Forms.CheckBox chbShowDataLabels;
        private System.Windows.Forms.CheckBox chbShowYRange;
        private System.Windows.Forms.CheckBox chbShowXRange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar tbYRangeMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar tbYRangeMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbXRangeMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tbXRangeMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar tbYAxisMin;
        private System.Windows.Forms.TrackBar tbXAxisMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbYAxisMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbXAxisMax;
    }
}