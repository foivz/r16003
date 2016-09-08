namespace crypto0._1stable
{
    partial class ChatForm
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
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.txtUpis = new System.Windows.Forms.TextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.aktKorisnici = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.korIme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(12, 12);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(344, 216);
            this.txtIspis.TabIndex = 0;
            // 
            // txtUpis
            // 
            this.txtUpis.Location = new System.Drawing.Point(12, 250);
            this.txtUpis.Name = "txtUpis";
            this.txtUpis.Size = new System.Drawing.Size(344, 20);
            this.txtUpis.TabIndex = 1;
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(362, 201);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(141, 69);
            this.btnPosalji.TabIndex = 2;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // aktKorisnici
            // 
            this.aktKorisnici.FormattingEnabled = true;
            this.aktKorisnici.Location = new System.Drawing.Point(362, 38);
            this.aktKorisnici.Name = "aktKorisnici";
            this.aktKorisnici.Size = new System.Drawing.Size(141, 160);
            this.aktKorisnici.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aktivni korisnici:";
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Location = new System.Drawing.Point(13, 235);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(104, 13);
            this.lblKorisnik.TabIndex = 5;
            this.lblKorisnik.Text = "Vaše korisničko ime:";
            // 
            // korIme
            // 
            this.korIme.AutoSize = true;
            this.korIme.ForeColor = System.Drawing.Color.Red;
            this.korIme.Location = new System.Drawing.Point(124, 235);
            this.korIme.Name = "korIme";
            this.korIme.Size = new System.Drawing.Size(23, 13);
            this.korIme.TabIndex = 6;
            this.korIme.Text = "ime";
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(541, 352);
            this.Controls.Add(this.korIme);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aktKorisnici);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.txtUpis);
            this.Controls.Add(this.txtIspis);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatForm_FormClosed);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.TextBox txtUpis;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.ListBox aktKorisnici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.Label korIme;
    }
}