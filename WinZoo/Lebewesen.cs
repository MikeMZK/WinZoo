using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinZoo
{
    class Lebewesen
    {
        private PictureBox pbGehege, pbLebewesen;
        private int timerIntverval;
        private Timer lauftimer;
        private Random rnd;
        private Image TierBild;
        private bool spielen;
        public int counter;
        private int letzteLaufRichtung;

        public string StrName { get; private set; }
        public bool HatHunger { get; private set; }
        public int IntEnergie { get; private set; }
        public string StrGeschlecht { get; private set; }
        public int IntGewicht { get; private set; }
        public int IntAlter { get; private set; }
        public int IntGroesse { get; private set; }

        public Lebewesen()
        {

        }
        public Lebewesen(PictureBox pbGehege, PictureBox pbLebewesen)
        {
            this.pbGehege = pbGehege;
            this.pbLebewesen = pbLebewesen;

            lauftimer = new Timer();
            rnd = new Random();

            this.pbLebewesen.Height = 50;
            this.pbLebewesen.Width = 50;
            this.pbLebewesen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pbLebewesen.BackColor = Color.Transparent;

            this.pbLebewesen.Location = (new Point(this.pbGehege.Location.X + rnd.Next(this.pbLebewesen.Height, this.pbGehege.Width - this.pbLebewesen.Width), this.pbGehege.Location.Y + rnd.Next(this.pbLebewesen.Width, this.pbGehege.Height - this.pbLebewesen.Height)));

            timerIntverval = 750;
            lauftimer.Tick += lauftimer_Tick;
            lauftimer.Interval = timerIntverval;
            lauftimer.Enabled = true;

            counter = 0;
            spielen = false;
        }

        protected void BildSetzen(Image TierBild)
        {
            this.TierBild = TierBild;
            this.pbLebewesen.Image = TierBild;
        }

        public void Essen()
        {

        }

        private void lauftimer_Tick(object sender, EventArgs e)
        {
            if (!spielen)
            {
                drehungZurücksetzen();
                Laufen();
            }
            else
            {
                if (counter % 2 == 0)
                {
                    pbLebewesen.Location = new Point(pbLebewesen.Location.X, pbLebewesen.Location.Y - 5);
                }
                else
                {
                    pbLebewesen.Location = new Point(pbLebewesen.Location.X, pbLebewesen.Location.Y + 5);
                }

                if (counter >= 7)
                {
                    lauftimer.Interval = timerIntverval;
                    counter = 0;
                    spielen = false;
                }

                counter++;
            }
        }

        private void drehungZurücksetzen()
        {
            switch (letzteLaufRichtung)
            {
                case 1:
                    TierBild.RotateFlip(RotateFlipType.Rotate180FlipX);
                    break;
                case 2:
                    TierBild.RotateFlip(RotateFlipType.Rotate90FlipX);
                    break;
                case 4:
                    TierBild.RotateFlip(RotateFlipType.Rotate90FlipY);
                    break;
            }

        }
        private void Laufen()
        {
            int Direction = rnd.Next(1, 6);

            switch (Direction)
            {
                case 1: //Norden
                    TierBild.RotateFlip(RotateFlipType.Rotate180FlipX);
                    pbLebewesen.Location = new Point(pbLebewesen.Location.X, pbLebewesen.Location.Y - 5);
                    if (pbLebewesen.Location.Y < pbGehege.Location.Y)
                    {
                        pbLebewesen.Location = new Point(pbLebewesen.Location.X, pbLebewesen.Location.Y + 5);
                    }
                    break;
                case 2: //Osten
                    TierBild.RotateFlip(RotateFlipType.Rotate90FlipX);
                    pbLebewesen.Location = new Point(pbLebewesen.Location.X + 5, pbLebewesen.Location.Y);
                    if (pbLebewesen.Location.X + pbLebewesen.Width > pbGehege.Location.X + pbGehege.Width)
                    {
                        pbLebewesen.Location = new Point(pbLebewesen.Location.X - 5, pbLebewesen.Location.Y);
                    }
                    break;
                case 3: //Süden
                    pbLebewesen.Location = new Point(pbLebewesen.Location.X, pbLebewesen.Location.Y + 5);
                    if (pbLebewesen.Location.Y + pbLebewesen.Height > pbGehege.Location.Y + pbGehege.Height)
                    {
                        pbLebewesen.Location = new Point(pbLebewesen.Location.X, pbLebewesen.Location.Y - 5);
                    }
                    break;
                case 4: //Westen
                    TierBild.RotateFlip(RotateFlipType.Rotate90FlipY);
                    pbLebewesen.Location = new Point(pbLebewesen.Location.X - 5, pbLebewesen.Location.Y);
                    if (pbLebewesen.Location.X < pbGehege.Location.X)
                    {
                        pbLebewesen.Location = new Point(pbLebewesen.Location.X + 5, pbLebewesen.Location.Y);
                    }
                    break;
                case 5: //Stehen bleiben
                    System.Threading.Thread.Sleep(lauftimer.Interval);
                    break;
            }
            letzteLaufRichtung = Direction;
        }
        public void Spielen()
        {
            spielen = true;
            lauftimer.Interval = timerIntverval / 3;
        }

        public override string ToString()
        {
            return $"Ich bin ein Panda!";
        }

    }
}
