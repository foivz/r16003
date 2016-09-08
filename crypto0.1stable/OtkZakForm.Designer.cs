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
            this.btnRadnja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaKorisnika
            // 
            this.listaKorisnika.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.korime,
            this.status});
            this.listaKorisnika.Location = new System.Drawing.Point(12, 12);
            this.listaKorisnika.MultiSelect = false;
            this.listaKorisnika.Name = "listaKorisnika";
            this.listaKorisnika.Size = new System.Drawing.Size(461, 267);
            this.listaKorisnika.TabIndex = 0;
            this.listaKorisnika.UseCompatibleStateImageBehavior = false;
            this.listaKorisnika.View = System.Windows.Forms.View.Details;
            this.listaKorisnika.SelectedIndexChanged += new System.EventHandler(this.listaKorisnika_SelectedIndexChanged);
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
            // btnRadnja
            // 
            this.btnRadnja.Enabled = false;
            this.btnRadnja.Location = new System.Drawing.Point(207, 285);
            this.btnRadnja.Name = "btnRadnja";
            this.btnRadnja.Size = new System.Drawing.Size(75, 23);
            this.btnRadnja.TabIndex = 1;
            this.btnRadnja.Text = "Otkljucaj";
            this.btnRadnja.UseVisualStyleBackColor = true;
            this.btnRadnja.Click += new System.EventHandler(this.btnRadnja_Click);
            // 
            // OtkZakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 332);
            this.Controls.Add(this.btnRadnja);
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
        private System.Windows.Forms.Button btnRadnja;
    }
}