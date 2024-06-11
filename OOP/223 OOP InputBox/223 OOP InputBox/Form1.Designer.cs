
namespace _223_OOP_InputBox
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
            this.lblHallo = new System.Windows.Forms.Label();
            this.btnClic = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHallo
            // 
            this.lblHallo.AutoSize = true;
            this.lblHallo.Location = new System.Drawing.Point(65, 42);
            this.lblHallo.Name = "lblHallo";
            this.lblHallo.Size = new System.Drawing.Size(0, 31);
            this.lblHallo.TabIndex = 0;
            // 
            // btnClic
            // 
            this.btnClic.Location = new System.Drawing.Point(71, 179);
            this.btnClic.Name = "btnClic";
            this.btnClic.Size = new System.Drawing.Size(147, 43);
            this.btnClic.TabIndex = 1;
            this.btnClic.Text = "Click Me";
            this.btnClic.UseVisualStyleBackColor = true;
            this.btnClic.Click += new System.EventHandler(this.btnClic_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(65, 95);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(0, 31);
            this.lblPass.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(444, 297);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.btnClic);
            this.Controls.Add(this.lblHallo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHallo;
        private System.Windows.Forms.Button btnClic;
        private System.Windows.Forms.Label lblPass;
    }
}

