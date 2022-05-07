﻿namespace CTP_WinFroms
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
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.btnSettings);
            this.panelDesktop.Controls.Add(this.btnHome);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1074, 563);
            this.panelDesktop.TabIndex = 0;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(31, 118);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "button1";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(31, 179);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "button2";
            this.btnSettings.UseVisualStyleBackColor = true;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 563);
            this.Controls.Add(this.panelDesktop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnHome;
	}
}

