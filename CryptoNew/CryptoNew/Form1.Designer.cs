﻿namespace CryptoNew
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
            this.glavniPanel = new System.Windows.Forms.Panel();
            this.gumbGlavni = new System.Windows.Forms.Button();
            this.gumbLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // glavniPanel
            // 
            this.glavniPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glavniPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.glavniPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.glavniPanel.Location = new System.Drawing.Point(161, 12);
            this.glavniPanel.Name = "glavniPanel";
            this.glavniPanel.Size = new System.Drawing.Size(686, 468);
            this.glavniPanel.TabIndex = 1;
            this.glavniPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.glavniPanel_Paint);
            // 
            // gumbGlavni
            // 
            this.gumbGlavni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbGlavni.Location = new System.Drawing.Point(12, 30);
            this.gumbGlavni.Name = "gumbGlavni";
            this.gumbGlavni.Size = new System.Drawing.Size(143, 32);
            this.gumbGlavni.TabIndex = 2;
            this.gumbGlavni.Text = "Glavni prozor";
            this.gumbGlavni.UseVisualStyleBackColor = true;
            this.gumbGlavni.Click += new System.EventHandler(this.gumbGlavni_Click);
            // 
            // gumbLogout
            // 
            this.gumbLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbLogout.Location = new System.Drawing.Point(12, 68);
            this.gumbLogout.Name = "gumbLogout";
            this.gumbLogout.Size = new System.Drawing.Size(143, 32);
            this.gumbLogout.TabIndex = 3;
            this.gumbLogout.Text = "Logout";
            this.gumbLogout.UseVisualStyleBackColor = true;
            this.gumbLogout.Click += new System.EventHandler(this.gumbLogout_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "F5 - Refresh Prozora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gumbLogout);
            this.Controls.Add(this.gumbGlavni);
            this.Controls.Add(this.glavniPanel);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(785, 531);
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
    }
}
