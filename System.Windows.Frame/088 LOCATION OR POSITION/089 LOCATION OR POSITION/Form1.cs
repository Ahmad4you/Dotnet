using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _088_LOCATION_OR_POSITION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmTest_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);

            //btnMy.Top = x;
            //btnMy.Left = y;

            btnMy.Location = new Point(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btnMy.Location = new Point(btnMy.Top + 1, btnMy.Left + 1);
            this.Left += 1;
            this.Top += 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //btnMy.Location = new Point(btnMy.Top - 1, btnMy.Left - 1);
            this.Left -= 1;
            this.Top -= 1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcom");
        }
    }
}
