using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _224_OOP_MsgBox
{
    class Tools
    {
        /*
         *using System.Windows.Forms; 
         * Projekt --> Verveis Hinzufügen
         * or Add Reference
         * 
         */
        public static void MsgBox(string text, string caption = "" )
        {
            MessageBox.Show(text, caption);
        }
        public static bool MsgBoxYesNo(string text, string caption = "")
        {
            DialogResult dr = MessageBox.Show(text, caption, MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes) return true;
            else return false;
        }
    }
}
