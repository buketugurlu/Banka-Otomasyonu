
namespace banka_otomasyonu_210601028_210601048
{
    partial class HesapÖzetiListeleri
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
            this.ListBoxHesapOzetiListeleri = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxHesapOzetiListeleri
            // 
            this.ListBoxHesapOzetiListeleri.FormattingEnabled = true;
            this.ListBoxHesapOzetiListeleri.ItemHeight = 16;
            this.ListBoxHesapOzetiListeleri.Location = new System.Drawing.Point(52, 34);
            this.ListBoxHesapOzetiListeleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBoxHesapOzetiListeleri.Name = "ListBoxHesapOzetiListeleri";
            this.ListBoxHesapOzetiListeleri.Size = new System.Drawing.Size(697, 276);
            this.ListBoxHesapOzetiListeleri.TabIndex = 0;
            this.ListBoxHesapOzetiListeleri.SelectedIndexChanged += new System.EventHandler(this.ListBoxHesapOzetiListeleri_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.ListBoxHesapOzetiListeleri);
            this.panel1.Location = new System.Drawing.Point(60, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 344);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(322, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hesap Özeti Listeleri";
            // 
            // HesapÖzetiListeleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HesapÖzetiListeleri";
            this.Text = "HesapÖzetiListeleri";
            this.Load += new System.EventHandler(this.HesapÖzetiListeleri_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox ListBoxHesapOzetiListeleri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}