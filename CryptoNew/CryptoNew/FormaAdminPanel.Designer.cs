namespace CryptoNew
{
    partial class FormaAdminPanel
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
            this.tabKontrolaAdmin = new System.Windows.Forms.TabControl();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.tablicaKorisnici = new System.Windows.Forms.DataGridView();
            this.tabAdminMail = new System.Windows.Forms.TabPage();
            this.gumbPosalji = new System.Windows.Forms.Button();
            this.unosPoruka = new System.Windows.Forms.TextBox();
            this.prikazLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabKontrolaAdmin.SuspendLayout();
            this.tabStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablicaKorisnici)).BeginInit();
            this.tabAdminMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabKontrolaAdmin
            // 
            this.tabKontrolaAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabKontrolaAdmin.Controls.Add(this.tabStatus);
            this.tabKontrolaAdmin.Controls.Add(this.tabAdminMail);
            this.tabKontrolaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabKontrolaAdmin.Location = new System.Drawing.Point(12, 12);
            this.tabKontrolaAdmin.Name = "tabKontrolaAdmin";
            this.tabKontrolaAdmin.SelectedIndex = 0;
            this.tabKontrolaAdmin.Size = new System.Drawing.Size(627, 408);
            this.tabKontrolaAdmin.TabIndex = 0;
            this.tabKontrolaAdmin.SelectedIndexChanged += new System.EventHandler(this.tabKontrolaAdmin_SelectedIndexChanged);
            // 
            // tabStatus
            // 
            this.tabStatus.Controls.Add(this.tablicaKorisnici);
            this.tabStatus.Location = new System.Drawing.Point(4, 29);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatus.Size = new System.Drawing.Size(619, 375);
            this.tabStatus.TabIndex = 0;
            this.tabStatus.Text = "Upravljanje Statusom računa";
            this.tabStatus.UseVisualStyleBackColor = true;
            // 
            // tablicaKorisnici
            // 
            this.tablicaKorisnici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablicaKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablicaKorisnici.Location = new System.Drawing.Point(6, 6);
            this.tablicaKorisnici.Name = "tablicaKorisnici";
            this.tablicaKorisnici.Size = new System.Drawing.Size(607, 363);
            this.tablicaKorisnici.TabIndex = 0;
            this.tablicaKorisnici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablicaKorisnici_CellClick);
            // 
            // tabAdminMail
            // 
            this.tabAdminMail.Controls.Add(this.label1);
            this.tabAdminMail.Controls.Add(this.prikazLog);
            this.tabAdminMail.Controls.Add(this.gumbPosalji);
            this.tabAdminMail.Controls.Add(this.unosPoruka);
            this.tabAdminMail.Location = new System.Drawing.Point(4, 29);
            this.tabAdminMail.Name = "tabAdminMail";
            this.tabAdminMail.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminMail.Size = new System.Drawing.Size(619, 375);
            this.tabAdminMail.TabIndex = 1;
            this.tabAdminMail.Text = "Slanje Admin maila";
            this.tabAdminMail.UseVisualStyleBackColor = true;
            // 
            // gumbPosalji
            // 
            this.gumbPosalji.Location = new System.Drawing.Point(6, 339);
            this.gumbPosalji.Name = "gumbPosalji";
            this.gumbPosalji.Size = new System.Drawing.Size(392, 30);
            this.gumbPosalji.TabIndex = 1;
            this.gumbPosalji.Text = "Pošalji";
            this.gumbPosalji.UseVisualStyleBackColor = true;
            this.gumbPosalji.Click += new System.EventHandler(this.gumbPosalji_Click);
            // 
            // unosPoruka
            // 
            this.unosPoruka.Location = new System.Drawing.Point(6, 6);
            this.unosPoruka.Multiline = true;
            this.unosPoruka.Name = "unosPoruka";
            this.unosPoruka.Size = new System.Drawing.Size(392, 327);
            this.unosPoruka.TabIndex = 0;
            // 
            // prikazLog
            // 
            this.prikazLog.Location = new System.Drawing.Point(404, 32);
            this.prikazLog.Multiline = true;
            this.prikazLog.Name = "prikazLog";
            this.prikazLog.ReadOnly = true;
            this.prikazLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.prikazLog.Size = new System.Drawing.Size(209, 337);
            this.prikazLog.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log:";
            // 
            // FormaAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 432);
            this.Controls.Add(this.tabKontrolaAdmin);
            this.Name = "FormaAdminPanel";
            this.Text = "Admin Panel";
            this.tabKontrolaAdmin.ResumeLayout(false);
            this.tabStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablicaKorisnici)).EndInit();
            this.tabAdminMail.ResumeLayout(false);
            this.tabAdminMail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabKontrolaAdmin;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.TabPage tabAdminMail;
        private System.Windows.Forms.DataGridView tablicaKorisnici;
        private System.Windows.Forms.Button gumbPosalji;
        private System.Windows.Forms.TextBox unosPoruka;
        private System.Windows.Forms.TextBox prikazLog;
        private System.Windows.Forms.Label label1;
    }
}