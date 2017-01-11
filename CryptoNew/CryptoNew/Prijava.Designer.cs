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
            this.SuspendLayout();
            // 
            // unosUsername
            // 
            this.unosUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unosUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unosUsername.Location = new System.Drawing.Point(12, 243);
            this.unosUsername.Name = "unosUsername";
            this.unosUsername.Size = new System.Drawing.Size(510, 26);
            this.unosUsername.TabIndex = 0;
            // 
            // unosPassword
            // 
            this.unosPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unosPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unosPassword.Location = new System.Drawing.Point(12, 305);
            this.unosPassword.Name = "unosPassword";
            this.unosPassword.Size = new System.Drawing.Size(510, 26);
            this.unosPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 220);
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
            this.label2.Location = new System.Drawing.Point(12, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lozinka: ";
            // 
            // gumbLogin
            // 
            this.gumbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gumbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbLogin.Location = new System.Drawing.Point(218, 337);
            this.gumbLogin.Name = "gumbLogin";
            this.gumbLogin.Size = new System.Drawing.Size(115, 41);
            this.gumbLogin.TabIndex = 4;
            this.gumbLogin.Text = "Login";
            this.gumbLogin.UseVisualStyleBackColor = true;
            this.gumbLogin.Click += new System.EventHandler(this.gumbLogin_Click);
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(534, 410);
            this.Controls.Add(this.gumbLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unosPassword);
            this.Controls.Add(this.unosUsername);
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
    }
}