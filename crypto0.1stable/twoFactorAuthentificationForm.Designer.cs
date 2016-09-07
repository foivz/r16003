namespace crypto0._1stable
{
    partial class twoFactorAuthentificationForm
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
            this.lblProvjera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProvjera
            // 
            this.lblProvjera.AutoSize = true;
            this.lblProvjera.Location = new System.Drawing.Point(63, 30);
            this.lblProvjera.Name = "lblProvjera";
            this.lblProvjera.Size = new System.Drawing.Size(35, 13);
            this.lblProvjera.TabIndex = 0;
            this.lblProvjera.Text = "label1";
            // 
            // twoFactorAuthentificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 102);
            this.Controls.Add(this.lblProvjera);
            this.Name = "twoFactorAuthentificationForm";
            this.Text = "twoFactorAuthentificationForm";
            this.Load += new System.EventHandler(this.twoFactorAuthentificationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProvjera;
    }
}