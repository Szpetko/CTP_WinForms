using System;
using System.IO;
using System.Windows.Forms;

namespace CTP_WinForms.Forms
{
    public partial class SettingsForm : Form
    {
        //Main Form
        public SettingsForm()
        {
            InitializeComponent();

            // creating file if not exsist
            if (!File.Exists("path.txt"))
            {
                using (StreamWriter sw = File.AppendText("path.txt"))
                {
                }
            }

            // reading path from a file
            using (StreamReader sr = new StreamReader("path.txt"))
            {
                tb_FilePath.Text = sr.ReadLine();
            }
        }

        //Buttons
        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            // opening windows path finder/opener
            OpenFileDialog ofd = new OpenFileDialog();

            // filtering files
            ofd.Filter = "Csv Files (*.csv)|*.csv|Excel Files (*.xlsx)|*.xlsx;*xls|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // dispaly path
                tb_FilePath.Text = ofd.FileName;

                // writing path to a file
                using (StreamWriter sw = new StreamWriter("path.txt"))
                {
                    sw.WriteLine(ofd.FileName);
                }
            }
        }
    }
}