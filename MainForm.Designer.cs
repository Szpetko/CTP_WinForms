namespace CTP_WinFroms
{
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lineChart = new MindFusion.Charting.WinForms.LineChart();
            this.chbShowDataLabels = new System.Windows.Forms.CheckBox();
            this.chbShowLegend = new System.Windows.Forms.CheckBox();
            this.chbShowYCoords = new System.Windows.Forms.CheckBox();
            this.chbShowXCoords = new System.Windows.Forms.CheckBox();
            this.chbShowYTicks = new System.Windows.Forms.CheckBox();
            this.chbShowXTicks = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbYAxisMin = new System.Windows.Forms.TrackBar();
            this.tbXAxisMin = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxGridType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbYAxisMax = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tbXAxisMax = new System.Windows.Forms.TrackBar();
            this.chbScrollGrid = new System.Windows.Forms.CheckBox();
            this.cbxLineType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbXRangeMin = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.tbXRangeMax = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.tbYRangeMin = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.tbYRangeMax = new System.Windows.Forms.TrackBar();
            this.chbShowXRange = new System.Windows.Forms.CheckBox();
            this.chbShowYRange = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbYAxisMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXAxisMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYAxisMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXAxisMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXRangeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXRangeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYRangeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYRangeMax)).BeginInit();
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
            this.lineChart.Size = new System.Drawing.Size(1071, 437);
            this.lineChart.SubtitleFontName = null;
            this.lineChart.SubtitleFontSize = null;
            this.lineChart.SubtitleFontStyle = null;
            this.lineChart.TabIndex = 0;
            this.lineChart.Text = "lineChart1";
            this.lineChart.TitleFontName = null;
            this.lineChart.TitleFontSize = null;
            this.lineChart.TitleFontStyle = null;
            // 
            // chbShowDataLabels
            // 
            this.chbShowDataLabels.AutoSize = true;
            this.chbShowDataLabels.Checked = true;
            this.chbShowDataLabels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowDataLabels.Location = new System.Drawing.Point(171, 517);
            this.chbShowDataLabels.Name = "chbShowDataLabels";
            this.chbShowDataLabels.Size = new System.Drawing.Size(113, 17);
            this.chbShowDataLabels.TabIndex = 24;
            this.chbShowDataLabels.Text = "Show Data Labels";
            this.chbShowDataLabels.UseVisualStyleBackColor = true;
            this.chbShowDataLabels.CheckedChanged += new System.EventHandler(this.chbShowDataLabels_CheckedChanged);
            // 
            // chbShowLegend
            // 
            this.chbShowLegend.AutoSize = true;
            this.chbShowLegend.Checked = true;
            this.chbShowLegend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowLegend.Location = new System.Drawing.Point(12, 551);
            this.chbShowLegend.Name = "chbShowLegend";
            this.chbShowLegend.Size = new System.Drawing.Size(92, 17);
            this.chbShowLegend.TabIndex = 23;
            this.chbShowLegend.Text = "Show Legend";
            this.chbShowLegend.UseVisualStyleBackColor = true;
            this.chbShowLegend.CheckedChanged += new System.EventHandler(this.chbShowLegend_CheckedChanged);
            // 
            // chbShowYCoords
            // 
            this.chbShowYCoords.AutoSize = true;
            this.chbShowYCoords.Checked = true;
            this.chbShowYCoords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowYCoords.Location = new System.Drawing.Point(12, 527);
            this.chbShowYCoords.Name = "chbShowYCoords";
            this.chbShowYCoords.Size = new System.Drawing.Size(122, 17);
            this.chbShowYCoords.TabIndex = 22;
            this.chbShowYCoords.Text = "Show Y Coordinates";
            this.chbShowYCoords.UseVisualStyleBackColor = true;
            this.chbShowYCoords.CheckedChanged += new System.EventHandler(this.chbShowYCoords_CheckedChanged);
            // 
            // chbShowXCoords
            // 
            this.chbShowXCoords.AutoSize = true;
            this.chbShowXCoords.Checked = true;
            this.chbShowXCoords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowXCoords.Location = new System.Drawing.Point(12, 503);
            this.chbShowXCoords.Name = "chbShowXCoords";
            this.chbShowXCoords.Size = new System.Drawing.Size(122, 17);
            this.chbShowXCoords.TabIndex = 21;
            this.chbShowXCoords.Text = "Show X Coordinates";
            this.chbShowXCoords.UseVisualStyleBackColor = true;
            this.chbShowXCoords.CheckedChanged += new System.EventHandler(this.chbShowXCoords_CheckedChanged);
            // 
            // chbShowYTicks
            // 
            this.chbShowYTicks.AutoSize = true;
            this.chbShowYTicks.Checked = true;
            this.chbShowYTicks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowYTicks.Location = new System.Drawing.Point(12, 479);
            this.chbShowYTicks.Name = "chbShowYTicks";
            this.chbShowYTicks.Size = new System.Drawing.Size(92, 17);
            this.chbShowYTicks.TabIndex = 20;
            this.chbShowYTicks.Text = "Show Y Ticks";
            this.chbShowYTicks.UseVisualStyleBackColor = true;
            this.chbShowYTicks.CheckedChanged += new System.EventHandler(this.chbShowYTicks_CheckedChanged);
            // 
            // chbShowXTicks
            // 
            this.chbShowXTicks.AutoSize = true;
            this.chbShowXTicks.Checked = true;
            this.chbShowXTicks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowXTicks.Location = new System.Drawing.Point(12, 455);
            this.chbShowXTicks.Name = "chbShowXTicks";
            this.chbShowXTicks.Size = new System.Drawing.Size(92, 17);
            this.chbShowXTicks.TabIndex = 19;
            this.chbShowXTicks.Text = "Show X Ticks";
            this.chbShowXTicks.UseVisualStyleBackColor = true;
            this.chbShowXTicks.CheckedChanged += new System.EventHandler(this.chbShowXTicks_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(747, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "YAxis Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "XAxis Min";
            // 
            // tbYAxisMin
            // 
            this.tbYAxisMin.Location = new System.Drawing.Point(804, 449);
            this.tbYAxisMin.Name = "tbYAxisMin";
            this.tbYAxisMin.Size = new System.Drawing.Size(104, 45);
            this.tbYAxisMin.TabIndex = 32;
            this.tbYAxisMin.Scroll += new System.EventHandler(this.tbYAxisMin_Scroll);
            // 
            // tbXAxisMin
            // 
            this.tbXAxisMin.Location = new System.Drawing.Point(444, 449);
            this.tbXAxisMin.Name = "tbXAxisMin";
            this.tbXAxisMin.Size = new System.Drawing.Size(104, 45);
            this.tbXAxisMin.TabIndex = 31;
            this.tbXAxisMin.Scroll += new System.EventHandler(this.tbXAxisMin_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Grid Type:";
            // 
            // cbxGridType
            // 
            this.cbxGridType.FormattingEnabled = true;
            this.cbxGridType.Location = new System.Drawing.Point(235, 475);
            this.cbxGridType.Name = "cbxGridType";
            this.cbxGridType.Size = new System.Drawing.Size(121, 21);
            this.cbxGridType.TabIndex = 29;
            this.cbxGridType.SelectedValueChanged += new System.EventHandler(this.cbxGridType_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(918, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "YAxis Max";
            // 
            // tbYAxisMax
            // 
            this.tbYAxisMax.Location = new System.Drawing.Point(985, 449);
            this.tbYAxisMax.Maximum = 52;
            this.tbYAxisMax.Minimum = 1;
            this.tbYAxisMax.Name = "tbYAxisMax";
            this.tbYAxisMax.Size = new System.Drawing.Size(104, 45);
            this.tbYAxisMax.TabIndex = 27;
            this.tbYAxisMax.Value = 26;
            this.tbYAxisMax.Scroll += new System.EventHandler(this.tbYAxisMax_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "XAxis Max";
            // 
            // tbXAxisMax
            // 
            this.tbXAxisMax.Location = new System.Drawing.Point(621, 449);
            this.tbXAxisMax.Maximum = 24;
            this.tbXAxisMax.Name = "tbXAxisMax";
            this.tbXAxisMax.Size = new System.Drawing.Size(104, 45);
            this.tbXAxisMax.TabIndex = 25;
            this.tbXAxisMax.Value = 12;
            this.tbXAxisMax.Scroll += new System.EventHandler(this.tbXAxisMax_Scroll);
            // 
            // chbScrollGrid
            // 
            this.chbScrollGrid.AutoSize = true;
            this.chbScrollGrid.Location = new System.Drawing.Point(12, 575);
            this.chbScrollGrid.Name = "chbScrollGrid";
            this.chbScrollGrid.Size = new System.Drawing.Size(74, 17);
            this.chbScrollGrid.TabIndex = 35;
            this.chbScrollGrid.Text = "Scroll Grid";
            this.chbScrollGrid.UseVisualStyleBackColor = true;
            this.chbScrollGrid.CheckedChanged += new System.EventHandler(this.chbScrollGrid_CheckedChanged);
            // 
            // cbxLineType
            // 
            this.cbxLineType.FormattingEnabled = true;
            this.cbxLineType.Location = new System.Drawing.Point(235, 451);
            this.cbxLineType.Name = "cbxLineType";
            this.cbxLineType.Size = new System.Drawing.Size(121, 21);
            this.cbxLineType.TabIndex = 36;
            this.cbxLineType.SelectedValueChanged += new System.EventHandler(this.cbxLineType_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Line Type:";
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.White;
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescription.Location = new System.Drawing.Point(383, 568);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(691, 31);
            this.tbDescription.TabIndex = 38;
            this.tbDescription.Text = "This sample demonstrates various properties of the LineChart control. Change prop" +
    "erty values in this panel to see their effect in chart above.";
            this.tbDescription.TextChanged += new System.EventHandler(this.tbDescription_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "X Range Min";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbXRangeMin
            // 
            this.tbXRangeMin.Location = new System.Drawing.Point(444, 517);
            this.tbXRangeMin.Maximum = 100;
            this.tbXRangeMin.Minimum = -100;
            this.tbXRangeMin.Name = "tbXRangeMin";
            this.tbXRangeMin.Size = new System.Drawing.Size(104, 45);
            this.tbXRangeMin.TabIndex = 41;
            this.tbXRangeMin.Value = -50;
            this.tbXRangeMin.Scroll += new System.EventHandler(this.tbXRangeMin_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(554, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "X Range Max";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tbXRangeMax
            // 
            this.tbXRangeMax.Location = new System.Drawing.Point(621, 517);
            this.tbXRangeMax.Maximum = 100;
            this.tbXRangeMax.Minimum = -100;
            this.tbXRangeMax.Name = "tbXRangeMax";
            this.tbXRangeMax.Size = new System.Drawing.Size(104, 45);
            this.tbXRangeMax.TabIndex = 39;
            this.tbXRangeMax.Value = 50;
            this.tbXRangeMax.Scroll += new System.EventHandler(this.tbXRangeMax_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(747, 517);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Y Range Min";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tbYRangeMin
            // 
            this.tbYRangeMin.Location = new System.Drawing.Point(808, 517);
            this.tbYRangeMin.Maximum = 100;
            this.tbYRangeMin.Minimum = -100;
            this.tbYRangeMin.Name = "tbYRangeMin";
            this.tbYRangeMin.Size = new System.Drawing.Size(104, 45);
            this.tbYRangeMin.TabIndex = 45;
            this.tbYRangeMin.Value = -50;
            this.tbYRangeMin.Scroll += new System.EventHandler(this.tbYRangeMin_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(918, 517);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Y Range Max";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // tbYRangeMax
            // 
            this.tbYRangeMax.Location = new System.Drawing.Point(985, 517);
            this.tbYRangeMax.Maximum = 100;
            this.tbYRangeMax.Minimum = -100;
            this.tbYRangeMax.Name = "tbYRangeMax";
            this.tbYRangeMax.Size = new System.Drawing.Size(104, 45);
            this.tbYRangeMax.TabIndex = 43;
            this.tbYRangeMax.Value = 50;
            this.tbYRangeMax.Scroll += new System.EventHandler(this.tbYRangeMax_Scroll);
            // 
            // chbShowXRange
            // 
            this.chbShowXRange.AutoSize = true;
            this.chbShowXRange.Checked = true;
            this.chbShowXRange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowXRange.Location = new System.Drawing.Point(383, 486);
            this.chbShowXRange.Name = "chbShowXRange";
            this.chbShowXRange.Size = new System.Drawing.Size(140, 17);
            this.chbShowXRange.TabIndex = 47;
            this.chbShowXRange.Text = "Show X Range Selector";
            this.chbShowXRange.UseVisualStyleBackColor = true;
            this.chbShowXRange.CheckedChanged += new System.EventHandler(this.chbShowXRange_CheckedChanged);
            // 
            // chbShowYRange
            // 
            this.chbShowYRange.AutoSize = true;
            this.chbShowYRange.Checked = true;
            this.chbShowYRange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowYRange.Location = new System.Drawing.Point(747, 486);
            this.chbShowYRange.Name = "chbShowYRange";
            this.chbShowYRange.Size = new System.Drawing.Size(140, 17);
            this.chbShowYRange.TabIndex = 48;
            this.chbShowYRange.Text = "Show Y Range Selector";
            this.chbShowYRange.UseVisualStyleBackColor = true;
            this.chbShowYRange.CheckedChanged += new System.EventHandler(this.chbShowYRange_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 616);
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
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxLineType);
            this.Controls.Add(this.chbScrollGrid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbYAxisMin);
            this.Controls.Add(this.tbXAxisMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxGridType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbYAxisMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbXAxisMax);
            this.Controls.Add(this.chbShowDataLabels);
            this.Controls.Add(this.chbShowLegend);
            this.Controls.Add(this.chbShowYCoords);
            this.Controls.Add(this.chbShowXCoords);
            this.Controls.Add(this.chbShowYTicks);
            this.Controls.Add(this.chbShowXTicks);
            this.Controls.Add(this.lineChart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbYAxisMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXAxisMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYAxisMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXAxisMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXRangeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbXRangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYRangeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYRangeMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private MindFusion.Charting.WinForms.LineChart lineChart;
		private System.Windows.Forms.CheckBox chbShowDataLabels;
		private System.Windows.Forms.CheckBox chbShowLegend;
		private System.Windows.Forms.CheckBox chbShowYCoords;
		private System.Windows.Forms.CheckBox chbShowXCoords;
		private System.Windows.Forms.CheckBox chbShowYTicks;
		private System.Windows.Forms.CheckBox chbShowXTicks;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TrackBar tbYAxisMin;
		private System.Windows.Forms.TrackBar tbXAxisMin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbxGridType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar tbYAxisMax;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TrackBar tbXAxisMax;
		private System.Windows.Forms.CheckBox chbScrollGrid;
		private System.Windows.Forms.ComboBox cbxLineType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbDescription;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TrackBar tbXRangeMin;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TrackBar tbXRangeMax;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TrackBar tbYRangeMin;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TrackBar tbYRangeMax;
		private System.Windows.Forms.CheckBox chbShowXRange;
		private System.Windows.Forms.CheckBox chbShowYRange;
	}
}

