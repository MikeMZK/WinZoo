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

        public Elefant(PictureBox pbGehege, PictureBox pbElefant) : base(pbGehege, pbElefant)
        {
            elefant = Image.FromFile("elefant.png");
            base.BildSetzen(elefant);
        }

        public override string ToString()
        {
            return "Ich bin ein Elefant!";
        }
    }
}
