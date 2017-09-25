using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinZoo
{
    public partial class frmZoo : Form
    {
        Image ClosedExitDoor, OpenedExitDoor, EnterZooShine, BackgroundZoo, Affe, Elefant, Panda, Gras, Pfeil;

        public frmZoo()
        {
            InitializeComponent();

            ClosedExitDoor = Image.FromFile("ClosedExitDoor.png");
            OpenedExitDoor = Image.FromFile("OpenedExitDoor.png");
            pb_Exit.Image = ClosedExitDoor;
            BackgroundZoo = Image.FromFile("BackgroundZoo.jpg");
            EnterZooShine = Image.FromFile("EnterZooShine.png");
            Affe = Image.FromFile("Affe.png");
            Elefant = Image.FromFile("Elefant.png");
            Panda = Image.FromFile("Panda.png");
            Gras = Image.FromFile("Gras.jpg");
            Pfeil = Image.FromFile("Pfeil.png");
            pb_Eingang.Image = null;

            pb_Affen.Enabled = false;
            pb_Panda.Enabled = false;
            pb_Elefanten.Enabled = false;
            pb_Pfeil.Enabled = false;
            pb_Pfeil.Visible = false;
            pb_Eingang.BringToFront();
        }

        private void pb_Eingang_Click(object sender, EventArgs e)
        {
            ActiveForm.BackgroundImage = BackgroundZoo;
            pb_Eingang.Enabled = false;
            pb_Affen.Enabled =true;
            pb_Panda.Enabled = true;
            pb_Elefanten.Enabled =true;
            pb_Panda.BringToFront();
        }
        private void pb_Eingang_MouseEnter(object sender, EventArgs e)
        {
            pb_Eingang.Image = EnterZooShine;
        }
        private void pb_Eingang_MouseLeave(object sender, EventArgs e)
        {
            pb_Eingang.Image = null;
        }

        private void pb_Elefanten_Click(object sender, EventArgs e)
        {
            ActiveForm.BackgroundImage = Gras;
            pb_Affen.Enabled = false;
            pb_Panda.Enabled = false;
            pb_Elefanten.Enabled = false;
            pb_Pfeil.Enabled = true;
            pb_Pfeil.Visible = true;
        }

        private void pb_Elefanten_MouseEnter(object sender, EventArgs e)
        {
            pb_Elefanten.Image = Elefant;
        }

        private void pb_Elefanten_MouseLeave(object sender, EventArgs e)
        {
            pb_Elefanten.Image = null;
        }

        private void pb_Panda_Click(object sender, EventArgs e)
        {
            ActiveForm.BackgroundImage = Gras;
            pb_Affen.Enabled = false;
            pb_Panda.Enabled = false;
            pb_Elefanten.Enabled = false;
            pb_Pfeil.Enabled = true;
            pb_Pfeil.Visible = true;

        }

        private void pb_Pfeil_Click(object sender, EventArgs e)
        {
            ActiveForm.BackgroundImage = BackgroundZoo;
            pb_Affen.Enabled = true;
            pb_Panda.Enabled = true;
            pb_Elefanten.Enabled = true;
            pb_Pfeil.Visible = false;
            pb_Pfeil.Enabled = false;
        }

        private void pb_Panda_MouseEnter(object sender, EventArgs e)
        {
            pb_Panda.Image = Panda;
        }

        private void pb_Panda_MouseLeave(object sender, EventArgs e)
        {
            pb_Panda.Image = null;
        }

        private void pb_Affen_Click(object sender, EventArgs e)
        {
            ActiveForm.BackgroundImage = Gras;
            pb_Affen.Enabled = false;
            pb_Panda.Enabled = false;
            pb_Elefanten.Enabled = false;
            pb_Pfeil.Enabled = true;
            pb_Pfeil.Visible = true;
        }

        private void pb_Affen_MouseEnter(object sender, EventArgs e)
        {
            pb_Affen.Image = Affe;
        }

        private void pb_Affen_MouseLeave(object sender, EventArgs e)
        {
            pb_Affen.Image = null;
        }

        private void pb_Exit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Wollen Sie die Anwendung wirklich beenden?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void pb_Exit_MouseEnter(object sender, EventArgs e)
        {
            pb_Exit.Image = OpenedExitDoor;
        }
        private void pb_Exit_MouseLeave(object sender, EventArgs e)
        {
            pb_Exit.Image = ClosedExitDoor;
        }


    }
}
