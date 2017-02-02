namespace CryptoNew
{
    partial class FormaRazmjenaDatoteka
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
            this.tabKontrola = new System.Windows.Forms.TabControl();
            this.tabSlanje = new System.Windows.Forms.TabPage();
            this.tabPregled = new System.Windows.Forms.TabPage();
            this.unosDatoteka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gumbTrazi = new System.Windows.Forms.Button();
            this.gumbPosalji = new System.Windows.Forms.Button();
            this.prikazLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.odabirKorisnik = new System.Windows.Forms.ComboBox();
            this.tabKontrola.SuspendLayout();
            this.tabSlanje.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabKontrola
            // 
            this.tabKontrola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabKontrola.Controls.Add(this.tabSlanje);
            this.tabKontrola.Controls.Add(this.tabPregled);
            this.tabKontrola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabKontrola.Location = new System.Drawing.Point(12, 12);
            this.tabKontrola.Name = "tabKontrola";
            this.tabKontrola.SelectedIndex = 0;
            this.tabKontrola.Size = new System.Drawing.Size(610, 441);
            this.tabKontrola.TabIndex = 0;
            // 
            // tabSlanje
            // 
            this.tabSlanje.BackColor = System.Drawing.Color.LightCyan;
            this.tabSlanje.Controls.Add(this.odabirKorisnik);
            this.tabSlanje.Controls.Add(this.label3);
            this.tabSlanje.Controls.Add(this.label2);
            this.tabSlanje.Controls.Add(this.prikazLog);
            this.tabSlanje.Controls.Add(this.gumbPosalji);
            this.tabSlanje.Controls.Add(this.gumbTrazi);
            this.tabSlanje.Controls.Add(this.label1);
            this.tabSlanje.Controls.Add(this.unosDatoteka);
            this.tabSlanje.Location = new System.Drawing.Point(4, 29);
            this.tabSlanje.Name = "tabSlanje";
            this.tabSlanje.Padding = new System.Windows.Forms.Padding(3);
            this.tabSlanje.Size = new System.Drawing.Size(602, 408);
            this.tabSlanje.TabIndex = 0;
            this.tabSlanje.Text = "Slanje Datoteka";
            // 
            // tabPregled
            // 
            this.tabPregled.BackColor = System.Drawing.Color.LightCyan;
            this.tabPregled.Location = new System.Drawing.Point(4, 29);
            this.tabPregled.Name = "tabPregled";
            this.tabPregled.Padding = new System.Windows.Forms.Padding(3);
            this.tabPregled.Size = new System.Drawing.Size(602, 408);
            this.tabPregled.TabIndex = 1;
            this.tabPregled.Text = "Pregled Primljenih Datoteka";
            // 
            // unosDatoteka
            // 
            this.unosDatoteka.Location = new System.Drawing.Point(10, 102);
            this.unosDatoteka.Name = "unosDatoteka";
            this.unosDatoteka.ReadOnly = true;
            this.unosDatoteka.Size = new System.Drawing.Size(491, 26);
            this.unosDatoteka.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Putanja Datoteke:";
            // 
            // gumbTrazi
            // 
            this.gumbTrazi.Location = new System.Drawing.Point(507, 102);
            this.gumbTrazi.Name = "gumbTrazi";
            this.gumbTrazi.Size = new System.Drawing.Size(89, 26);
            this.gumbTrazi.TabIndex = 2;
            this.gumbTrazi.Text = "Pretraži";
            this.gumbTrazi.UseVisualStyleBackColor = true;
            this.gumbTrazi.Click += new System.EventHandler(this.gumbTrazi_Click);
            // 
            // gumbPosalji
            // 
            this.gumbPosalji.Enabled = false;
            this.gumbPosalji.Location = new System.Drawing.Point(10, 134);
            this.gumbPosalji.Name = "gumbPosalji";
            this.gumbPosalji.Size = new System.Drawing.Size(178, 31);
            this.gumbPosalji.TabIndex = 3;
            this.gumbPosalji.Text = "Enkriptiraj i Pošalji";
            this.gumbPosalji.UseVisualStyleBackColor = true;
            this.gumbPosalji.Click += new System.EventHandler(this.gumbPosalji_Click);
            // 
            // prikazLog
            // 
            this.prikazLog.Location = new System.Drawing.Point(10, 191);
            this.prikazLog.Multiline = true;
            this.prikazLog.Name = "prikazLog";
            this.prikazLog.ReadOnly = true;
            this.prikazLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.prikazLog.Size = new System.Drawing.Size(586, 211);
            this.prikazLog.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Log:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Odaberite Primatelja:";
            // 
            // odabirKorisnik
            // 
            this.odabirKorisnik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.odabirKorisnik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.odabirKorisnik.FormattingEnabled = true;
            this.odabirKorisnik.Location = new System.Drawing.Point(10, 38);
            this.odabirKorisnik.Name = "odabirKorisnik";
            this.odabirKorisnik.Size = new System.Drawing.Size(491, 28);
            this.odabirKorisnik.TabIndex = 8;
            // 
            // FormaRazmjenaDatoteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 465);
            this.Controls.Add(this.tabKontrola);
            this.Name = "FormaRazmjenaDatoteka";
            this.Text = "FormaRazmjenaDatoteka";
            this.tabKontrola.ResumeLayout(false);
            this.tabSlanje.ResumeLayout(false);
            this.tabSlanje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabKontrola;
        private System.Windows.Forms.TabPage tabSlanje;
        private System.Windows.Forms.TabPage tabPregled;
        private System.Windows.Forms.Button gumbTrazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox unosDatoteka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prikazLog;
        private System.Windows.Forms.Button gumbPosalji;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox odabirKorisnik;
    }
}