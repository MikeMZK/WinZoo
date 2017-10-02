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

        public Affe(PictureBox pbGehege, PictureBox pbAffe) : base(pbGehege, pbAffe)
        {
            affe = Image.FromFile("affe.png");
            base.BildSetzen(affe);
        }

        public override string ToString()
        {
            return "Ich bin ein Affe!";
        }
    }
}
