using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banka_otomasyonu_210601028_210601048
{
    public partial class bankaRaporu : Form
    {
        public bankaRaporu()
        {
            InitializeComponent();
        }
        Banka banka = new Banka();
        paraCekme para = new paraCekme();

       
        private void bankaRaporu_Load(object sender, EventArgs e)
        {
            hesapAcma.banka.toplamPara = hesapAcma.banka.gelenPara - hesapAcma.banka.gidenPara;
            
            dataGridViewBankaRaporu.ReadOnly = true; // sadece okunabilir olması yani veri düzenleme kapalı
            dataGridViewBankaRaporu.AllowUserToDeleteRows = false;// satırların silinmesi engelleniyor
            dataGridViewBankaRaporu.RowCount = 20; //Kaç satır olacağı belirleniyor…
            dataGridViewBankaRaporu.Columns[1].Width = 100;

            dataGridViewBankaRaporu.Rows.Add();
            dataGridViewBankaRaporu.Rows[0].Cells[0].Value = "Bankaya gelen para";
            dataGridViewBankaRaporu.Rows[0].Cells[1].Value = hesapAcma.banka.gelenPara;
            dataGridViewBankaRaporu.Rows[1].Cells[0].Value ="Bankadan giden para" ;
            dataGridViewBankaRaporu.Rows[1].Cells[1].Value= hesapAcma.banka.gidenPara;
            dataGridViewBankaRaporu.Rows[2].Cells[0].Value = "Bankadaki Toplam Para";
            dataGridViewBankaRaporu.Rows[2].Cells[1].Value = hesapAcma.banka.toplamPara;       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
        }

        private void dataGridViewBankaRaporu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }
    }
}
