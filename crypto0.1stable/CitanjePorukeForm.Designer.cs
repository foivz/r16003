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
            this.cmbKlijenti = new System.Windows.Forms.ComboBox();
            this.Poruke = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // cmbKlijenti
            // 
            this.cmbKlijenti.FormattingEnabled = true;
            this.cmbKlijenti.Location = new System.Drawing.Point(155, 29);
            this.cmbKlijenti.Name = "cmbKlijenti";
            this.cmbKlijenti.Size = new System.Drawing.Size(150, 21);
            this.cmbKlijenti.TabIndex = 1;
            this.cmbKlijenti.SelectedIndexChanged += new System.EventHandler(this.cmbKlijenti_SelectedIndexChanged);
            // 
            // Poruke
            // 
            this.Poruke.HeaderText = "Poruke";
            this.Poruke.Name = "Poruke";
            this.Poruke.ReadOnly = true;
            this.Poruke.Width = 400;
            // 
            // CitanjePorukeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 321);
            this.Controls.Add(this.cmbKlijenti);
            this.Controls.Add(this.dgwCitanjePoruke);
            this.Name = "CitanjePorukeForm";
            this.Text = "CitanjePorukeForm";
            this.Load += new System.EventHandler(this.CitanjePorukeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCitanjePoruke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCitanjePoruke;
        private System.Windows.Forms.ComboBox cmbKlijenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poruke;
    }
}