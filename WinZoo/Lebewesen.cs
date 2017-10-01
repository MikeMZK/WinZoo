using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinZoo
{
    class Lebewesen
    {
        private PictureBox pbGehege, pbLebewesen;

        public string StrName { get; private set; }
        public bool HatHunger { get; private set; }
        public int IntEnergie { get; private set; }
        public string StrGeschlecht { get; private set; }
        public int IntGewicht { get; private set; }
        public int IntAlter { get; private set; }
        public int IntGroesse { get; private set; }
        public bool HatDurst { get; private set; }

        public Lebewesen(PictureBox pbGehege, PictureBox pbLebewesen)
        {

        }

        public void Essen()
        {

        }

        public void Trinken()
        {

        }

    }
}
