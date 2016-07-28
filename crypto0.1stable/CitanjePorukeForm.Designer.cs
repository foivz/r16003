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
            ((System.ComponentModel.ISupportInitialize)(this.dgwCitanjePoruke)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCitanjePoruke
            // 
            this.dgwCitanjePoruke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCitanjePoruke.Location = new System.Drawing.Point(56, 45);
            this.dgwCitanjePoruke.Name = "dgwCitanjePoruke";
            this.dgwCitanjePoruke.Size = new System.Drawing.Size(354, 185);
            this.dgwCitanjePoruke.TabIndex = 0;
            // 
            // CitanjePorukeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 292);
            this.Controls.Add(this.dgwCitanjePoruke);
            this.Name = "CitanjePorukeForm";
            this.Text = "CitanjePorukeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgwCitanjePoruke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCitanjePoruke;
    }
}