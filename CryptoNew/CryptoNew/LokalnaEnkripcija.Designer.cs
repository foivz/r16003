namespace CryptoNew
{
    partial class LokalnaEnkripcija
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
            this.prikazOriginal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.odabirAlgoritam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gumbGeneriraj = new System.Windows.Forms.Button();
            this.odabirPrvo = new System.Windows.Forms.TextBox();
            this.labelaPrvo = new System.Windows.Forms.Label();
            this.labelaDrugo = new System.Windows.Forms.Label();
            this.odabirDrugo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prikazEnkriptirano = new System.Windows.Forms.TextBox();
            this.gumbEnkriptiraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prikazOriginal
            // 
            this.prikazOriginal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prikazOriginal.Location = new System.Drawing.Point(195, 243);
            this.prikazOriginal.Multiline = true;
            this.prikazOriginal.Name = "prikazOriginal";
            this.prikazOriginal.Size = new System.Drawing.Size(604, 124);
            this.prikazOriginal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(191, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Originalni Tekst:";
            // 
            // odabirAlgoritam
            // 
            this.odabirAlgoritam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odabirAlgoritam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odabirAlgoritam.FormattingEnabled = true;
            this.odabirAlgoritam.Location = new System.Drawing.Point(437, 78);
            this.odabirAlgoritam.Name = "odabirAlgoritam";
            this.odabirAlgoritam.Size = new System.Drawing.Size(217, 28);
            this.odabirAlgoritam.TabIndex = 2;
            this.odabirAlgoritam.SelectedIndexChanged += new System.EventHandler(this.odabirAlgoritam_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(191, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odabir enkripcijskog algoritma:";
            // 
            // gumbGeneriraj
            // 
            this.gumbGeneriraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gumbGeneriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbGeneriraj.Location = new System.Drawing.Point(195, 110);
            this.gumbGeneriraj.Name = "gumbGeneriraj";
            this.gumbGeneriraj.Size = new System.Drawing.Size(212, 29);
            this.gumbGeneriraj.TabIndex = 4;
            this.gumbGeneriraj.Text = "Generiraj ključeve";
            this.gumbGeneriraj.UseVisualStyleBackColor = true;
            this.gumbGeneriraj.Click += new System.EventHandler(this.gumbGeneriraj_Click);
            // 
            // odabirPrvo
            // 
            this.odabirPrvo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odabirPrvo.Location = new System.Drawing.Point(237, 151);
            this.odabirPrvo.Name = "odabirPrvo";
            this.odabirPrvo.Size = new System.Drawing.Size(562, 20);
            this.odabirPrvo.TabIndex = 5;
            // 
            // labelaPrvo
            // 
            this.labelaPrvo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelaPrvo.AutoSize = true;
            this.labelaPrvo.Location = new System.Drawing.Point(196, 154);
            this.labelaPrvo.Name = "labelaPrvo";
            this.labelaPrvo.Size = new System.Drawing.Size(28, 13);
            this.labelaPrvo.TabIndex = 6;
            this.labelaPrvo.Text = "Key:";
            // 
            // labelaDrugo
            // 
            this.labelaDrugo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelaDrugo.AutoSize = true;
            this.labelaDrugo.Location = new System.Drawing.Point(196, 183);
            this.labelaDrugo.Name = "labelaDrugo";
            this.labelaDrugo.Size = new System.Drawing.Size(20, 13);
            this.labelaDrugo.TabIndex = 7;
            this.labelaDrugo.Text = "IV:";
            // 
            // odabirDrugo
            // 
            this.odabirDrugo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odabirDrugo.Location = new System.Drawing.Point(237, 180);
            this.odabirDrugo.Name = "odabirDrugo";
            this.odabirDrugo.Size = new System.Drawing.Size(562, 20);
            this.odabirDrugo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(195, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enkriptirani Tekst:";
            // 
            // prikazEnkriptirano
            // 
            this.prikazEnkriptirano.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prikazEnkriptirano.Location = new System.Drawing.Point(195, 463);
            this.prikazEnkriptirano.Multiline = true;
            this.prikazEnkriptirano.Name = "prikazEnkriptirano";
            this.prikazEnkriptirano.Size = new System.Drawing.Size(604, 125);
            this.prikazEnkriptirano.TabIndex = 10;
            // 
            // gumbEnkriptiraj
            // 
            this.gumbEnkriptiraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gumbEnkriptiraj.Enabled = false;
            this.gumbEnkriptiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbEnkriptiraj.Location = new System.Drawing.Point(195, 373);
            this.gumbEnkriptiraj.Name = "gumbEnkriptiraj";
            this.gumbEnkriptiraj.Size = new System.Drawing.Size(167, 38);
            this.gumbEnkriptiraj.TabIndex = 11;
            this.gumbEnkriptiraj.Text = "Enkriptiraj";
            this.gumbEnkriptiraj.UseVisualStyleBackColor = true;
            this.gumbEnkriptiraj.Click += new System.EventHandler(this.gumbEnkriptiraj_Click);
            // 
            // LokalnaEnkripcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(987, 611);
            this.Controls.Add(this.gumbEnkriptiraj);
            this.Controls.Add(this.prikazEnkriptirano);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.odabirDrugo);
            this.Controls.Add(this.labelaDrugo);
            this.Controls.Add(this.labelaPrvo);
            this.Controls.Add(this.odabirPrvo);
            this.Controls.Add(this.gumbGeneriraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.odabirAlgoritam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prikazOriginal);
            this.Name = "LokalnaEnkripcija";
            this.Text = "LokalnaEnkripcija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prikazOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox odabirAlgoritam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gumbGeneriraj;
        private System.Windows.Forms.TextBox odabirPrvo;
        private System.Windows.Forms.Label labelaPrvo;
        private System.Windows.Forms.Label labelaDrugo;
        private System.Windows.Forms.TextBox odabirDrugo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prikazEnkriptirano;
        private System.Windows.Forms.Button gumbEnkriptiraj;
    }
}