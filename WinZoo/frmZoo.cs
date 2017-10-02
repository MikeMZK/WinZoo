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
        List<PictureBox> Tiere;
        List<Panda> Pandas;
        List<Affe> Affen;
        List<Elefant> Elefanten;

        public frmZoo()
        {
            InitializeComponent();

            Tiere = new List<PictureBox>();
            Pandas = new List<Panda>();
            Affen = new List<Affe>();
            Elefanten = new List<Elefant>();

            ClosedExitDoor = Image.FromFile("ClosedExitDoor.png");
            OpenedExitDoor = Image.FromFile("OpenedExitDoor.png");
            pb_Exit.Image = ClosedExitDoor;
            pb_Exit.BringToFront();
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
            pb_Affen.Enabled = true;
            pb_Panda.Enabled = true;
            pb_Elefanten.Enabled = true;
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

            AddTiere(3, 3);
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
            pb_Gehege.Enabled = true;
            pb_Gehege.Visible = true;

            AddTiere(5, 1);
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

            AddTiere(8, 2);
        }
        private void pb_Affen_MouseEnter(object sender, EventArgs e)
        {
            pb_Affen.Image = Affe;
        }
        private void pb_Affen_MouseLeave(object sender, EventArgs e)
        {
            pb_Affen.Image = null;
        }

        private void pb_Pfeil_Click(object sender, EventArgs e)
        {
            ActiveForm.BackgroundImage = BackgroundZoo;
            pb_Affen.Enabled = true;
            pb_Panda.Enabled = true;
            pb_Elefanten.Enabled = true;
            pb_Pfeil.Visible = false;
            pb_Pfeil.Enabled = false;
            pb_Gehege.Visible = false;
            pb_Gehege.Enabled = false;

            Affen.Clear();
            Elefanten.Clear();
            Pandas.Clear();

            foreach (PictureBox Tier in Tiere)
            {
                this.Controls.Remove(Tier);
            }
            Tiere.Clear();
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

        private void AddTiere(int Anzahl, int Art) //1 = panda ; 2 = affe ; 3 = elefant
        {
            for (int x = 0; x < Anzahl; x++)
            {
                Tiere.Add(new PictureBox());
                this.Controls.Add(Tiere.Last());
                Tiere.Last().Cursor = Cursors.Hand;
                Tiere.Last().BringToFront();
                Tiere.Last().Click += FrmZoo_Click;

                switch (Art)
                {
                    case 1:
                        Pandas.Add(new Panda(pb_Gehege, Tiere.Last()));
                        Tiere.Last().Tag = Pandas.Last();
                        break;
                    case 2:
                        Affen.Add(new Affe(pb_Gehege, Tiere.Last()));
                        Tiere.Last().Tag = Affen.Last();
                        break;
                    case 3:
                        Elefanten.Add(new Elefant(pb_Gehege, Tiere.Last()));
                        Tiere.Last().Tag = Elefanten.Last();
                        break;
                }
            }
        }

        private void FrmZoo_Click(object sender, EventArgs e)
        {
            foreach (PictureBox tier in Tiere)
            {
                if ((PictureBox)sender == tier)
                {
                    MessageBox.Show(tier.Tag.ToString());
                }
            }
        }
    }
}