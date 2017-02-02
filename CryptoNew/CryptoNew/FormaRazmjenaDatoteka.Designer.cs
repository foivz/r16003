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
            this.odabirKorisnik = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prikazLog = new System.Windows.Forms.TextBox();
            this.gumbPosalji = new System.Windows.Forms.Button();
            this.gumbTrazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.unosDatoteka = new System.Windows.Forms.TextBox();
            this.tabPregled = new System.Windows.Forms.TabPage();
            this.prikazDatoteke = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.logPregledDatoteka = new System.Windows.Forms.TextBox();
            this.tabKontrola.SuspendLayout();
            this.tabSlanje.SuspendLayout();
            this.tabPregled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prikazDatoteke)).BeginInit();
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
            this.tabKontrola.SelectedIndexChanged += new System.EventHandler(this.tabKontrola_SelectedIndexChanged);
            // 
            // tabSlanje
            // 
            this.tabSlanje.BackColor = System.Drawing.Color.LightCyan;
            this.tabSlanje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Odaberite Primatelja:";
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
            // gumbTrazi
            // 
            this.gumbTrazi.Location = new System.Drawing.Point(507, 102);
            this.gumbTrazi.Name = "gumbTrazi";
            this.gumbTrazi.Size = new System.Drawing.Size(89, 26);
            this.gumbTrazi.TabIndex = 2;
            this.gumbTrazi.Text = "Odaberi";
            this.gumbTrazi.UseVisualStyleBackColor = true;
            this.gumbTrazi.Click += new System.EventHandler(this.gumbTrazi_Click);
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
            // unosDatoteka
            // 
            this.unosDatoteka.Location = new System.Drawing.Point(10, 102);
            this.unosDatoteka.Name = "unosDatoteka";
            this.unosDatoteka.ReadOnly = true;
            this.unosDatoteka.Size = new System.Drawing.Size(491, 26);
            this.unosDatoteka.TabIndex = 0;
            // 
            // tabPregled
            // 
            this.tabPregled.BackColor = System.Drawing.Color.LightCyan;
            this.tabPregled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPregled.Controls.Add(this.logPregledDatoteka);
            this.tabPregled.Controls.Add(this.label4);
            this.tabPregled.Controls.Add(this.prikazDatoteke);
            this.tabPregled.Location = new System.Drawing.Point(4, 29);
            this.tabPregled.Name = "tabPregled";
            this.tabPregled.Padding = new System.Windows.Forms.Padding(3);
            this.tabPregled.Size = new System.Drawing.Size(602, 408);
            this.tabPregled.TabIndex = 1;
            this.tabPregled.Text = "Pregled Primljenih Datoteka";
            // 
            // prikazDatoteke
            // 
            this.prikazDatoteke.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prikazDatoteke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prikazDatoteke.Location = new System.Drawing.Point(6, 6);
            this.prikazDatoteke.Name = "prikazDatoteke";
            this.prikazDatoteke.Size = new System.Drawing.Size(588, 266);
            this.prikazDatoteke.TabIndex = 0;
            this.prikazDatoteke.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prikazDatoteke_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Log:";
            // 
            // logPregledDatoteka
            // 
            this.logPregledDatoteka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.logPregledDatoteka.Location = new System.Drawing.Point(6, 298);
            this.logPregledDatoteka.Multiline = true;
            this.logPregledDatoteka.Name = "logPregledDatoteka";
            this.logPregledDatoteka.ReadOnly = true;
            this.logPregledDatoteka.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logPregledDatoteka.Size = new System.Drawing.Size(300, 106);
            this.logPregledDatoteka.TabIndex = 2;
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
            this.tabPregled.ResumeLayout(false);
            this.tabPregled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prikazDatoteke)).EndInit();
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
        private System.Windows.Forms.DataGridView prikazDatoteke;
        private System.Windows.Forms.TextBox logPregledDatoteka;
        private System.Windows.Forms.Label label4;
    }
}