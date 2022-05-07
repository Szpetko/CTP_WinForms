using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using MindFusion.Charting;
using MindFusion.Drawing;

using Color = System.Drawing.Color;
using System.Globalization;

namespace CTP_WinFroms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.Text = "CTP Program";
			// create line brushes
			firstBrush = new SolidBrush(Color.FromArgb(102, 154, 204));
			secondBrush = new SolidBrush(Color.FromArgb(0, 0, 99));
			
		private Form activeForm;

		public MainForm()
			{
				while (!reader.EndOfStream)
				{
					

			InitializeComponent();
			this.Text = "CTP Program";
				}
			}

		private void OpenChildForm(Form childForm, object btnSender)
			{
            if (activeForm != null)
		{
                activeForm.Close();
		}
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

		void chbShowYTicks_CheckedChanged(object sender, EventArgs e)
		{
			lineChart.ShowYTicks = !lineChart.ShowYTicks;
			lineChart.Invalidate();
		}

        private void btnHome_Click(object sender, EventArgs e)
		{
            var temp = new CTP_WinForms.Forms.HomeForm();
            OpenChildForm(temp,sender);
		}

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}