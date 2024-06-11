using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBS_GmbH
{
    public partial class RBSfrm : Form
    {
        public RBSfrm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.rbs-ulm.de/");
        }

        private void RBSfrm_Load(object sender, EventArgs e)
        {
            txtDatum.Text = DateTime.Now.ToString();

            Random zufall = new Random();
            txtRechNummer.Text = Convert.ToString(zufall.Next(100, 1000));

            Dictionary<int, string> itemsData = new Dictionary<int, string>();
            itemsData.Add(1020, "Asus Chromebook C423");
            itemsData.Add(1450, "Asus Chromebook C214");
            itemsData.Add(820, "Asus TUF Gaming F17");
            itemsData.Add(999, "Asus TUF Gaming F15");
            itemsData.Add(1040, "Asus ROG Flow X13");
            itemsData.Add(1550, "Asus ROG Duo 15 SE");
            itemsData.Add(920, "Asus ROG G15 (2021)");
            itemsData.Add(1099, "Asus ROG G14 (2021)");
            itemsData.Add(1120, "Asus ROG M16");
            itemsData.Add(1350, "Asus ROG S17");
            itemsData.Add(620, "Asus VivoBook 17");
            itemsData.Add(888, "Asus VivoBook 15");
            itemsData.Add(955, "Asus VivoBook Flip 14");
            itemsData.Add(1060, "Asus VivoBook Ultra");
            itemsData.Add(1750, "Asus VivoBook S S14");
            itemsData.Add(890, "Asus ZenBook 13 OLED");
            itemsData.Add(1199, "Asus ROG Strix G17");
            itemsData.Add(1599, "Asus ROG Strix G15");
            itemsData.Add(1055, "Asus ZenBook Pro15");
            itemsData.Add(1755, "Asus ZenBook Duo 14");
            itemsData.Add(896, "Asus TUF Dash F15");
            itemsData.Add(1200, "Asus ExpertBook B9");
            itemsData.Add(1600, "Asus ZenBook S");

            itemsData.Add(200, "keyboard Corsair RGB");
            itemsData.Add(250, "keyboard Corsair optical");
            itemsData.Add(100, "keyboard G.Skill KM360");
            itemsData.Add(150, "keyboard HyperX");

            itemsData.Add(156, "Mouse Corsair RGB");
            itemsData.Add(350, "Mouse Corsair optical");
            itemsData.Add(120, "Mouse G.Skill optical");
            itemsData.Add(199, "Mouse HyperX");

            cbxTyp.DataSource = new BindingSource(itemsData, null);
            cbxTyp.DisplayMember = "value";
            cbxTyp.ValueMember = "key";

            foreach (DataGridViewColumn col in dgvInvoice.Columns)
                col.DefaultCellStyle.ForeColor = Color.Navy;

            dgvInvoice.Columns[1].DefaultCellStyle.ForeColor = Color.Red;
            dgvInvoice.Columns[3].DefaultCellStyle.ForeColor = Color.DarkGreen;

            txtPreis.Text = cbxTyp.SelectedValue.ToString();

            txtName.Focus();
            txtName.Select();
            txtName.SelectAll();
        }

        private void txtDatum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtDatum_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                txtDatum.ContextMenuStrip = new ContextMenuStrip();
            }
        }

        private void txtGesamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) cbxTyp.Focus();
        }

        private void txtMenge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) {
                btnAdd.PerformClick();
                cbxTyp.Focus();
          }
        }

        private void cbxTyp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) txtMenge.Focus();
            txtMenge.SelectAll();
        }

        private void cbxTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPreis.Text = cbxTyp.SelectedValue.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxTyp.SelectedIndex <= -1) return; // der Nutzer hat ne Auswal außer Gridbox getroffen!

            string item = cbxTyp.Text;
            int menge = Convert.ToInt32(txtMenge.Text);
            int preis = Convert.ToInt32(txtPreis.Text);
            int vkPreis = menge * preis;

            Object[] row = { item, menge, preis, vkPreis };
            dgvInvoice.Rows.Add(row);
            txtGesamt.Text = (Convert.ToInt32(txtGesamt.Text) + vkPreis) + "";
        }
        /*
         * Menge ist keine Digit 
         * es darf keine Digit eingegeben also nur Zahlen
         * und damit erlaube ich die Nutzung von control-Tasten wie z.B. Backspace
         */
        private void txtMenge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)){
                e.Handled = true;
            }
        }

        string dgvOldMenge = "1";
        private void dgvInvoice_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(dgvInvoice.CurrentRow != null)  // row schon in dgv existiert
            {
                dgvOldMenge = dgvInvoice.CurrentRow.Cells["colMenge"].Value + ""; //die Menge, die der nutzer in Textfeld eingegeben hat d.h vor CellBeginEdit
            }
        }

        private void dgvInvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInvoice.CurrentRow != null)
            {
                
                string dgvnewMenge = dgvInvoice.CurrentRow.Cells["colMenge"].Value + "";
                if (dgvOldMenge == dgvnewMenge) return;

                //wenn der Nutzer Buchstaben in Spalte „Menge“ eingegeben hat, wird Alte Wert der Menge gezeigt werden.
                if (!Regex.IsMatch(dgvnewMenge, "^\\d+$"))
                {
                    dgvInvoice.CurrentRow.Cells["colMenge"].Value = dgvOldMenge;
                }
                else // es hat neue Menge in ColMenge eingegeben
                {
                    int p = (int)dgvInvoice.CurrentRow.Cells["colPreis"].Value;
                    int m = Convert.ToInt32(dgvnewMenge);
                    dgvInvoice.CurrentRow.Cells["colVerkaufsP"].Value = m * p; //hier wird neue VKPreis gerechnet
                    //hier wird die Gesamtpreis gerechnet
                    int newGesamtP = 0;
                    foreach(DataGridViewRow r in dgvInvoice.Rows)
                    {
                        newGesamtP += Convert.ToInt32(r.Cells["colVerkaufsP"].Value);
                    }
                    txtGesamt.Text = newGesamtP + "";
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK) //printPreviewDialog1 auf
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float margin = 40;
            string rechnungsnummer = "Rechnungsnummer: " + txtRechNummer.Text;
            string strDatum = "Datum: " + txtDatum.Text;
            string strClientName = "Client Name: " + txtName.Text;

            Font f = new Font("Arial", 18, FontStyle.Bold);
            SizeF fontSizeNo = e.Graphics.MeasureString(rechnungsnummer, f); //to measure Size Rechnungsnummer
            SizeF fontSizeDatum = e.Graphics.MeasureString(strDatum, f);
            SizeF fontSizeClientname = e.Graphics.MeasureString(strClientName, f);

            e.Graphics.DrawImage(Properties.Resources.Screenshot_2021_07_17_213413, 5, 5, 200, 200);
            e.Graphics.DrawString(rechnungsnummer, f, Brushes.Red, (e.PageBounds.Width - fontSizeNo.Width) / 2, margin); // wird in der mitte der Document gesetzt
            e.Graphics.DrawString(strDatum, f, Brushes.Black, (e.PageBounds.Width - fontSizeNo.Width) / 2, margin + fontSizeNo.Height);
            e.Graphics.DrawString(strClientName, f, Brushes.Navy, (e.PageBounds.Width - fontSizeNo.Width) / 2, margin + fontSizeNo.Height + fontSizeDatum.Height);

            float preHeight = margin + fontSizeNo.Height + fontSizeDatum.Height + fontSizeClientname.Height +70;
            e.Graphics.DrawRectangle(Pens.Black, margin, preHeight, e.PageBounds.Width-margin *2, e.PageBounds.Height-margin -preHeight);

            float colHeight = 60;
            float col1width = 125;
            float col2width = 125 + col1width;
            float col3width = 125 + col2width;
            float col4width = 255 + col3width;

            e.Graphics.DrawLine(Pens.Black, margin, preHeight + colHeight, e.PageBounds.Width - margin, preHeight+colHeight);
            e.Graphics.DrawString("Verkaufspreis", f, Brushes.Black, e.PageBounds.Width -margin * 2 -col1width-5, preHeight+15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col1width, preHeight, e.PageBounds.Width - margin *2 -col1width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("Preis", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col2width+15, preHeight+15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col2width, preHeight, e.PageBounds.Width - margin * 2 - col2width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("Menge", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col3width+15, preHeight+15);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col3width, preHeight, e.PageBounds.Width - margin * 2 - col3width, e.PageBounds.Height - margin);

            e.Graphics.DrawString("Warentyp", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col4width+40, preHeight+15);
            /*
             * Rechnung content
             */
            float rowsHeight = 60;
            for(int x = 0; x< dgvInvoice.Rows.Count; x += 1)
            {
                e.Graphics.DrawString(dgvInvoice.Rows[x].Cells[3].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - col1width, preHeight + rowsHeight);
                e.Graphics.DrawString(dgvInvoice.Rows[x].Cells[2].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - col2width, preHeight + rowsHeight);
                e.Graphics.DrawString(dgvInvoice.Rows[x].Cells[1].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - col3width, preHeight + rowsHeight);
                e.Graphics.DrawString(dgvInvoice.Rows[x].Cells[0].Value.ToString(), f, Brushes.Navy, e.PageBounds.Width - margin * 2 - col4width -70, preHeight + rowsHeight);

                e.Graphics.DrawLine(Pens.Black, margin, preHeight + rowsHeight + colHeight, e.PageBounds.Width - margin, preHeight + rowsHeight + colHeight);
                rowsHeight += 60;
            }
            double bruto = Convert.ToDouble(txtGesamt.Text);
            //int netto = bruto /(1 + (19/ 100));
            double netto = bruto /(1.19);
            double mwst = bruto - netto;

            e.Graphics.DrawString("Netto €", f, Brushes.Red, e.PageBounds.Width - margin * 2 - col2width, preHeight + rowsHeight);
            e.Graphics.DrawString(netto.ToString("0.00"), f, Brushes.Blue, e.PageBounds.Width - margin * 2 - col1width, preHeight + rowsHeight);

            e.Graphics.DrawString("MwSt €", f, Brushes.BlueViolet, e.PageBounds.Width - margin * 2 - col2width, preHeight + rowsHeight +50);
            e.Graphics.DrawString(mwst.ToString("0.00"), f, Brushes.BlueViolet, e.PageBounds.Width - margin * 2 - col1width, preHeight + rowsHeight+50);

            e.Graphics.DrawString("Gesamt €", f, Brushes.Red, e.PageBounds.Width - margin * 2 - col2width, preHeight + rowsHeight + 100);
            e.Graphics.DrawString(txtGesamt.Text, f, Brushes.Blue, e.PageBounds.Width - margin * 2 - col1width, preHeight + rowsHeight + 100);

        }

    }
}
