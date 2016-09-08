namespace crypto0._1stable
{
    partial class EncryptOrDecrypt
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
            this.button1 = new System.Windows.Forms.Button();
            this.radbtnEncrypt = new System.Windows.Forms.RadioButton();
            this.radbtnDecrypt = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radbtnText = new System.Windows.Forms.RadioButton();
            this.radbtnDatoteka = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radbtnEncrypt
            // 
            this.radbtnEncrypt.AutoSize = true;
            this.radbtnEncrypt.Checked = true;
            this.radbtnEncrypt.Location = new System.Drawing.Point(6, 19);
            this.radbtnEncrypt.Name = "radbtnEncrypt";
            this.radbtnEncrypt.Size = new System.Drawing.Size(61, 17);
            this.radbtnEncrypt.TabIndex = 3;
            this.radbtnEncrypt.TabStop = true;
            this.radbtnEncrypt.Text = "Encrypt";
            this.radbtnEncrypt.UseVisualStyleBackColor = true;
            // 
            // radbtnDecrypt
            // 
            this.radbtnDecrypt.AutoSize = true;
            this.radbtnDecrypt.Location = new System.Drawing.Point(135, 19);
            this.radbtnDecrypt.Name = "radbtnDecrypt";
            this.radbtnDecrypt.Size = new System.Drawing.Size(62, 17);
            this.radbtnDecrypt.TabIndex = 4;
            this.radbtnDecrypt.Text = "Decrypt";
            this.radbtnDecrypt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radbtnDecrypt);
            this.groupBox1.Controls.Add(this.radbtnEncrypt);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 47);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encrypt ili Decrypt?";
            // 
            // radbtnText
            // 
            this.radbtnText.AutoSize = true;
            this.radbtnText.Checked = true;
            this.radbtnText.Location = new System.Drawing.Point(12, 18);
            this.radbtnText.Name = "radbtnText";
            this.radbtnText.Size = new System.Drawing.Size(46, 17);
            this.radbtnText.TabIndex = 6;
            this.radbtnText.TabStop = true;
            this.radbtnText.Text = "Text";
            this.radbtnText.UseVisualStyleBackColor = true;
            // 
            // radbtnDatoteka
            // 
            this.radbtnDatoteka.AutoSize = true;
            this.radbtnDatoteka.Location = new System.Drawing.Point(124, 18);
            this.radbtnDatoteka.Name = "radbtnDatoteka";
            this.radbtnDatoteka.Size = new System.Drawing.Size(69, 17);
            this.radbtnDatoteka.TabIndex = 7;
            this.radbtnDatoteka.Text = "Datoteka";
            this.radbtnDatoteka.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radbtnDatoteka);
            this.groupBox2.Controls.Add(this.radbtnText);
            this.groupBox2.Location = new System.Drawing.Point(22, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 46);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text ili Datoteka?";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Key:";
            // 
            // EncryptOrDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 223);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "EncryptOrDecrypt";
            this.Text = "EncryptOrDecrypt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radbtnEncrypt;
        private System.Windows.Forms.RadioButton radbtnDecrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radbtnText;
        private System.Windows.Forms.RadioButton radbtnDatoteka;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}