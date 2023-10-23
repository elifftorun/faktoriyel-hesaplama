namespace faktoriyel_hesaplama
{
    partial class Form1
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
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtFaktoriyel = new System.Windows.Forms.TextBox();
            this.btnSonucHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(241, 84);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(76, 24);
            this.lblSonuc.TabIndex = 0;
            this.lblSonuc.Text = "Sonuç:";
            // 
            // txtFaktoriyel
            // 
            this.txtFaktoriyel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFaktoriyel.Location = new System.Drawing.Point(49, 57);
            this.txtFaktoriyel.Name = "txtFaktoriyel";
            this.txtFaktoriyel.Size = new System.Drawing.Size(151, 29);
            this.txtFaktoriyel.TabIndex = 1;
            // 
            // btnSonucHesapla
            // 
            this.btnSonucHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSonucHesapla.Location = new System.Drawing.Point(49, 110);
            this.btnSonucHesapla.Name = "btnSonucHesapla";
            this.btnSonucHesapla.Size = new System.Drawing.Size(126, 59);
            this.btnSonucHesapla.TabIndex = 2;
            this.btnSonucHesapla.Text = "Sonuç Hesapla";
            this.btnSonucHesapla.UseVisualStyleBackColor = true;
            this.btnSonucHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 245);
            this.Controls.Add(this.btnSonucHesapla);
            this.Controls.Add(this.txtFaktoriyel);
            this.Controls.Add(this.lblSonuc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtFaktoriyel;
        private System.Windows.Forms.Button btnSonucHesapla;
    }
}

