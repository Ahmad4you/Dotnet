using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _086_TEXT_BOX_AND_LABEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickHier_Click(object sender, EventArgs e)
        {
            string strName = txtPersonName.Text;
            MessageBox.Show("Hallo " + strName);
            lblMsg.Text = "Hallo " + strName;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            checkBx.Visible = true;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            checkBx.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }
    }
}
