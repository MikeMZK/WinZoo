using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinZoo
{
    class Panda : Lebewesen
    {
        private Image panda;

        public Panda(PictureBox pbGehege, PictureBox pbPanda) : base(pbGehege, pbPanda)
        {
            panda = Image.FromFile("panda.png");
            base.BildSetzen(panda);
        }

        public override string ToString()
        {
            return "Ich bin ein Panda!";
        }
    }
}