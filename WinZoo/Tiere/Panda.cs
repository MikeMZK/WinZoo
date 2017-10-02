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
        int intEnergiePandaMax = 1500;

        public Panda(PictureBox pbGehege, PictureBox pbPanda) : base(pbGehege, pbPanda)
        {
            panda = Image.FromFile("panda.png");
            base.BildSetzen(panda);
            IntEnergie = intEnergiePandaMax;
        }

        public override string ToString()
        {
            return "Energie: " + IntEnergie.ToString();
        }
    }
}