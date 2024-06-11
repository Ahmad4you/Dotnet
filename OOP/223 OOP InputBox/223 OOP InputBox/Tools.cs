using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


    class Tools
    {
    /*
    * Projekt --> Verweis hinzufügen(Add Referenz) --> Framework
    * using System.Windows.Forms;
    * 
    * using System.Drawing;
    * 
    * from wpf new Form to Add new Class "Tools" :
    * auf project right click --> Add --> Existing Item
    * auf project right click --> Hinzufügen --> Vorhandenes Element...
    * 
    * offenen Sie der neue hinzugefügene Class und Lösche mal den Namespace Komplett mit Klameren
    * 
    */
    public static string InputBox(string title, string text, bool isPassword = false)
        {
            Form frm = new Form();
            Label lblHeader = new Label();
            TextBox txt = new TextBox();
            Button btnOk = new Button();
            Button btnClose = new Button();
       
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.ControlBox = false;
            frm.MinimizeBox = false;
            frm.MaximizeBox = false;
            frm.BackColor = Color.White;
            frm.Text = title;
            frm.Font = new Font("Arial", 14, FontStyle.Bold);
            frm.Size = new Size(400, 190);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((Screen.PrimaryScreen.Bounds.Width - frm.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - frm.Height) / 2); // to center position

            lblHeader.Text = text;
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(10, 10);
            if (isPassword) txt.PasswordChar = '*';  // isPassword = true
            txt.Location = new Point(10, 45);
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Width = frm.Width - 40;

            btnOk.Location = new Point(10, txt.Top + txt.Height + 20);
            btnOk.Text = "Ok";
            btnOk.Height += 5;
            btnOk.Width = 90;
            btnOk.Cursor = Cursors.Hand;
            btnOk.FlatStyle = FlatStyle.Standard;
            btnOk.BackColor = Color.Navy;
            btnOk.ForeColor = Color.White;

            btnClose.Location = new Point(10 + btnOk.Width + 10, btnOk.Top);
            btnClose.Text = "Close";
            btnClose.Height = btnOk.Height;
            btnClose.Width = btnOk.Width;
            btnClose.Cursor = btnOk.Cursor;
            btnClose.FlatStyle = btnOk.FlatStyle;
            btnClose.BackColor = btnOk.BackColor;
            btnClose.ForeColor = btnOk.ForeColor;

            frm.Controls.Add(lblHeader);
            frm.Controls.Add(txt);
            frm.Controls.Add(btnOk);
            frm.Controls.Add(btnClose);

            btnClose.Click += delegate {
                frm.Close();
            };
            string textFromTxt = "";
            btnOk.Click += delegate {
                textFromTxt = txt.Text;
                frm.Close();
            };

            txt.KeyDown += delegate(object MySender, KeyEventArgs MyE) {
                if (MyE.KeyCode == Keys.Enter)
                {
                    textFromTxt = txt.Text;
                    frm.Close();
                }
                };   // when press Enter

            frm.ShowDialog();

            return textFromTxt;
        }
    }

