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
        Image ClosedExitDoor, OpenedExitDoor, EnterZooShine;

        public frmZoo()
        {
            InitializeComponent();

            ClosedExitDoor = Image.FromFile("ClosedExitDoor.png");
            OpenedExitDoor = Image.FromFile("OpenedExitDoor.png");
            pb_Exit.Image = ClosedExitDoor;

            EnterZooShine = Image.FromFile("EnterZooShine.png");
            pb_Eingang.Image = null;
        }

        private void pb_Eingang_Click(object sender, EventArgs e)
        {

        }
        private void pb_Eingang_MouseEnter(object sender, EventArgs e)
        {
            pb_Eingang.Image = EnterZooShine;
        }
        private void pb_Eingang_MouseLeave(object sender, EventArgs e)
        {
            pb_Eingang.Image = null;
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
