namespace banka_otomasyonu_210601028_210601048
{
    partial class paraCekme
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
            this.paraCekmeOnayla = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paraCekmeTutar = new System.Windows.Forms.TextBox();
            this.comboBoxParaCekme = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // paraCekmeOnayla
            // 
            this.paraCekmeOnayla.Location = new System.Drawing.Point(485, 36);
            this.paraCekmeOnayla.Name = "paraCekmeOnayla";
            this.paraCekmeOnayla.Size = new System.Drawing.Size(99, 28);
            this.paraCekmeOnayla.TabIndex = 11;
            this.paraCekmeOnayla.Text = "ONAYLA";
            this.paraCekmeOnayla.UseVisualStyleBackColor = true;
            this.paraCekmeOnayla.Click += new System.EventHandler(this.paraCekmeOnayla_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "İPTAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "ANA MENÜYE GERİ DÖN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(181, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Para Tutarı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(317, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Para Çekme";
            // 
            // paraCekmeTutar
            // 
            this.paraCekmeTutar.Location = new System.Drawing.Point(306, 153);
            this.paraCekmeTutar.Name = "paraCekmeTutar";
            this.paraCekmeTutar.Size = new System.Drawing.Size(146, 22);
            this.paraCekmeTutar.TabIndex = 6;
            // 
            // comboBoxParaCekme
            // 
            this.comboBoxParaCekme.FormattingEnabled = true;
            this.comboBoxParaCekme.Location = new System.Drawing.Point(306, 66);
            this.comboBoxParaCekme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxParaCekme.Name = "comboBoxParaCekme";
            this.comboBoxParaCekme.Size = new System.Drawing.Size(146, 24);
            this.comboBoxParaCekme.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(129, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Hesap Numaranız:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBoxParaCekme);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.paraCekmeTutar);
            this.panel1.Location = new System.Drawing.Point(68, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 245);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.paraCekmeOnayla);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(68, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 102);
            this.panel2.TabIndex = 36;
            // 
            // paraCekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(846, 483);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "paraCekme";
            this.Text = "paraCekme";
            this.Load += new System.EventHandler(this.paraCekme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button paraCekmeOnayla;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox paraCekmeTutar;
        private System.Windows.Forms.ComboBox comboBoxParaCekme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}