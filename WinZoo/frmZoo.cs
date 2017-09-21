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
        Image ClosedExitDoor, OpenedExitDoor;

        public frmZoo()
        {
            InitializeComponent();

            ClosedExitDoor = Image.FromFile("ClosedExitDoor.png");
            OpenedExitDoor = Image.FromFile("OpenedExitDoor.png");
            pb_Exit.Image = ClosedExitDoor;
        }

        private void pb_Eingang_Click(object sender, EventArgs e)
        {

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
