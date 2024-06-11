
namespace Aufgabe_Mitarbeiter_Polymorphie
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radAngestellte = new System.Windows.Forms.RadioButton();
            this.radEntwikler = new System.Windows.Forms.RadioButton();
            this.radAzubi = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radAzubi);
            this.groupBox1.Controls.Add(this.radEntwikler);
            this.groupBox1.Controls.Add(this.radAngestellte);
            this.groupBox1.Location = new System.Drawing.Point(77, 320);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(275, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mitarbeiter:";
            // 
            // radAngestellte
            // 
            this.radAngestellte.AutoSize = true;
            this.radAngestellte.Location = new System.Drawing.Point(29, 44);
            this.radAngestellte.Name = "radAngestellte";
            this.radAngestellte.Size = new System.Drawing.Size(124, 24);
            this.radAngestellte.TabIndex = 0;
            this.radAngestellte.Text = "Angestellte";
            this.radAngestellte.UseVisualStyleBackColor = true;
            // 
            // radEntwikler
            // 
            this.radEntwikler.AutoSize = true;
            this.radEntwikler.Checked = true;
            this.radEntwikler.Location = new System.Drawing.Point(29, 83);
            this.radEntwikler.Name = "radEntwikler";
            this.radEntwikler.Size = new System.Drawing.Size(117, 24);
            this.radEntwikler.TabIndex = 1;
            this.radEntwikler.TabStop = true;
            this.radEntwikler.Text = "Entwickler";
            this.radEntwikler.UseVisualStyleBackColor = true;
            // 
            // radAzubi
            // 
            this.radAzubi.AutoSize = true;
            this.radAzubi.Location = new System.Drawing.Point(29, 122);
            this.radAzubi.Name = "radAzubi";
            this.radAzubi.Size = new System.Drawing.Size(77, 24);
            this.radAzubi.TabIndex = 2;
            this.radAzubi.Text = "Azubi";
            this.radAzubi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 538);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radAzubi;
        private System.Windows.Forms.RadioButton radEntwikler;
        private System.Windows.Forms.RadioButton radAngestellte;
    }
}

