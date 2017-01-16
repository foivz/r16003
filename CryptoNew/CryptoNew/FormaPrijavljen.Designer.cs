namespace CryptoNew
{
    partial class FormaPrijavljen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prikazKorIme = new System.Windows.Forms.TextBox();
            this.prikazTipKorisnika = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = global::CryptoNew.Properties.Resources.crypto;
            this.panel1.Location = new System.Drawing.Point(143, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 240);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Eras Bold ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(83, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dobrodošli u Aplikaciju Crypto";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.prikazTipKorisnika);
            this.panel2.Controls.Add(this.prikazKorIme);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 154);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Korisničko Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(22, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tip Korisnika:";
            // 
            // prikazKorIme
            // 
            this.prikazKorIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prikazKorIme.Location = new System.Drawing.Point(189, 25);
            this.prikazKorIme.Name = "prikazKorIme";
            this.prikazKorIme.ReadOnly = true;
            this.prikazKorIme.Size = new System.Drawing.Size(283, 26);
            this.prikazKorIme.TabIndex = 2;
            // 
            // prikazTipKorisnika
            // 
            this.prikazTipKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prikazTipKorisnika.Location = new System.Drawing.Point(189, 93);
            this.prikazTipKorisnika.Name = "prikazTipKorisnika";
            this.prikazTipKorisnika.ReadOnly = true;
            this.prikazTipKorisnika.Size = new System.Drawing.Size(283, 26);
            this.prikazTipKorisnika.TabIndex = 3;
            // 
            // FormaPrijavljen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(535, 456);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormaPrijavljen";
            this.Text = "FormaPrijavljen";
            this.Load += new System.EventHandler(this.FormaPrijavljen_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox prikazTipKorisnika;
        private System.Windows.Forms.TextBox prikazKorIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}