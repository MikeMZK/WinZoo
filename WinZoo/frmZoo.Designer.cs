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
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.pb_Eingang = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Eingang)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Exit
            // 
            this.pb_Exit.BackColor = System.Drawing.Color.Transparent;
            this.pb_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Exit.Image = global::WinZoo.Properties.Resources.Door_Closed_40px;
            this.pb_Exit.Location = new System.Drawing.Point(456, 258);
            this.pb_Exit.Name = "pb_Exit";
            this.pb_Exit.Size = new System.Drawing.Size(47, 54);
            this.pb_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Exit.TabIndex = 1;
            this.pb_Exit.TabStop = false;
            this.pb_Exit.Click += new System.EventHandler(this.pb_Exit_Click);
            this.pb_Exit.MouseEnter += new System.EventHandler(this.pb_Exit_MouseEnter);
            this.pb_Exit.MouseLeave += new System.EventHandler(this.pb_Exit_MouseLeave);
            // 
            // pb_Eingang
            // 
            this.pb_Eingang.BackColor = System.Drawing.Color.Transparent;
            this.pb_Eingang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Eingang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Eingang.Location = new System.Drawing.Point(146, 76);
            this.pb_Eingang.Name = "pb_Eingang";
            this.pb_Eingang.Size = new System.Drawing.Size(215, 200);
            this.pb_Eingang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Eingang.TabIndex = 0;
            this.pb_Eingang.TabStop = false;
            this.pb_Eingang.Click += new System.EventHandler(this.pb_Eingang_Click);
            this.pb_Eingang.MouseEnter += new System.EventHandler(this.pb_Eingang_MouseEnter);
            this.pb_Eingang.MouseLeave += new System.EventHandler(this.pb_Eingang_MouseLeave);
            // 
            // frmZoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WinZoo.Properties.Resources.Unbenannt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 307);
            this.Controls.Add(this.pb_Exit);
            this.Controls.Add(this.pb_Eingang);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "frmZoo";
            this.Text = "Zoo";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Eingang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Eingang;
        private System.Windows.Forms.PictureBox pb_Exit;
    }
}

