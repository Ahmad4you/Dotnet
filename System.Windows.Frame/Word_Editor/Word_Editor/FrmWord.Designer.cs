
namespace Word_Editor
{
    partial class FrmWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWord));
            this.richBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxFont = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.cbxB = new System.Windows.Forms.CheckBox();
            this.cbxU = new System.Windows.Forms.CheckBox();
            this.cbxI = new System.Windows.Forms.CheckBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl8 = new System.Windows.Forms.Panel();
            this.pnl7 = new System.Windows.Forms.Panel();
            this.pnl10 = new System.Windows.Forms.Panel();
            this.pnl9 = new System.Windows.Forms.Panel();
            this.btnMore = new System.Windows.Forms.Button();
            this.rdoText = new System.Windows.Forms.RadioButton();
            this.rdoBack = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.SuspendLayout();
            // 
            // richBox
            // 
            this.richBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richBox.Location = new System.Drawing.Point(0, 0);
            this.richBox.Name = "richBox";
            this.richBox.Size = new System.Drawing.Size(998, 372);
            this.richBox.TabIndex = 0;
            this.richBox.Text = resources.GetString("richBox.Text");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.richBox);
            this.panel1.Location = new System.Drawing.Point(28, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 374);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Font Name";
            // 
            // cbxFont
            // 
            this.cbxFont.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxFont.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxFont.FormattingEnabled = true;
            this.cbxFont.Location = new System.Drawing.Point(29, 44);
            this.cbxFont.Name = "cbxFont";
            this.cbxFont.Size = new System.Drawing.Size(249, 36);
            this.cbxFont.TabIndex = 3;
            this.cbxFont.SelectedIndexChanged += new System.EventHandler(this.cbxFont_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(293, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Size";
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(293, 44);
            this.nudSize.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(57, 34);
            this.nudSize.TabIndex = 5;
            this.nudSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSize.ValueChanged += new System.EventHandler(this.cbxFont_SelectedIndexChanged);
            // 
            // cbxB
            // 
            this.cbxB.AutoSize = true;
            this.cbxB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxB.Location = new System.Drawing.Point(356, 46);
            this.cbxB.Name = "cbxB";
            this.cbxB.Size = new System.Drawing.Size(77, 32);
            this.cbxB.TabIndex = 6;
            this.cbxB.Text = "Bold";
            this.cbxB.UseVisualStyleBackColor = true;
            this.cbxB.CheckedChanged += new System.EventHandler(this.cbxFont_SelectedIndexChanged);
            // 
            // cbxU
            // 
            this.cbxU.AutoSize = true;
            this.cbxU.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.cbxU.Location = new System.Drawing.Point(436, 42);
            this.cbxU.Name = "cbxU";
            this.cbxU.Size = new System.Drawing.Size(140, 36);
            this.cbxU.TabIndex = 7;
            this.cbxU.Text = "Underline";
            this.cbxU.UseVisualStyleBackColor = true;
            this.cbxU.CheckedChanged += new System.EventHandler(this.cbxFont_SelectedIndexChanged);
            // 
            // cbxI
            // 
            this.cbxI.AutoSize = true;
            this.cbxI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cbxI.Location = new System.Drawing.Point(572, 42);
            this.cbxI.Name = "cbxI";
            this.cbxI.Size = new System.Drawing.Size(75, 32);
            this.cbxI.TabIndex = 8;
            this.cbxI.Text = "Italic";
            this.cbxI.UseVisualStyleBackColor = true;
            this.cbxI.CheckedChanged += new System.EventHandler(this.cbxFont_SelectedIndexChanged);
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl1.Location = new System.Drawing.Point(736, 15);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(25, 25);
            this.pnl1.TabIndex = 9;
            this.pnl1.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.Red;
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl2.Location = new System.Drawing.Point(736, 42);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(25, 25);
            this.pnl2.TabIndex = 10;
            this.pnl2.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // pnl4
            // 
            this.pnl4.BackColor = System.Drawing.Color.Yellow;
            this.pnl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl4.Location = new System.Drawing.Point(767, 42);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(25, 25);
            this.pnl4.TabIndex = 12;
            this.pnl4.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.Silver;
            this.pnl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl3.Location = new System.Drawing.Point(767, 15);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(25, 25);
            this.pnl3.TabIndex = 11;
            this.pnl3.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // pnl6
            // 
            this.pnl6.BackColor = System.Drawing.Color.DarkRed;
            this.pnl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl6.Location = new System.Drawing.Point(798, 42);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(25, 25);
            this.pnl6.TabIndex = 12;
            this.pnl6.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // pnl5
            // 
            this.pnl5.BackColor = System.Drawing.Color.Orange;
            this.pnl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl5.Location = new System.Drawing.Point(798, 15);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(25, 25);
            this.pnl5.TabIndex = 11;
            this.pnl5.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // pnl8
            // 
            this.pnl8.BackColor = System.Drawing.Color.Cyan;
            this.pnl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl8.Location = new System.Drawing.Point(829, 42);
            this.pnl8.Name = "pnl8";
            this.pnl8.Size = new System.Drawing.Size(25, 25);
            this.pnl8.TabIndex = 12;
            this.pnl8.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // pnl7
            // 
            this.pnl7.BackColor = System.Drawing.Color.White;
            this.pnl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl7.Location = new System.Drawing.Point(829, 15);
            this.pnl7.Name = "pnl7";
            this.pnl7.Size = new System.Drawing.Size(25, 25);
            this.pnl7.TabIndex = 11;
            this.pnl7.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // pnl10
            // 
            this.pnl10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnl10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl10.Location = new System.Drawing.Point(860, 42);
            this.pnl10.Name = "pnl10";
            this.pnl10.Size = new System.Drawing.Size(25, 25);
            this.pnl10.TabIndex = 12;
            this.pnl10.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // pnl9
            // 
            this.pnl9.BackColor = System.Drawing.Color.Pink;
            this.pnl9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl9.Location = new System.Drawing.Point(860, 15);
            this.pnl9.Name = "pnl9";
            this.pnl9.Size = new System.Drawing.Size(25, 25);
            this.pnl9.TabIndex = 11;
            this.pnl9.Click += new System.EventHandler(this.pnl1_Click);
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMore.ForeColor = System.Drawing.Color.White;
            this.btnMore.Location = new System.Drawing.Point(891, 15);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(136, 52);
            this.btnMore.TabIndex = 13;
            this.btnMore.Text = "More Colors";
            this.btnMore.UseVisualStyleBackColor = false;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // rdoText
            // 
            this.rdoText.AutoSize = true;
            this.rdoText.Checked = true;
            this.rdoText.Location = new System.Drawing.Point(653, 15);
            this.rdoText.Name = "rdoText";
            this.rdoText.Size = new System.Drawing.Size(67, 32);
            this.rdoText.TabIndex = 14;
            this.rdoText.TabStop = true;
            this.rdoText.Text = "Text";
            this.rdoText.UseVisualStyleBackColor = true;
            // 
            // rdoBack
            // 
            this.rdoBack.AutoSize = true;
            this.rdoBack.Location = new System.Drawing.Point(653, 41);
            this.rdoBack.Name = "rdoBack";
            this.rdoBack.Size = new System.Drawing.Size(73, 32);
            this.rdoBack.TabIndex = 15;
            this.rdoBack.Text = "Back";
            this.rdoBack.UseVisualStyleBackColor = true;
            // 
            // FrmWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1060, 494);
            this.Controls.Add(this.rdoBack);
            this.Controls.Add(this.rdoText);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.pnl10);
            this.Controls.Add(this.pnl8);
            this.Controls.Add(this.pnl9);
            this.Controls.Add(this.pnl6);
            this.Controls.Add(this.pnl7);
            this.Controls.Add(this.pnl4);
            this.Controls.Add(this.pnl5);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.cbxI);
            this.Controls.Add(this.cbxU);
            this.Controls.Add(this.cbxB);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxFont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FrmWord_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.CheckBox cbxB;
        private System.Windows.Forms.CheckBox cbxU;
        private System.Windows.Forms.CheckBox cbxI;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl8;
        private System.Windows.Forms.Panel pnl7;
        private System.Windows.Forms.Panel pnl10;
        private System.Windows.Forms.Panel pnl9;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.RadioButton rdoText;
        private System.Windows.Forms.RadioButton rdoBack;
    }
}

