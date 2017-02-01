namespace CryptoNew
{
    partial class FormaDekriptiranaPoruka
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
            this.prikazEnkriptiran = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prikazDekriptiran = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prikazEnkriptiran
            // 
            this.prikazEnkriptiran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prikazEnkriptiran.Location = new System.Drawing.Point(12, 72);
            this.prikazEnkriptiran.Multiline = true;
            this.prikazEnkriptiran.Name = "prikazEnkriptiran";
            this.prikazEnkriptiran.Size = new System.Drawing.Size(553, 145);
            this.prikazEnkriptiran.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enkriptirana Poruka:";
            // 
            // prikazDekriptiran
            // 
            this.prikazDekriptiran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prikazDekriptiran.Location = new System.Drawing.Point(12, 263);
            this.prikazDekriptiran.Multiline = true;
            this.prikazDekriptiran.Name = "prikazDekriptiran";
            this.prikazDekriptiran.Size = new System.Drawing.Size(553, 180);
            this.prikazDekriptiran.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dekriptirana Poruka:";
            // 
            // FormaDekriptiranaPoruka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prikazDekriptiran);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prikazEnkriptiran);
            this.Name = "FormaDekriptiranaPoruka";
            this.Text = "FormaDekriptiranaPoruka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prikazEnkriptiran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prikazDekriptiran;
        private System.Windows.Forms.Label label2;
    }
}