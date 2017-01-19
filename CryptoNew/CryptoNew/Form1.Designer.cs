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
            this.gumbGlavni = new System.Windows.Forms.Button();
            this.gumbLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // glavniPanel
            // 
            this.glavniPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glavniPanel.AutoScroll = true;
            this.glavniPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.glavniPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.glavniPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.glavniPanel.Location = new System.Drawing.Point(161, 12);
            this.glavniPanel.Name = "glavniPanel";
            this.glavniPanel.Size = new System.Drawing.Size(611, 537);
            this.glavniPanel.TabIndex = 1;
            this.glavniPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.glavniPanel_Paint);
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
            // gumbLogout
            // 
            this.gumbLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gumbLogout.ImageIndex = 1;
            this.gumbLogout.ImageList = this.imageList1;
            this.gumbLogout.Location = new System.Drawing.Point(12, 91);
            this.gumbLogout.Name = "gumbLogout";
            this.gumbLogout.Size = new System.Drawing.Size(143, 59);
            this.gumbLogout.TabIndex = 3;
            this.gumbLogout.Text = "Logout";
            this.gumbLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gumbLogout.UseVisualStyleBackColor = true;
            this.gumbLogout.Click += new System.EventHandler(this.gumbLogout_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "F5 - Refresh Prozora";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Paomedia-Small-N-Flat-Key.ico");
            this.imageList1.Images.SetKeyName(1, "Custom-Icon-Design-Pretty-Office-11-Logout.ico");
            this.imageList1.Images.SetKeyName(2, "Hopstarter-Sleek-Xp-Basic-Home.ico");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gumbLogout);
            this.Controls.Add(this.gumbGlavni);
            this.Controls.Add(this.glavniPanel);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Aplikacija Crypto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel glavniPanel;
        private System.Windows.Forms.Button gumbGlavni;
        private System.Windows.Forms.Button gumbLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

