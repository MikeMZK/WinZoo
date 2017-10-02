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
            this.pb_Affen = new System.Windows.Forms.PictureBox();
            this.pb_Elefanten = new System.Windows.Forms.PictureBox();
            this.pb_Panda = new System.Windows.Forms.PictureBox();
            this.pb_Pfeil = new System.Windows.Forms.PictureBox();
            this.pb_Gehege = new System.Windows.Forms.PictureBox();
            this.btnFüttern = new System.Windows.Forms.Button();
            this.btnSpielen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Eingang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Affen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Elefanten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Panda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pfeil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Gehege)).BeginInit();
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
            // pb_Affen
            // 
            this.pb_Affen.BackColor = System.Drawing.Color.Transparent;
            this.pb_Affen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Affen.Location = new System.Drawing.Point(62, 86);
            this.pb_Affen.Name = "pb_Affen";
            this.pb_Affen.Size = new System.Drawing.Size(94, 70);
            this.pb_Affen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Affen.TabIndex = 2;
            this.pb_Affen.TabStop = false;
            this.pb_Affen.Click += new System.EventHandler(this.pb_Affen_Click);
            this.pb_Affen.MouseEnter += new System.EventHandler(this.pb_Affen_MouseEnter);
            this.pb_Affen.MouseLeave += new System.EventHandler(this.pb_Affen_MouseLeave);
            // 
            // pb_Elefanten
            // 
            this.pb_Elefanten.BackColor = System.Drawing.Color.Transparent;
            this.pb_Elefanten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Elefanten.Location = new System.Drawing.Point(249, 24);
            this.pb_Elefanten.Name = "pb_Elefanten";
            this.pb_Elefanten.Size = new System.Drawing.Size(140, 69);
            this.pb_Elefanten.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Elefanten.TabIndex = 3;
            this.pb_Elefanten.TabStop = false;
            this.pb_Elefanten.Click += new System.EventHandler(this.pb_Elefanten_Click);
            this.pb_Elefanten.MouseEnter += new System.EventHandler(this.pb_Elefanten_MouseEnter);
            this.pb_Elefanten.MouseLeave += new System.EventHandler(this.pb_Elefanten_MouseLeave);
            // 
            // pb_Panda
            // 
            this.pb_Panda.BackColor = System.Drawing.Color.Transparent;
            this.pb_Panda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Panda.Location = new System.Drawing.Point(186, 238);
            this.pb_Panda.Name = "pb_Panda";
            this.pb_Panda.Size = new System.Drawing.Size(112, 74);
            this.pb_Panda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Panda.TabIndex = 4;
            this.pb_Panda.TabStop = false;
            this.pb_Panda.Click += new System.EventHandler(this.pb_Panda_Click);
            this.pb_Panda.MouseEnter += new System.EventHandler(this.pb_Panda_MouseEnter);
            this.pb_Panda.MouseLeave += new System.EventHandler(this.pb_Panda_MouseLeave);
            // 
            // pb_Pfeil
            // 
            this.pb_Pfeil.BackColor = System.Drawing.Color.Transparent;
            this.pb_Pfeil.BackgroundImage = global::WinZoo.Properties.Resources.Pfeil;
            this.pb_Pfeil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Pfeil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Pfeil.Location = new System.Drawing.Point(0, 0);
            this.pb_Pfeil.Name = "pb_Pfeil";
            this.pb_Pfeil.Size = new System.Drawing.Size(58, 39);
            this.pb_Pfeil.TabIndex = 5;
            this.pb_Pfeil.TabStop = false;
            this.pb_Pfeil.Click += new System.EventHandler(this.pb_Pfeil_Click);
            // 
            // pb_Gehege
            // 
            this.pb_Gehege.BackColor = System.Drawing.Color.Transparent;
            this.pb_Gehege.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pb_Gehege.Enabled = false;
            this.pb_Gehege.Location = new System.Drawing.Point(0, 0);
            this.pb_Gehege.Name = "pb_Gehege";
            this.pb_Gehege.Size = new System.Drawing.Size(503, 312);
            this.pb_Gehege.TabIndex = 6;
            this.pb_Gehege.TabStop = false;
            this.pb_Gehege.Visible = false;
            // 
            // btnFüttern
            // 
            this.btnFüttern.Location = new System.Drawing.Point(93, 272);
            this.btnFüttern.Name = "btnFüttern";
            this.btnFüttern.Size = new System.Drawing.Size(75, 23);
            this.btnFüttern.TabIndex = 7;
            this.btnFüttern.Text = "Füttern";
            this.btnFüttern.UseVisualStyleBackColor = true;
            this.btnFüttern.Click += new System.EventHandler(this.btnFüttern_Click);
            // 
            // btnSpielen
            // 
            this.btnSpielen.Location = new System.Drawing.Point(12, 272);
            this.btnSpielen.Name = "btnSpielen";
            this.btnSpielen.Size = new System.Drawing.Size(75, 23);
            this.btnSpielen.TabIndex = 8;
            this.btnSpielen.Text = "Spielen";
            this.btnSpielen.UseVisualStyleBackColor = true;
            this.btnSpielen.Click += new System.EventHandler(this.btnSpielen_Click);
            // 
            // frmZoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WinZoo.Properties.Resources.Unbenannt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 307);
            this.Controls.Add(this.btnSpielen);
            this.Controls.Add(this.btnFüttern);
            this.Controls.Add(this.pb_Gehege);
            this.Controls.Add(this.pb_Pfeil);
            this.Controls.Add(this.pb_Panda);
            this.Controls.Add(this.pb_Elefanten);
            this.Controls.Add(this.pb_Affen);
            this.Controls.Add(this.pb_Exit);
            this.Controls.Add(this.pb_Eingang);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "frmZoo";
            this.Text = "Zoo";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Eingang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Affen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Elefanten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Panda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pfeil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Gehege)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Eingang;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.PictureBox pb_Affen;
        private System.Windows.Forms.PictureBox pb_Elefanten;
        private System.Windows.Forms.PictureBox pb_Panda;
        private System.Windows.Forms.PictureBox pb_Pfeil;
        private System.Windows.Forms.PictureBox pb_Gehege;
        private System.Windows.Forms.Button btnFüttern;
        private System.Windows.Forms.Button btnSpielen;
    }
}

