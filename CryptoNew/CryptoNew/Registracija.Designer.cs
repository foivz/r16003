﻿namespace CryptoNew
{
    partial class Registracija
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.unosUsername = new System.Windows.Forms.TextBox();
            this.unosIme = new System.Windows.Forms.TextBox();
            this.unosPrezime = new System.Windows.Forms.TextBox();
            this.unosEmail = new System.Windows.Forms.TextBox();
            this.unosTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.unosPassword = new System.Windows.Forms.TextBox();
            this.gumbRegistracija = new System.Windows.Forms.Button();
            this.unosGodina = new System.Windows.Forms.ComboBox();
            this.unosMjesec = new System.Windows.Forms.ComboBox();
            this.unosDan = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.check2FA = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(178, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(178, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(178, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(178, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(178, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum rođenja(godina, mjesec, dan):";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(178, 551);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Broj telefona: ";
            // 
            // unosUsername
            // 
            this.unosUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unosUsername.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.unosUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unosUsername.Location = new System.Drawing.Point(182, 256);
            this.unosUsername.Name = "unosUsername";
            this.unosUsername.Size = new System.Drawing.Size(533, 26);
            this.unosUsername.TabIndex = 6;
            this.unosUsername.Validating += new System.ComponentModel.CancelEventHandler(this.unosUsername_Validating);
            // 
            // unosIme
            // 
            this.unosIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unosIme.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.unosIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unosIme.Location = new System.Drawing.Point(182, 366);
            this.unosIme.Name = "unosIme";
            this.unosIme.Size = new System.Drawing.Size(533, 26);
            this.unosIme.TabIndex = 7;
            // 
            // unosPrezime
            // 
            this.unosPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unosPrezime.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.unosPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unosPrezime.Location = new System.Drawing.Point(182, 418);
            this.unosPrezime.Name = "unosPrezime";
            this.unosPrezime.Size = new System.Drawing.Size(533, 26);
            this.unosPrezime.TabIndex = 8;
            // 
            // unosEmail
            // 
            this.unosEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unosEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.unosEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unosEmail.Location = new System.Drawing.Point(182, 470);
            this.unosEmail.Name = "unosEmail";
            this.unosEmail.Size = new System.Drawing.Size(533, 26);
            this.unosEmail.TabIndex = 9;
            this.unosEmail.TextChanged += new System.EventHandler(this.unosEmail_TextChanged);
            this.unosEmail.Validating += new System.ComponentModel.CancelEventHandler(this.unosEmail_Validating);
            // 
            // unosTelefon
            // 
            this.unosTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unosTelefon.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.unosTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unosTelefon.Location = new System.Drawing.Point(234, 580);
            this.unosTelefon.Name = "unosTelefon";
            this.unosTelefon.Size = new System.Drawing.Size(481, 26);
            this.unosTelefon.TabIndex = 11;
            this.unosTelefon.TextChanged += new System.EventHandler(this.unosTelefon_TextChanged);
            this.unosTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.unosTelefon_Validating);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(178, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lozinka:";
            // 
            // unosPassword
            // 
            this.unosPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unosPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.unosPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unosPassword.Location = new System.Drawing.Point(182, 308);
            this.unosPassword.Name = "unosPassword";
            this.unosPassword.Size = new System.Drawing.Size(533, 26);
            this.unosPassword.TabIndex = 13;
            this.unosPassword.TextChanged += new System.EventHandler(this.unosPassword_TextChanged);
            this.unosPassword.Validating += new System.ComponentModel.CancelEventHandler(this.unosPassword_Validating);
            // 
            // gumbRegistracija
            // 
            this.gumbRegistracija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gumbRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbRegistracija.Location = new System.Drawing.Point(182, 657);
            this.gumbRegistracija.Name = "gumbRegistracija";
            this.gumbRegistracija.Size = new System.Drawing.Size(222, 36);
            this.gumbRegistracija.TabIndex = 14;
            this.gumbRegistracija.Text = "Registriraj se";
            this.gumbRegistracija.UseVisualStyleBackColor = true;
            this.gumbRegistracija.Click += new System.EventHandler(this.gumbRegistracija_Click);
            // 
            // unosGodina
            // 
            this.unosGodina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unosGodina.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.unosGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unosGodina.FormattingEnabled = true;
            this.unosGodina.Location = new System.Drawing.Point(182, 523);
            this.unosGodina.Name = "unosGodina";
            this.unosGodina.Size = new System.Drawing.Size(121, 28);
            this.unosGodina.TabIndex = 15;
            this.unosGodina.SelectedIndexChanged += new System.EventHandler(this.unosGodina_SelectedIndexChanged);
            this.unosGodina.Validating += new System.ComponentModel.CancelEventHandler(this.unosGodina_Validating);
            // 
            // unosMjesec
            // 
            this.unosMjesec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unosMjesec.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.unosMjesec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unosMjesec.FormattingEnabled = true;
            this.unosMjesec.Location = new System.Drawing.Point(309, 523);
            this.unosMjesec.Name = "unosMjesec";
            this.unosMjesec.Size = new System.Drawing.Size(121, 28);
            this.unosMjesec.TabIndex = 16;
            this.unosMjesec.SelectedIndexChanged += new System.EventHandler(this.unosMjesec_SelectedIndexChanged);
            this.unosMjesec.Validating += new System.ComponentModel.CancelEventHandler(this.unosMjesec_Validating);
            // 
            // unosDan
            // 
            this.unosDan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unosDan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.unosDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unosDan.FormattingEnabled = true;
            this.unosDan.Location = new System.Drawing.Point(436, 523);
            this.unosDan.Name = "unosDan";
            this.unosDan.Size = new System.Drawing.Size(121, 28);
            this.unosDan.TabIndex = 17;
            this.unosDan.Validating += new System.ComponentModel.CancelEventHandler(this.unosDan_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(182, 624);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(323, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Želite li omogućiti 2FA verifikaciju računa?";
            // 
            // check2FA
            // 
            this.check2FA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check2FA.AutoSize = true;
            this.check2FA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.check2FA.Location = new System.Drawing.Point(511, 624);
            this.check2FA.Name = "check2FA";
            this.check2FA.Size = new System.Drawing.Size(52, 24);
            this.check2FA.TabIndex = 19;
            this.check2FA.Text = "DA";
            this.check2FA.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(182, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 27);
            this.button1.TabIndex = 20;
            this.button1.Text = "+385";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(879, 865);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.check2FA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.unosDan);
            this.Controls.Add(this.unosMjesec);
            this.Controls.Add(this.unosGodina);
            this.Controls.Add(this.gumbRegistracija);
            this.Controls.Add(this.unosPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.unosTelefon);
            this.Controls.Add(this.unosEmail);
            this.Controls.Add(this.unosPrezime);
            this.Controls.Add(this.unosIme);
            this.Controls.Add(this.unosUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registracija";
            this.Text = "Registracija";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox unosUsername;
        private System.Windows.Forms.TextBox unosIme;
        private System.Windows.Forms.TextBox unosPrezime;
        private System.Windows.Forms.TextBox unosEmail;
        private System.Windows.Forms.TextBox unosTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox unosPassword;
        private System.Windows.Forms.Button gumbRegistracija;
        private System.Windows.Forms.ComboBox unosGodina;
        private System.Windows.Forms.ComboBox unosMjesec;
        private System.Windows.Forms.ComboBox unosDan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox check2FA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}