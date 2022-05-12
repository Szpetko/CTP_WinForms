using System;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace CTP_WinFroms
{
    public partial class MainForm : Form
    {
        private Form activeForm;
        private Button currentButton;

        //Main Form
        public MainForm()
        {
            InitializeComponent();

            // setting up the app name
            this.Text = "CTP Program";

            // setting up empty title
            Lbl_Title.Text = "";
        }

        //Methods
        // opening form method
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
            Lbl_Title.Text = childForm.Text;
        }

        // activating and changing color of a button method
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

        // disabling and changing color to default of a button method
        private void DisableButton()
        {
            foreach (Control previousButton in panelMenu.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.Gray;
                }
            }
        }

        //Buttons
        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                // opening home form
                var temp = new CTP_WinForms.Forms.HomeForm();
                OpenChildForm(temp, sender);
            }
            catch (Exception ex)
            {
                // changing form to setting and displaying a message in case of fail
                MessageBox.Show(ex.Message + "\n" + "Proszę ustawić poprawną ściężkę do pliku.");
                var temp = new CTP_WinForms.Forms.SettingsForm();
                OpenChildForm(temp, btnSettings);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                // opening print form
                var temp = new CTP_WinForms.Forms.PrintForm();
                OpenChildForm(temp, sender);
            }
            catch (Exception ex)
            {
                // changing form to setting and displaying a message in case of fail
                MessageBox.Show(ex.Message + "\n" + "Proszę ustawić poprawną ściężkę do pliku.");
                var temp = new CTP_WinForms.Forms.SettingsForm();
                OpenChildForm(temp, btnSettings);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // opening settings form
            var temp = new CTP_WinForms.Forms.SettingsForm();
            OpenChildForm(temp, sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // exiting the app
            Application.Exit();
        }

        private void Lbl_Title_Click(object sender, EventArgs e)
        {

        }
    }
}