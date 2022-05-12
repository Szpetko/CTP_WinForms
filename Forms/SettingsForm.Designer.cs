
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
            this.SuspendLayout();
            // 
            // tb_FilePath
            // 
            this.tb_FilePath.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_FilePath.Location = new System.Drawing.Point(41, 32);
            this.tb_FilePath.Margin = new System.Windows.Forms.Padding(2);
            this.tb_FilePath.Name = "tb_FilePath";
            this.tb_FilePath.Size = new System.Drawing.Size(422, 25);
            this.tb_FilePath.TabIndex = 0;
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_OpenFile.ForeColor = System.Drawing.Color.White;
            this.btn_OpenFile.Location = new System.Drawing.Point(467, 32);
            this.btn_OpenFile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(82, 25);
            this.btn_OpenFile.TabIndex = 1;
            this.btn_OpenFile.Text = "OpenFile";
            this.btn_OpenFile.UseVisualStyleBackColor = false;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 414);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.tb_FilePath);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsForm";
            this.Text = "SETTINGS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_FilePath;
        private System.Windows.Forms.Button btn_OpenFile;
    }
}