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
    public partial class hesapKapama : Form
    {
        public hesapKapama()
        {
            InitializeComponent();
        }

        private void hesapKapama_Load(object sender, EventArgs e)
        {
            hesapKapamaHesapNo.Items.Add("1267");
            hesapKapamaHesapNo.Items.Add("2402");
            hesapKapamaHesapNo.Items.Add("3267");
            hesapKapamaHesapNo.Items.Add("4002");

            foreach (int no in hesapAcma.musteri6.HesapNumaralarıListesi)
            {
                hesapKapamaHesapNo.Items.Add(no);
            }
        }

        private void hesapKapamaHesapNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public decimal toplamBakiye = hesapAcma.hesap6.Bakiye + hesapAcma.hesap6.ekHesapBakiye;
        private void button3_Click(object sender, EventArgs e)
        {
        
            if (toplamBakiye == 0)
            {
                int kapatilacak = Convert.ToInt32(hesapKapamaHesapNo.Items[hesapKapamaHesapNo.SelectedIndex]);
                hesapAcma.musteri6.HesapNumaralarıListesi.Remove(kapatilacak);
                MessageBox.Show("Hesabınız kapatılmıştır." + "\n" + "Hesap bakiyeniz:  " + toplamBakiye.ToString());
            }
            else if(toplamBakiye != 0)
            {
                MessageBox.Show("Bakiyeniz 0 değildir. Hesabınız kapatılamadı!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
        }
    }
}
