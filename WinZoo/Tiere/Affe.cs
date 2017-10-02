using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinZoo
{
    class Affe : Lebewesen
    {
        private Image affe;
        int intAffeEnergieMax = 2500;

        public Affe(PictureBox pbGehege, PictureBox pbAffe) : base(pbGehege, pbAffe)
        {
            affe = Image.FromFile("affe.png");
            base.BildSetzen(affe);
            IntEnergie = intAffeEnergieMax;
        }

        public override string ToString()
        {
            return "Energie: "+IntEnergie.ToString();
        }
    }
}
