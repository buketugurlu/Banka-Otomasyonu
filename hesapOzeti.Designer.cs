namespace banka_otomasyonu_210601028_210601048
{
    partial class hesapOzeti
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxTarih = new System.Windows.Forms.ComboBox();
            this.bttnHesapOzetiGoruntule = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(68, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tarih Aralığı Seçiniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(68, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Hesap seçiniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(299, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Hesap Özeti";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(280, 56);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 24);
            this.comboBox1.TabIndex = 32;
            // 
            // comboBoxTarih
            // 
            this.comboBoxTarih.FormattingEnabled = true;
            this.comboBoxTarih.Location = new System.Drawing.Point(280, 137);
            this.comboBoxTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTarih.Name = "comboBoxTarih";
            this.comboBoxTarih.Size = new System.Drawing.Size(108, 24);
            this.comboBoxTarih.TabIndex = 33;
            // 
            // bttnHesapOzetiGoruntule
            // 
            this.bttnHesapOzetiGoruntule.Location = new System.Drawing.Point(415, 370);
            this.bttnHesapOzetiGoruntule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnHesapOzetiGoruntule.Name = "bttnHesapOzetiGoruntule";
            this.bttnHesapOzetiGoruntule.Size = new System.Drawing.Size(207, 41);
            this.bttnHesapOzetiGoruntule.TabIndex = 34;
            this.bttnHesapOzetiGoruntule.Text = "Hesap Özeti Görüntüle";
            this.bttnHesapOzetiGoruntule.UseVisualStyleBackColor = true;
            this.bttnHesapOzetiGoruntule.Click += new System.EventHandler(this.bttnHesapOzetiGoruntule_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.comboBoxTarih);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(135, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 232);
            this.panel1.TabIndex = 35;
            // 
            // hesapOzeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttnHesapOzetiGoruntule);
            this.Controls.Add(this.label1);
            this.Name = "hesapOzeti";
            this.Text = "hesapOzeti";
            this.Load += new System.EventHandler(this.hesapOzeti_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxTarih;
        private System.Windows.Forms.Button bttnHesapOzetiGoruntule;
        private System.Windows.Forms.Panel panel1;
    }
}