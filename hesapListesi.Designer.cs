namespace banka_otomasyonu_210601028_210601048
{
    partial class hesapListesi
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxHesapListesi = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Görüntüle\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxHesapListesi
            // 
            this.listBoxHesapListesi.FormattingEnabled = true;
            this.listBoxHesapListesi.ItemHeight = 16;
            this.listBoxHesapListesi.Location = new System.Drawing.Point(47, 39);
            this.listBoxHesapListesi.Name = "listBoxHesapListesi";
            this.listBoxHesapListesi.Size = new System.Drawing.Size(621, 244);
            this.listBoxHesapListesi.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.listBoxHesapListesi);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(66, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 375);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(319, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hesap Listesi";
            // 
            // hesapListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(891, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "hesapListesi";
            this.Text = "hesapListesi";
            this.Load += new System.EventHandler(this.hesapListesi_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxHesapListesi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}