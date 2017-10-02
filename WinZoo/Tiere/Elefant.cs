using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinZoo
{
    class Elefant : Lebewesen
    {
        private Image elefant;
        int intElefantEnergieMax = 5000;


        public Elefant(PictureBox pbGehege, PictureBox pbElefant) : base(pbGehege, pbElefant)
        {
            elefant = Image.FromFile("elefant.png");
            base.BildSetzen(elefant);
            IntEnergie = intElefantEnergieMax;
        }

        public override string ToString()
        {
            return "Energie: " + IntEnergie.ToString();
        }
    }
}
