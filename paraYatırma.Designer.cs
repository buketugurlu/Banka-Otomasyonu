namespace banka_otomasyonu_210601028_210601048
{
    partial class paraYatırma
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
            this.paraYatirmaOnayla = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.paraYatirmaTutar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paraYatirmaHesapNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // paraYatirmaOnayla
            // 
            this.paraYatirmaOnayla.Location = new System.Drawing.Point(526, 16);
            this.paraYatirmaOnayla.Name = "paraYatirmaOnayla";
            this.paraYatirmaOnayla.Size = new System.Drawing.Size(99, 28);
            this.paraYatirmaOnayla.TabIndex = 16;
            this.paraYatirmaOnayla.Text = "ONAYLA";
            this.paraYatirmaOnayla.UseVisualStyleBackColor = true;
            this.paraYatirmaOnayla.Click += new System.EventHandler(this.paraYatirmaOnayla_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "İPTAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "ANA MENÜYE GERİ DÖN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // paraYatirmaTutar
            // 
            this.paraYatirmaTutar.Location = new System.Drawing.Point(432, 114);
            this.paraYatirmaTutar.Name = "paraYatirmaTutar";
            this.paraYatirmaTutar.Size = new System.Drawing.Size(216, 22);
            this.paraYatirmaTutar.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(363, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tutar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "İşlem yapmak istediğiniz hesap numarasını seçiniz...";
            // 
            // paraYatirmaHesapNo
            // 
            this.paraYatirmaHesapNo.FormattingEnabled = true;
            this.paraYatirmaHesapNo.Location = new System.Drawing.Point(432, 57);
            this.paraYatirmaHesapNo.Name = "paraYatirmaHesapNo";
            this.paraYatirmaHesapNo.Size = new System.Drawing.Size(216, 24);
            this.paraYatirmaHesapNo.TabIndex = 10;
            this.paraYatirmaHesapNo.SelectedIndexChanged += new System.EventHandler(this.paraYatirmaHesapNo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(301, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Para Yatırma\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.paraYatirmaTutar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.paraYatirmaHesapNo);
            this.panel1.Location = new System.Drawing.Point(67, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 222);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.paraYatirmaOnayla);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(67, 355);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 68);
            this.panel2.TabIndex = 18;
            // 
            // paraYatırma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(839, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "paraYatırma";
            this.Text = "paraYatırma";
            this.Load += new System.EventHandler(this.paraYatırma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button paraYatirmaOnayla;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox paraYatirmaTutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox paraYatirmaHesapNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}