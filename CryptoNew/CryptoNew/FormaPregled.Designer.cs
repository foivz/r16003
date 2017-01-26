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
            this.tabPoslano = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabKontrola.SuspendLayout();
            this.tabPrimljeno.SuspendLayout();
            this.tabPoslano.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabKontrola
            // 
            this.tabKontrola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabKontrola.Controls.Add(this.tabPrimljeno);
            this.tabKontrola.Controls.Add(this.tabPoslano);
            this.tabKontrola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabKontrola.Location = new System.Drawing.Point(12, 12);
            this.tabKontrola.Name = "tabKontrola";
            this.tabKontrola.SelectedIndex = 0;
            this.tabKontrola.Size = new System.Drawing.Size(739, 446);
            this.tabKontrola.TabIndex = 0;
            // 
            // tabPrimljeno
            // 
            this.tabPrimljeno.Controls.Add(this.dataGridView1);
            this.tabPrimljeno.Location = new System.Drawing.Point(4, 33);
            this.tabPrimljeno.Name = "tabPrimljeno";
            this.tabPrimljeno.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrimljeno.Size = new System.Drawing.Size(731, 409);
            this.tabPrimljeno.TabIndex = 0;
            this.tabPrimljeno.Text = "Primljeno";
            this.tabPrimljeno.UseVisualStyleBackColor = true;
            // 
            // tabPoslano
            // 
            this.tabPoslano.Controls.Add(this.dataGridView2);
            this.tabPoslano.Location = new System.Drawing.Point(4, 33);
            this.tabPoslano.Name = "tabPoslano";
            this.tabPoslano.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoslano.Size = new System.Drawing.Size(731, 409);
            this.tabPoslano.TabIndex = 1;
            this.tabPoslano.Text = "Poslano";
            this.tabPoslano.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(719, 397);
            this.dataGridView2.TabIndex = 0;
            // 
            // FormaPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 530);
            this.Controls.Add(this.tabKontrola);
            this.Name = "FormaPregled";
            this.Text = "Pregled Poruka";
            this.tabKontrola.ResumeLayout(false);
            this.tabPrimljeno.ResumeLayout(false);
            this.tabPoslano.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabKontrola;
        private System.Windows.Forms.TabPage tabPrimljeno;
        private System.Windows.Forms.TabPage tabPoslano;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}