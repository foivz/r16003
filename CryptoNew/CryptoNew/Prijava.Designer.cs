namespace CryptoNew
{
    partial class Prijava
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
            this.unosUsername = new System.Windows.Forms.TextBox();
            this.unosPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gumbLogin = new System.Windows.Forms.Button();
            this.linkRegistracija = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // unosUsername
            // 
            this.unosUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unosUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unosUsername.Location = new System.Drawing.Point(123, 272);
            this.unosUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unosUsername.Name = "unosUsername";
            this.unosUsername.Size = new System.Drawing.Size(385, 26);
            this.unosUsername.TabIndex = 0;
            // 
            // unosPassword
            // 
            this.unosPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unosPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unosPassword.Location = new System.Drawing.Point(123, 326);
            this.unosPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unosPassword.Name = "unosPassword";
            this.unosPassword.Size = new System.Drawing.Size(385, 26);
            this.unosPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(119, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(119, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lozinka: ";
            // 
            // gumbLogin
            // 
            this.gumbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gumbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbLogin.Location = new System.Drawing.Point(243, 360);
            this.gumbLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gumbLogin.Name = "gumbLogin";
            this.gumbLogin.Size = new System.Drawing.Size(134, 48);
            this.gumbLogin.TabIndex = 4;
            this.gumbLogin.Text = "Login";
            this.gumbLogin.UseVisualStyleBackColor = true;
            this.gumbLogin.Click += new System.EventHandler(this.gumbLogin_Click);
            // 
            // linkRegistracija
            // 
            this.linkRegistracija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkRegistracija.AutoSize = true;
            this.linkRegistracija.Location = new System.Drawing.Point(209, 412);
            this.linkRegistracija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkRegistracija.Name = "linkRegistracija";
            this.linkRegistracija.Size = new System.Drawing.Size(207, 16);
            this.linkRegistracija.TabIndex = 6;
            this.linkRegistracija.TabStop = true;
            this.linkRegistracija.Text = "Niste registrirani? Registrirajte se!";
            this.linkRegistracija.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistracija_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.BackgroundImage = global::CryptoNew.Properties.Resources.user_icon_6;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(201, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 214);
            this.panel1.TabIndex = 5;
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(603, 455);
            this.Controls.Add(this.linkRegistracija);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gumbLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unosPassword);
            this.Controls.Add(this.unosUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unosUsername;
        private System.Windows.Forms.TextBox unosPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gumbLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkRegistracija;
    }
}