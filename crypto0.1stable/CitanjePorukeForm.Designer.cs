namespace crypto0._1stable
{
    partial class CitanjePorukeForm
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
            this.dgwCitanjePoruke = new System.Windows.Forms.DataGridView();
            this.Poruke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbKlijenti = new System.Windows.Forms.ComboBox();
            this.btnOdgovori = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCitanjePoruke)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCitanjePoruke
            // 
            this.dgwCitanjePoruke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCitanjePoruke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Poruke});
            this.dgwCitanjePoruke.Location = new System.Drawing.Point(23, 104);
            this.dgwCitanjePoruke.Name = "dgwCitanjePoruke";
            this.dgwCitanjePoruke.Size = new System.Drawing.Size(471, 185);
            this.dgwCitanjePoruke.TabIndex = 0;
            // 
            // Poruke
            // 
            this.Poruke.HeaderText = "Poruke";
            this.Poruke.Name = "Poruke";
            this.Poruke.ReadOnly = true;
            this.Poruke.Width = 400;
            // 
            // cmbKlijenti
            // 
            this.cmbKlijenti.FormattingEnabled = true;
            this.cmbKlijenti.Location = new System.Drawing.Point(155, 29);
            this.cmbKlijenti.Name = "cmbKlijenti";
            this.cmbKlijenti.Size = new System.Drawing.Size(150, 21);
            this.cmbKlijenti.TabIndex = 1;
            this.cmbKlijenti.SelectedIndexChanged += new System.EventHandler(this.cmbKlijenti_SelectedIndexChanged);
            // 
            // btnOdgovori
            // 
            this.btnOdgovori.Location = new System.Drawing.Point(344, 26);
            this.btnOdgovori.Name = "btnOdgovori";
            this.btnOdgovori.Size = new System.Drawing.Size(96, 23);
            this.btnOdgovori.TabIndex = 2;
            this.btnOdgovori.Text = "Odgovori osobi";
            this.btnOdgovori.UseVisualStyleBackColor = true;
            this.btnOdgovori.Click += new System.EventHandler(this.btnOdgovori_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Key:";
            // 
            // CitanjePorukeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOdgovori);
            this.Controls.Add(this.cmbKlijenti);
            this.Controls.Add(this.dgwCitanjePoruke);
            this.Name = "CitanjePorukeForm";
            this.Text = "CitanjePorukeForm";
            this.Load += new System.EventHandler(this.CitanjePorukeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCitanjePoruke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCitanjePoruke;
        private System.Windows.Forms.ComboBox cmbKlijenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poruke;
        private System.Windows.Forms.Button btnOdgovori;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}