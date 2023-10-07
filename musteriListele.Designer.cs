namespace banka_otomasyonu_210601028_210601048
{
    partial class musteriListele
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
            this.musteriListeleListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // musteriListeleListBox
            // 
            this.musteriListeleListBox.FormattingEnabled = true;
            this.musteriListeleListBox.ItemHeight = 16;
            this.musteriListeleListBox.Location = new System.Drawing.Point(32, 33);
            this.musteriListeleListBox.Name = "musteriListeleListBox";
            this.musteriListeleListBox.Size = new System.Drawing.Size(594, 276);
            this.musteriListeleListBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.musteriListeleListBox);
            this.panel1.Location = new System.Drawing.Point(59, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 376);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // musteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "musteriListele";
            this.Text = "musteriListele";
            this.Load += new System.EventHandler(this.musteriListele_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox musteriListeleListBox;
        private System.Windows.Forms.Panel panel1;
    }
}