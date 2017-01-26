namespace CryptoNew
{
    partial class SlanjePoruka
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
            this.odabirUsername = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.unosSadrzaj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gumbPosalji = new System.Windows.Forms.Button();
            this.prikazLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // odabirUsername
            // 
            this.odabirUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odabirUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odabirUsername.FormattingEnabled = true;
            this.odabirUsername.Location = new System.Drawing.Point(75, 70);
            this.odabirUsername.Name = "odabirUsername";
            this.odabirUsername.Size = new System.Drawing.Size(215, 28);
            this.odabirUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(72, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberite Korisničko Ime:";
            // 
            // unosSadrzaj
            // 
            this.unosSadrzaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unosSadrzaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unosSadrzaj.Location = new System.Drawing.Point(72, 156);
            this.unosSadrzaj.Multiline = true;
            this.unosSadrzaj.Name = "unosSadrzaj";
            this.unosSadrzaj.Size = new System.Drawing.Size(479, 235);
            this.unosSadrzaj.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(71, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sadržaj:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gumbPosalji
            // 
            this.gumbPosalji.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gumbPosalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbPosalji.Location = new System.Drawing.Point(327, 397);
            this.gumbPosalji.Name = "gumbPosalji";
            this.gumbPosalji.Size = new System.Drawing.Size(224, 43);
            this.gumbPosalji.TabIndex = 4;
            this.gumbPosalji.Text = "Enkriptiraj i Pošalji";
            this.gumbPosalji.UseVisualStyleBackColor = true;
            // 
            // prikazLog
            // 
            this.prikazLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prikazLog.Location = new System.Drawing.Point(573, 156);
            this.prikazLog.Multiline = true;
            this.prikazLog.Name = "prikazLog";
            this.prikazLog.Size = new System.Drawing.Size(197, 235);
            this.prikazLog.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(733, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Log";
            // 
            // SlanjePoruka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 497);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prikazLog);
            this.Controls.Add(this.gumbPosalji);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unosSadrzaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odabirUsername);
            this.Name = "SlanjePoruka";
            this.Text = "Slanje Poruke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox odabirUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox unosSadrzaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gumbPosalji;
        private System.Windows.Forms.TextBox prikazLog;
        private System.Windows.Forms.Label label3;
    }
}