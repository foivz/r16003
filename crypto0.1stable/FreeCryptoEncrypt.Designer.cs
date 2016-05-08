namespace crypto0._1stable
{
    partial class FreeCryptoEncrypt
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
            this.txtText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModified = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExporttxt = new System.Windows.Forms.Button();
            this.txtCaesarKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAesKey = new System.Windows.Forms.Label();
            this.lblAesIV = new System.Windows.Forms.Label();
            this.btnAesEncrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(12, 77);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(760, 176);
            this.txtText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter text:";
            // 
            // txtModified
            // 
            this.txtModified.Location = new System.Drawing.Point(15, 344);
            this.txtModified.Multiline = true;
            this.txtModified.Name = "txtModified";
            this.txtModified.Size = new System.Drawing.Size(760, 144);
            this.txtModified.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modified text:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Caesar Ecrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExporttxt
            // 
            this.btnExporttxt.Location = new System.Drawing.Point(12, 495);
            this.btnExporttxt.Name = "btnExporttxt";
            this.btnExporttxt.Size = new System.Drawing.Size(168, 48);
            this.btnExporttxt.TabIndex = 6;
            this.btnExporttxt.Text = "Export to .txt";
            this.btnExporttxt.UseVisualStyleBackColor = true;
            this.btnExporttxt.Click += new System.EventHandler(this.btnExporttxt_Click);
            // 
            // txtCaesarKey
            // 
            this.txtCaesarKey.Location = new System.Drawing.Point(193, 274);
            this.txtCaesarKey.Name = "txtCaesarKey";
            this.txtCaesarKey.Size = new System.Drawing.Size(38, 20);
            this.txtCaesarKey.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Shift:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(604, 495);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 48);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAesKey
            // 
            this.lblAesKey.AutoSize = true;
            this.lblAesKey.Location = new System.Drawing.Point(398, 274);
            this.lblAesKey.Name = "lblAesKey";
            this.lblAesKey.Size = new System.Drawing.Size(28, 13);
            this.lblAesKey.TabIndex = 12;
            this.lblAesKey.Text = "Key:";
            // 
            // lblAesIV
            // 
            this.lblAesIV.AutoSize = true;
            this.lblAesIV.Location = new System.Drawing.Point(487, 274);
            this.lblAesIV.Name = "lblAesIV";
            this.lblAesIV.Size = new System.Drawing.Size(20, 13);
            this.lblAesIV.TabIndex = 13;
            this.lblAesIV.Text = "IV:";
            // 
            // btnAesEncrypt
            // 
            this.btnAesEncrypt.Location = new System.Drawing.Point(237, 259);
            this.btnAesEncrypt.Name = "btnAesEncrypt";
            this.btnAesEncrypt.Size = new System.Drawing.Size(135, 48);
            this.btnAesEncrypt.TabIndex = 15;
            this.btnAesEncrypt.Text = "AES Ecrypt";
            this.btnAesEncrypt.UseVisualStyleBackColor = true;
            this.btnAesEncrypt.Click += new System.EventHandler(this.btnAesEncrypt_Click);
            // 
            // FreeCryptoEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnAesEncrypt);
            this.Controls.Add(this.lblAesIV);
            this.Controls.Add(this.lblAesKey);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCaesarKey);
            this.Controls.Add(this.btnExporttxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModified);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtText);
            this.Name = "FreeCryptoEncrypt";
            this.Text = "FreeCrypto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModified;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExporttxt;
        private System.Windows.Forms.TextBox txtCaesarKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAesKey;
        private System.Windows.Forms.Label lblAesIV;
        private System.Windows.Forms.Button btnAesEncrypt;
    }
}