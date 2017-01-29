namespace CryptoNew
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.glavniPanel = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.gumbSlanje = new System.Windows.Forms.Button();
            this.gumbLokalno = new System.Windows.Forms.Button();
            this.gumbLogout = new System.Windows.Forms.Button();
            this.gumbGlavni = new System.Windows.Forms.Button();
            this.gumbPregledPoruka = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarTipKorisnika = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerVrijeme = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // glavniPanel
            // 
            this.glavniPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glavniPanel.AutoScroll = true;
            this.glavniPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.glavniPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.glavniPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.glavniPanel.Location = new System.Drawing.Point(161, 12);
            this.glavniPanel.Name = "glavniPanel";
            this.glavniPanel.Size = new System.Drawing.Size(787, 640);
            this.glavniPanel.TabIndex = 1;
            this.glavniPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.glavniPanel_Paint);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Paomedia-Small-N-Flat-Key.ico");
            this.imageList1.Images.SetKeyName(1, "Custom-Icon-Design-Pretty-Office-11-Logout.ico");
            this.imageList1.Images.SetKeyName(2, "Hopstarter-Sleek-Xp-Basic-Home.ico");
            this.imageList1.Images.SetKeyName(3, "send.ico");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 631);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "F5 - Refresh Prozora";
            // 
            // gumbSlanje
            // 
            this.gumbSlanje.Enabled = false;
            this.gumbSlanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbSlanje.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gumbSlanje.ImageIndex = 3;
            this.gumbSlanje.ImageList = this.imageList1;
            this.gumbSlanje.Location = new System.Drawing.Point(12, 156);
            this.gumbSlanje.Name = "gumbSlanje";
            this.gumbSlanje.Size = new System.Drawing.Size(143, 59);
            this.gumbSlanje.TabIndex = 9;
            this.gumbSlanje.Text = "Slanje Poruka";
            this.gumbSlanje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gumbSlanje.UseVisualStyleBackColor = true;
            this.gumbSlanje.Click += new System.EventHandler(this.gumbSlanje_Click);
            // 
            // gumbLokalno
            // 
            this.gumbLokalno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbLokalno.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gumbLokalno.ImageIndex = 0;
            this.gumbLokalno.ImageList = this.imageList1;
            this.gumbLokalno.Location = new System.Drawing.Point(12, 91);
            this.gumbLokalno.Name = "gumbLokalno";
            this.gumbLokalno.Size = new System.Drawing.Size(143, 59);
            this.gumbLokalno.TabIndex = 7;
            this.gumbLokalno.Text = "Lokalna Enkripcija";
            this.gumbLokalno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gumbLokalno.UseVisualStyleBackColor = true;
            this.gumbLokalno.Click += new System.EventHandler(this.gumbLokalno_Click);
            // 
            // gumbLogout
            // 
            this.gumbLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gumbLogout.ImageIndex = 1;
            this.gumbLogout.ImageList = this.imageList1;
            this.gumbLogout.Location = new System.Drawing.Point(12, 286);
            this.gumbLogout.Name = "gumbLogout";
            this.gumbLogout.Size = new System.Drawing.Size(143, 59);
            this.gumbLogout.TabIndex = 3;
            this.gumbLogout.Text = "Logout";
            this.gumbLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gumbLogout.UseVisualStyleBackColor = true;
            this.gumbLogout.Click += new System.EventHandler(this.gumbLogout_Click);
            // 
            // gumbGlavni
            // 
            this.gumbGlavni.Cursor = System.Windows.Forms.Cursors.Default;
            this.gumbGlavni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbGlavni.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gumbGlavni.ImageIndex = 2;
            this.gumbGlavni.ImageList = this.imageList1;
            this.gumbGlavni.Location = new System.Drawing.Point(12, 30);
            this.gumbGlavni.Name = "gumbGlavni";
            this.gumbGlavni.Size = new System.Drawing.Size(143, 55);
            this.gumbGlavni.TabIndex = 2;
            this.gumbGlavni.Text = "Glavni prozor";
            this.gumbGlavni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gumbGlavni.UseVisualStyleBackColor = true;
            this.gumbGlavni.Click += new System.EventHandler(this.gumbGlavni_Click);
            // 
            // gumbPregledPoruka
            // 
            this.gumbPregledPoruka.Enabled = false;
            this.gumbPregledPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbPregledPoruka.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gumbPregledPoruka.ImageIndex = 3;
            this.gumbPregledPoruka.ImageList = this.imageList1;
            this.gumbPregledPoruka.Location = new System.Drawing.Point(12, 221);
            this.gumbPregledPoruka.Name = "gumbPregledPoruka";
            this.gumbPregledPoruka.Size = new System.Drawing.Size(143, 59);
            this.gumbPregledPoruka.TabIndex = 11;
            this.gumbPregledPoruka.Text = "Pregled Poruka";
            this.gumbPregledPoruka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gumbPregledPoruka.UseVisualStyleBackColor = true;
            this.gumbPregledPoruka.Click += new System.EventHandler(this.gumbPregledPoruka_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusBarUsername,
            this.toolStripSplitButton1,
            this.toolStripStatusLabel3,
            this.statusBarTipKorisnika,
            this.toolStripStatusLabel6,
            this.toolStripSplitButton2,
            this.toolStripStatusLabel5,
            this.statusTimer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 655);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(960, 24);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 19);
            this.toolStripStatusLabel1.Text = "Username:";
            // 
            // statusBarUsername
            // 
            this.statusBarUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusBarUsername.Name = "statusBarUsername";
            this.statusBarUsername.Size = new System.Drawing.Size(38, 19);
            this.statusBarUsername.Text = "Gost";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripSplitButton1.Enabled = false;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(16, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(100, 19);
            this.toolStripStatusLabel3.Text = "Tip Korisnika:";
            // 
            // statusBarTipKorisnika
            // 
            this.statusBarTipKorisnika.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusBarTipKorisnika.Name = "statusBarTipKorisnika";
            this.statusBarTipKorisnika.Size = new System.Drawing.Size(38, 19);
            this.statusBarTipKorisnika.Text = "Gost";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(518, 19);
            this.toolStripStatusLabel6.Spring = true;
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripSplitButton2.Enabled = false;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(16, 22);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(65, 19);
            this.toolStripStatusLabel5.Text = "Vrijeme:";
            // 
            // statusTimer
            // 
            this.statusTimer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusTimer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statusTimer.Name = "statusTimer";
            this.statusTimer.Size = new System.Drawing.Size(43, 19);
            this.statusTimer.Text = "Timer";
            // 
            // timerVrijeme
            // 
            this.timerVrijeme.Enabled = true;
            this.timerVrijeme.Interval = 1000;
            this.timerVrijeme.Tick += new System.EventHandler(this.timerVrijeme_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(960, 679);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gumbPregledPoruka);
            this.Controls.Add(this.gumbSlanje);
            this.Controls.Add(this.gumbLokalno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gumbLogout);
            this.Controls.Add(this.gumbGlavni);
            this.Controls.Add(this.glavniPanel);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(976, 700);
            this.Name = "Form1";
            this.Text = "Aplikacija Crypto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel glavniPanel;
        private System.Windows.Forms.Button gumbGlavni;
        private System.Windows.Forms.Button gumbLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button gumbLokalno;
        private System.Windows.Forms.Button gumbSlanje;
        private System.Windows.Forms.Button gumbPregledPoruka;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusBarUsername;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel statusBarTipKorisnika;
        private System.Windows.Forms.ToolStripStatusLabel statusTimer;
        private System.Windows.Forms.Timer timerVrijeme;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
    }
}

