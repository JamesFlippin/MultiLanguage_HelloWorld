using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_ScratchPad
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            lblSayHello.Text = "Hello World!";
            lblSayName.Text = "My name is James!!!";
        }

        private void btnGoodbye_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
