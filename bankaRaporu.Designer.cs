namespace banka_otomasyonu_210601028_210601048
{
    partial class bankaRaporu
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBankaRaporu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBankaRaporu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(536, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 45);
            this.button1.TabIndex = 44;
            this.button1.Text = "ANA MENÜ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(333, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Banka Gelir-Gider Raporu";
            // 
            // dataGridViewBankaRaporu
            // 
            this.dataGridViewBankaRaporu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBankaRaporu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3});
            this.dataGridViewBankaRaporu.Location = new System.Drawing.Point(58, 40);
            this.dataGridViewBankaRaporu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewBankaRaporu.Name = "dataGridViewBankaRaporu";
            this.dataGridViewBankaRaporu.RowHeadersWidth = 62;
            this.dataGridViewBankaRaporu.RowTemplate.Height = 28;
            this.dataGridViewBankaRaporu.Size = new System.Drawing.Size(675, 298);
            this.dataGridViewBankaRaporu.TabIndex = 45;
            this.dataGridViewBankaRaporu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBankaRaporu_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "İŞLEM";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MİKTAR";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.dataGridViewBankaRaporu);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(97, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 435);
            this.panel1.TabIndex = 46;
            // 
            // bankaRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "bankaRaporu";
            this.Text = "bankaRaporu";
            this.Load += new System.EventHandler(this.bankaRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBankaRaporu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewBankaRaporu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel1;
    }
}