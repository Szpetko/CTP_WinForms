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


        private Form activeForm;
        private Button currentButton;
        public MainForm()
        {
            InitializeComponent();
            this.Text = "CTP Program";
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.DodgerBlue;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousButton in panelMenu.Controls)
            {
                if(previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.Gray;
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var temp = new CTP_WinForms.Forms.HomeForm();
            OpenChildForm(temp, sender);
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_Title_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}