using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Editor
{
    public partial class FrmWord : Form
    {
        public FrmWord()
        {
            InitializeComponent();
        }
        private void SetFont()
        {
            string strFont = "Tahoma";

            if (cbxFont.SelectedIndex > -1) strFont = cbxFont.SelectedItem.ToString();

            FontStyle fStyle = FontStyle.Regular;
            if (cbxB.Checked) fStyle = fStyle | FontStyle.Bold;
            if (cbxU.Checked) fStyle = fStyle | FontStyle.Underline;
            if (cbxI.Checked) fStyle = fStyle | FontStyle.Italic;

            Font myFont = new Font(strFont, (int)nudSize.Value, fStyle);
            richBox.SelectionFont = myFont;
        }

        private void SetColor(Color color)
        {
            if (rdoText.Checked) richBox.SelectionColor = color;
            else richBox.SelectionBackColor = color;
        }
        
        private void cbxFont_SelectedIndexChanged(object sender, EventArgs e)
        {

            SetFont();
        }

        private void FrmWord_Load(object sender, EventArgs e)
        {
            cbxFont.BeginUpdate();
            foreach (FontFamily font in FontFamily.Families)
            {
                cbxFont.Items.Add(font.Name);

            }
            cbxFont.EndUpdate();
            cbxFont.SelectedItem = "Tahoma";
        }

        private void pnl1_Click(object sender, EventArgs e)
        {
            SetColor( ((Panel)sender).BackColor);
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog();
            if (cDialog.ShowDialog() == DialogResult.OK) SetColor(cDialog.Color);
        }
    }
}
