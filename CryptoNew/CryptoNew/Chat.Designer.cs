namespace CryptoNew
{
    partial class Chat
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
            this.aktivniKorisnici = new System.Windows.Forms.TextBox();
            this.txtUpis = new System.Windows.Forms.TextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(29, 32);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(299, 192);
            this.txtIspis.TabIndex = 0;
            // 
            // aktivniKorisnici
            // 
            this.aktivniKorisnici.Location = new System.Drawing.Point(346, 32);
            this.aktivniKorisnici.Multiline = true;
            this.aktivniKorisnici.Name = "aktivniKorisnici";
            this.aktivniKorisnici.Size = new System.Drawing.Size(121, 192);
            this.aktivniKorisnici.TabIndex = 1;
            // 
            // txtUpis
            // 
            this.txtUpis.Location = new System.Drawing.Point(29, 265);
            this.txtUpis.Name = "txtUpis";
            this.txtUpis.Size = new System.Drawing.Size(299, 20);
            this.txtUpis.TabIndex = 2;
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(356, 237);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(96, 48);
            this.btnPosalji.TabIndex = 3;
            this.btnPosalji.Text = "Send";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 333);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.txtUpis);
            this.Controls.Add(this.aktivniKorisnici);
            this.Controls.Add(this.txtIspis);
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.TextBox aktivniKorisnici;
        private System.Windows.Forms.TextBox txtUpis;
        private System.Windows.Forms.Button btnPosalji;
    }
}