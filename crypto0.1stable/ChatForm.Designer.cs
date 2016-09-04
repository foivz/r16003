namespace crypto0._1stable
{
    partial class ChatForm
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
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.txtUpis = new System.Windows.Forms.TextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(53, 24);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(598, 173);
            this.txtIspis.TabIndex = 0;
            // 
            // txtUpis
            // 
            this.txtUpis.Location = new System.Drawing.Point(53, 258);
            this.txtUpis.Name = "txtUpis";
            this.txtUpis.Size = new System.Drawing.Size(414, 20);
            this.txtUpis.TabIndex = 1;
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(510, 225);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(141, 53);
            this.btnPosalji.TabIndex = 2;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 330);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.txtUpis);
            this.Controls.Add(this.txtIspis);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.TextBox txtUpis;
        private System.Windows.Forms.Button btnPosalji;
    }
}