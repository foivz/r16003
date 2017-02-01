namespace CryptoNew
{
    partial class FormaPregled
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
            this.tabPrimljeno = new System.Windows.Forms.TabPage();
            this.dataGridViewPrimljeno = new System.Windows.Forms.DataGridView();
            this.tabPoslano = new System.Windows.Forms.TabPage();
            this.dataGridViewPoslano = new System.Windows.Forms.DataGridView();
            this.tabKontrola.SuspendLayout();
            this.tabPrimljeno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrimljeno)).BeginInit();
            this.tabPoslano.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoslano)).BeginInit();
            this.SuspendLayout();
            // 
            // tabKontrola
            // 
            this.tabKontrola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabKontrola.Controls.Add(this.tabPrimljeno);
            this.tabKontrola.Controls.Add(this.tabPoslano);
            this.tabKontrola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabKontrola.Location = new System.Drawing.Point(12, 12);
            this.tabKontrola.Name = "tabKontrola";
            this.tabKontrola.SelectedIndex = 0;
            this.tabKontrola.Size = new System.Drawing.Size(779, 385);
            this.tabKontrola.TabIndex = 0;
            // 
            // tabPrimljeno
            // 
            this.tabPrimljeno.Controls.Add(this.dataGridViewPrimljeno);
            this.tabPrimljeno.Location = new System.Drawing.Point(4, 33);
            this.tabPrimljeno.Name = "tabPrimljeno";
            this.tabPrimljeno.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrimljeno.Size = new System.Drawing.Size(771, 348);
            this.tabPrimljeno.TabIndex = 0;
            this.tabPrimljeno.Text = "Primljeno";
            this.tabPrimljeno.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPrimljeno
            // 
            this.dataGridViewPrimljeno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPrimljeno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewPrimljeno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrimljeno.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewPrimljeno.Name = "dataGridViewPrimljeno";
            this.dataGridViewPrimljeno.Size = new System.Drawing.Size(759, 336);
            this.dataGridViewPrimljeno.TabIndex = 0;
            // 
            // tabPoslano
            // 
            this.tabPoslano.Controls.Add(this.dataGridViewPoslano);
            this.tabPoslano.Location = new System.Drawing.Point(4, 33);
            this.tabPoslano.Name = "tabPoslano";
            this.tabPoslano.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoslano.Size = new System.Drawing.Size(771, 348);
            this.tabPoslano.TabIndex = 1;
            this.tabPoslano.Text = "Poslano";
            this.tabPoslano.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPoslano
            // 
            this.dataGridViewPoslano.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPoslano.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPoslano.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewPoslano.Name = "dataGridViewPoslano";
            this.dataGridViewPoslano.Size = new System.Drawing.Size(759, 336);
            this.dataGridViewPoslano.TabIndex = 0;
            // 
            // FormaPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 409);
            this.Controls.Add(this.tabKontrola);
            this.Name = "FormaPregled";
            this.Text = "Pregled Poruka";
            this.tabKontrola.ResumeLayout(false);
            this.tabPrimljeno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrimljeno)).EndInit();
            this.tabPoslano.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoslano)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabKontrola;
        private System.Windows.Forms.TabPage tabPrimljeno;
        private System.Windows.Forms.TabPage tabPoslano;
        private System.Windows.Forms.DataGridView dataGridViewPrimljeno;
        private System.Windows.Forms.DataGridView dataGridViewPoslano;
    }
}