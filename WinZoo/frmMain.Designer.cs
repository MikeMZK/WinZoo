namespace WinZoo
{
    partial class frmZoo
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_Eingang = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Eingang)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Eingang
            // 
            this.pb_Eingang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Eingang.Location = new System.Drawing.Point(0, 0);
            this.pb_Eingang.Name = "pb_Eingang";
            this.pb_Eingang.Size = new System.Drawing.Size(435, 218);
            this.pb_Eingang.TabIndex = 0;
            this.pb_Eingang.TabStop = false;
            // 
            // frmZoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 218);
            this.Controls.Add(this.pb_Eingang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmZoo";
            this.Text = "Zoo";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Eingang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Eingang;
    }
}

