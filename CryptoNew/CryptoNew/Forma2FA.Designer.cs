namespace CryptoNew
{
    partial class Forma2FA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.unosKod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gumbPosalji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unosKod
            // 
            this.unosKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unosKod.Location = new System.Drawing.Point(41, 83);
            this.unosKod.Name = "unosKod";
            this.unosKod.Size = new System.Drawing.Size(361, 32);
            this.unosKod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite 2FA kod sa vašeg telefona:";
            // 
            // gumbPosalji
            // 
            this.gumbPosalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbPosalji.Location = new System.Drawing.Point(171, 121);
            this.gumbPosalji.Name = "gumbPosalji";
            this.gumbPosalji.Size = new System.Drawing.Size(80, 32);
            this.gumbPosalji.TabIndex = 2;
            this.gumbPosalji.Text = "Pošalji";
            this.gumbPosalji.UseVisualStyleBackColor = true;
            this.gumbPosalji.Click += new System.EventHandler(this.gumbPosalji_Click);
            // 
            // Forma2FA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(442, 196);
            this.Controls.Add(this.gumbPosalji);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unosKod);
            this.Name = "Forma2FA";
            this.Text = "Potvrda Prijave (2FA)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unosKod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gumbPosalji;
    }
}