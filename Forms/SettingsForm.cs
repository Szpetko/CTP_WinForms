using System;
using System.Windows.Forms;
using System.IO;
using CTP_WinForms;
using MindFusion.Charting;
namespace CTP_WinForms.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            using (StreamReader sw = new StreamReader("path.txt"))
            {
                tb_FilePath.Text = sw.ReadLine();
            }
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "csv fies (*.csv)|*.csv|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tb_FilePath.Text = ofd.FileName;
                using (StreamWriter sw = new StreamWriter("path.txt"))
                {
                    sw.WriteLine(ofd.FileName);
                }
            }
            //homefrm.Show();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}