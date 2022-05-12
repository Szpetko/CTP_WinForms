
namespace CTP_WinForms.Forms
{
    partial class SettingsForm
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
            this.tb_FilePath = new System.Windows.Forms.TextBox();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_FilePath
            // 
            this.tb_FilePath.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_FilePath.Location = new System.Drawing.Point(55, 40);
            this.tb_FilePath.Name = "tb_FilePath";
            this.tb_FilePath.Size = new System.Drawing.Size(562, 29);
            this.tb_FilePath.TabIndex = 0;
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_OpenFile.ForeColor = System.Drawing.Color.White;
            this.btn_OpenFile.Location = new System.Drawing.Point(623, 40);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(110, 31);
            this.btn_OpenFile.TabIndex = 1;
            this.btn_OpenFile.Text = "OpenFile";
            this.btn_OpenFile.UseVisualStyleBackColor = false;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 593);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.tb_FilePath);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_FilePath;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Button button1;
    }
}