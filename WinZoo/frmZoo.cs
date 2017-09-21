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
        public frmZoo()
        {
            InitializeComponent();
        }

        private void pb_Eingang_Click(object sender, EventArgs e)
        {

        }

        private void pb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
