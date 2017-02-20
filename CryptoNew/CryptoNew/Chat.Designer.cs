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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIspis
            // 
            this.txtIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIspis.Location = new System.Drawing.Point(30, 62);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIspis.Size = new System.Drawing.Size(299, 192);
            this.txtIspis.TabIndex = 0;
            // 
            // aktivniKorisnici
            // 
            this.aktivniKorisnici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aktivniKorisnici.Location = new System.Drawing.Point(346, 62);
            this.aktivniKorisnici.Multiline = true;
            this.aktivniKorisnici.Name = "aktivniKorisnici";
            this.aktivniKorisnici.Size = new System.Drawing.Size(174, 192);
            this.aktivniKorisnici.TabIndex = 1;
            // 
            // txtUpis
            // 
            this.txtUpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUpis.Location = new System.Drawing.Point(30, 282);
            this.txtUpis.Name = "txtUpis";
            this.txtUpis.Size = new System.Drawing.Size(299, 26);
            this.txtUpis.TabIndex = 2;
            // 
            // btnPosalji
            // 
            this.btnPosalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPosalji.Location = new System.Drawing.Point(346, 260);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(174, 48);
            this.btnPosalji.TabIndex = 3;
            this.btnPosalji.Text = "Send";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(342, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista aktivnih korisnika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(26, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Poruka:";
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 397);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}