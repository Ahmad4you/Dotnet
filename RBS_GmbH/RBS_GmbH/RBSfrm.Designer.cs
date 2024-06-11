
namespace RBS_GmbH
{
    partial class RBSfrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RBSfrm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRechNummer = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTyp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPreis = new System.Windows.Forms.TextBox();
            this.txtMenge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.txtGesamt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.colTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMenge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVerkaufsP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "https://www.rbs-ulm.de/";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(663, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rechnungsnummer";
            // 
            // txtRechNummer
            // 
            this.txtRechNummer.ForeColor = System.Drawing.Color.Red;
            this.txtRechNummer.Location = new System.Drawing.Point(212, 47);
            this.txtRechNummer.Name = "txtRechNummer";
            this.txtRechNummer.Size = new System.Drawing.Size(167, 27);
            this.txtRechNummer.TabIndex = 3;
            this.txtRechNummer.Text = "0000";
            // 
            // txtDatum
            // 
            this.txtDatum.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDatum.Location = new System.Drawing.Point(461, 47);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(167, 27);
            this.txtDatum.TabIndex = 5;
            this.txtDatum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDatum_KeyPress);
            this.txtDatum.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtDatum_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Client Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(212, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(416, 27);
            this.txtName.TabIndex = 7;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Warentyp";
            // 
            // cbxTyp
            // 
            this.cbxTyp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTyp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTyp.FormattingEnabled = true;
            this.cbxTyp.Location = new System.Drawing.Point(212, 159);
            this.cbxTyp.Name = "cbxTyp";
            this.cbxTyp.Size = new System.Drawing.Size(416, 28);
            this.cbxTyp.TabIndex = 9;
            this.cbxTyp.SelectedIndexChanged += new System.EventHandler(this.cbxTyp_SelectedIndexChanged);
            this.cbxTyp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxTyp_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Preis";
            // 
            // txtPreis
            // 
            this.txtPreis.Location = new System.Drawing.Point(212, 204);
            this.txtPreis.Name = "txtPreis";
            this.txtPreis.ReadOnly = true;
            this.txtPreis.Size = new System.Drawing.Size(167, 27);
            this.txtPreis.TabIndex = 11;
            // 
            // txtMenge
            // 
            this.txtMenge.Location = new System.Drawing.Point(461, 204);
            this.txtMenge.Name = "txtMenge";
            this.txtMenge.Size = new System.Drawing.Size(167, 27);
            this.txtMenge.TabIndex = 13;
            this.txtMenge.Text = "1";
            this.txtMenge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMenge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMenge_KeyDown);
            this.txtMenge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMenge_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Menge";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(25, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(759, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "_________________________________________________________________________________" +
    "____________________________________________";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToOrderColumns = true;
            this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTyp,
            this.colMenge,
            this.colPreis,
            this.colVerkaufsP});
            this.dgvInvoice.Location = new System.Drawing.Point(25, 286);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowHeadersWidth = 51;
            this.dgvInvoice.RowTemplate.Height = 29;
            this.dgvInvoice.Size = new System.Drawing.Size(759, 188);
            this.dgvInvoice.TabIndex = 15;
            this.dgvInvoice.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvInvoice_CellBeginEdit);
            this.dgvInvoice.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellEndEdit);
            // 
            // txtGesamt
            // 
            this.txtGesamt.BackColor = System.Drawing.Color.DarkMagenta;
            this.txtGesamt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGesamt.ForeColor = System.Drawing.Color.Orange;
            this.txtGesamt.Location = new System.Drawing.Point(212, 249);
            this.txtGesamt.Name = "txtGesamt";
            this.txtGesamt.Size = new System.Drawing.Size(167, 31);
            this.txtGesamt.TabIndex = 17;
            this.txtGesamt.Text = "0";
            this.txtGesamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGesamt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGesamt_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Gesamt Preis in €";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Indigo;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(425, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Indigo;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(534, 249);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(94, 29);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // colTyp
            // 
            this.colTyp.FillWeight = 12.83423F;
            this.colTyp.HeaderText = "Warentyp";
            this.colTyp.MinimumWidth = 6;
            this.colTyp.Name = "colTyp";
            this.colTyp.ReadOnly = true;
            // 
            // colMenge
            // 
            this.colMenge.FillWeight = 12.83423F;
            this.colMenge.HeaderText = "Menge";
            this.colMenge.MinimumWidth = 6;
            this.colMenge.Name = "colMenge";
            // 
            // colPreis
            // 
            this.colPreis.FillWeight = 12.83423F;
            this.colPreis.HeaderText = "Preis pro Stuck";
            this.colPreis.MinimumWidth = 6;
            this.colPreis.Name = "colPreis";
            this.colPreis.ReadOnly = true;
            // 
            // colVerkaufsP
            // 
            this.colVerkaufsP.FillWeight = 12.4973F;
            this.colVerkaufsP.HeaderText = "Verkaufspreis in €";
            this.colVerkaufsP.MinimumWidth = 6;
            this.colVerkaufsP.Name = "colVerkaufsP";
            this.colVerkaufsP.ReadOnly = true;
            // 
            // RBSfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGesamt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMenge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPreis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxTyp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRechNummer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "RBSfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RBS GmbH";
            this.Load += new System.EventHandler(this.RBSfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRechNummer;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTyp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPreis;
        private System.Windows.Forms.TextBox txtMenge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.TextBox txtGesamt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVerkaufsP;
    }
}

