using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _082_FORM_PROPERTIES
{
    public partial class Form1 : Form
    {
      /*
      * StartPosition   CenterScreen
      * windowStat      normal, Min, Max
      * MinimizeBox     true
      * MaxemizeBox     true
      * ControlBox      true
      * TopMost         if true -> Form Window is the Top from all window
      * ShowInTaskBar   if false -> to hide the Icon
      * Opacity         90 %
      * Font            Fett -> All component will Fett
      * FormBorderStyle
      * icon            -> program + right click + Eigenschaften + symbol und Manifest
      * 
      */
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // FlatStyle      popup
            MessageBox.Show("your name is: "+txt1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * double click auf der Form
             * to show messag box bevor the Form runing
             */

            string strName = "Ahmad";
            MessageBox.Show("Hallo: " + strName);
        }
    }
}
