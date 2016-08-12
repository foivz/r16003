namespace crypto0._1stable
{
    partial class frmCrypto
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.btnC2C = new System.Windows.Forms.Button();
            this.btnFreeCrypto = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.lblPrijavljen = new System.Windows.Forms.Label();
            this.lblPristup = new System.Windows.Forms.Label();
            this.updateProfil = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(30, 106);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 75);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Location = new System.Drawing.Point(148, 106);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(100, 75);
            this.btnRegistracija.TabIndex = 1;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // btnC2C
            // 
            this.btnC2C.Enabled = false;
            this.btnC2C.Location = new System.Drawing.Point(148, 205);
            this.btnC2C.Name = "btnC2C";
            this.btnC2C.Size = new System.Drawing.Size(100, 75);
            this.btnC2C.TabIndex = 2;
            this.btnC2C.Text = "C2C";
            this.btnC2C.UseVisualStyleBackColor = true;
            this.btnC2C.Click += new System.EventHandler(this.btnC2C_Click);
            // 
            // btnFreeCrypto
            // 
            this.btnFreeCrypto.Location = new System.Drawing.Point(30, 205);
            this.btnFreeCrypto.Name = "btnFreeCrypto";
            this.btnFreeCrypto.Size = new System.Drawing.Size(100, 75);
            this.btnFreeCrypto.TabIndex = 3;
            this.btnFreeCrypto.Text = "Free Crypto";
            this.btnFreeCrypto.UseVisualStyleBackColor = true;
            this.btnFreeCrypto.Click += new System.EventHandler(this.btnFreeCrypto_Click);
            // 
            // btnChat
            // 
            this.btnChat.Enabled = false;
            this.btnChat.Location = new System.Drawing.Point(267, 205);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(100, 75);
            this.btnChat.TabIndex = 4;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // lblPrijavljen
            // 
            this.lblPrijavljen.AutoSize = true;
            this.lblPrijavljen.Location = new System.Drawing.Point(337, 25);
            this.lblPrijavljen.Name = "lblPrijavljen";
            this.lblPrijavljen.Size = new System.Drawing.Size(92, 13);
            this.lblPrijavljen.TabIndex = 5;
            this.lblPrijavljen.Text = "Prijavljeni ste kao:";
            // 
            // lblPristup
            // 
            this.lblPristup.AutoSize = true;
            this.lblPristup.Location = new System.Drawing.Point(436, 25);
            this.lblPristup.Name = "lblPristup";
            this.lblPristup.Size = new System.Drawing.Size(0, 13);
            this.lblPristup.TabIndex = 6;
            // 
            // updateProfil
            // 
            this.updateProfil.Enabled = false;
            this.updateProfil.Location = new System.Drawing.Point(267, 106);
            this.updateProfil.Name = "updateProfil";
            this.updateProfil.Size = new System.Drawing.Size(100, 75);
            this.updateProfil.TabIndex = 7;
            this.updateProfil.Text = "Ažuriranje profila";
            this.updateProfil.UseVisualStyleBackColor = true;
            this.updateProfil.Click += new System.EventHandler(this.updateProfil_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(373, 154);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(100, 75);
            this.btnAdmin.TabIndex = 8;
            this.btnAdmin.Text = "Admin Panel";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // frmCrypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 317);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.updateProfil);
            this.Controls.Add(this.lblPristup);
            this.Controls.Add(this.lblPrijavljen);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.btnFreeCrypto);
            this.Controls.Add(this.btnC2C);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmCrypto";
            this.Text = "Crypto";
            this.Load += new System.EventHandler(this.frmCrypto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Button btnC2C;
        private System.Windows.Forms.Button btnFreeCrypto;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Label lblPrijavljen;
        private System.Windows.Forms.Label lblPristup;
        private System.Windows.Forms.Button updateProfil;
        private System.Windows.Forms.Button btnAdmin;
    }
}

