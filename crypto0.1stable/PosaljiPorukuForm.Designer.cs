namespace crypto0._1stable
{
    partial class PosaljiPorukuForm
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
            this.txtSlanjePoruke = new System.Windows.Forms.TextBox();
            this.btnSlanjePoruke = new System.Windows.Forms.Button();
            this.txtPrimatelj = new System.Windows.Forms.TextBox();
            this.lblPrimatelj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSlanjePoruke
            // 
            this.txtSlanjePoruke.Location = new System.Drawing.Point(107, 114);
            this.txtSlanjePoruke.Multiline = true;
            this.txtSlanjePoruke.Name = "txtSlanjePoruke";
            this.txtSlanjePoruke.Size = new System.Drawing.Size(316, 145);
            this.txtSlanjePoruke.TabIndex = 0;
            // 
            // btnSlanjePoruke
            // 
            this.btnSlanjePoruke.Location = new System.Drawing.Point(201, 279);
            this.btnSlanjePoruke.Name = "btnSlanjePoruke";
            this.btnSlanjePoruke.Size = new System.Drawing.Size(75, 23);
            this.btnSlanjePoruke.TabIndex = 1;
            this.btnSlanjePoruke.Text = "Posalji";
            this.btnSlanjePoruke.UseVisualStyleBackColor = true;
            this.btnSlanjePoruke.Click += new System.EventHandler(this.btnSlanjePoruke_Click);
            // 
            // txtPrimatelj
            // 
            this.txtPrimatelj.Location = new System.Drawing.Point(159, 50);
            this.txtPrimatelj.Name = "txtPrimatelj";
            this.txtPrimatelj.Size = new System.Drawing.Size(188, 20);
            this.txtPrimatelj.TabIndex = 2;
            // 
            // lblPrimatelj
            // 
            this.lblPrimatelj.AutoSize = true;
            this.lblPrimatelj.Location = new System.Drawing.Point(104, 53);
            this.lblPrimatelj.Name = "lblPrimatelj";
            this.lblPrimatelj.Size = new System.Drawing.Size(49, 13);
            this.lblPrimatelj.TabIndex = 3;
            this.lblPrimatelj.Text = "Primatelj:";
            // 
            // PosaljiPorukuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 340);
            this.Controls.Add(this.lblPrimatelj);
            this.Controls.Add(this.txtPrimatelj);
            this.Controls.Add(this.btnSlanjePoruke);
            this.Controls.Add(this.txtSlanjePoruke);
            this.Name = "PosaljiPorukuForm";
            this.Text = "PosaljiPorukuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSlanjePoruke;
        private System.Windows.Forms.Button btnSlanjePoruke;
        private System.Windows.Forms.TextBox txtPrimatelj;
        private System.Windows.Forms.Label lblPrimatelj;
    }
}