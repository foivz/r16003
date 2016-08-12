namespace crypto0._1stable
{
    partial class OtkZakForm
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
            this.listaKorisnika = new System.Windows.Forms.ListView();
            this.korime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listaKorisnika
            // 
            this.listaKorisnika.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.korime,
            this.status});
            this.listaKorisnika.Location = new System.Drawing.Point(12, 12);
            this.listaKorisnika.Name = "listaKorisnika";
            this.listaKorisnika.Size = new System.Drawing.Size(461, 267);
            this.listaKorisnika.TabIndex = 0;
            this.listaKorisnika.UseCompatibleStateImageBehavior = false;
            this.listaKorisnika.View = System.Windows.Forms.View.Details;
            // 
            // korime
            // 
            this.korime.Tag = "";
            this.korime.Text = "Korisnicko ime";
            // 
            // status
            // 
            this.status.Text = "Status";
            // 
            // OtkZakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 295);
            this.Controls.Add(this.listaKorisnika);
            this.Name = "OtkZakForm";
            this.Text = "Otključavanje i Zaključavanje Računa";
            this.Load += new System.EventHandler(this.OtkZakForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaKorisnika;
        private System.Windows.Forms.ColumnHeader korime;
        private System.Windows.Forms.ColumnHeader status;
    }
}