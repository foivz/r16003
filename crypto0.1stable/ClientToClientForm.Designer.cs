namespace crypto0._1stable
{
    partial class ClientToClientForm
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
            this.btnPristigle = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPristigle
            // 
            this.btnPristigle.Location = new System.Drawing.Point(39, 12);
            this.btnPristigle.Name = "btnPristigle";
            this.btnPristigle.Size = new System.Drawing.Size(151, 66);
            this.btnPristigle.TabIndex = 0;
            this.btnPristigle.Text = "Pristigle poruke";
            this.btnPristigle.UseVisualStyleBackColor = true;
            this.btnPristigle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(284, 12);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(144, 66);
            this.btnPosalji.TabIndex = 1;
            this.btnPosalji.Text = "Posalji poruku";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(39, 108);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(151, 73);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "Pristigle datoteke";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // ClientToClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 248);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.btnPristigle);
            this.Name = "ClientToClientForm";
            this.Text = "ClientToClientForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPristigle;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Button btnFile;
    }
}