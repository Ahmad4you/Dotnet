using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _223_OOP_InputBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClic_Click(object sender, EventArgs e)
        {
            string strName = Tools.InputBox("Enter Name", "Pleas Enter Your Name");
            lblHallo.Text = "Hallo " + strName;

            string strPass = Tools.InputBox("Enter Password", "Enter Your Password:", true);
            lblPass.Text = "Password: " + strPass;
        }
    }
}
