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
    public partial class hesapAcma : Form
    {
        public hesapAcma()
        {
            InitializeComponent();
        }

        private void hesapAcma_Load(object sender, EventArgs e)
        {

        }
        public static Banka banka = new Banka();
        public static Hesap hesap6 = new Hesap() { Bakiye = 400,
        ekHesapBakiye = 300} ;
        public static Musteri musteri6 = new Musteri();
        KimlikBilgisi kimlik6 = new KimlikBilgisi();
        private void hesapAcmaOnayla_Click(object sender, EventArgs e)
        {
            kimlik6.TCKimlikNo = Convert.ToInt32(hesapAcmaTCKimlikNo.Text);
            kimlik6.Ad = hesapAcmaAd.Text;
            kimlik6.Soyad = hesapAcmaSoyad.Text;

            string dogum_tarihi = kimlik6.DogumTarihi.ToShortDateString();
            dogum_tarihi = hesapAcmaDogumTarihi.Text;

            musteri6.kimlikBilgisi = kimlik6;
            musteri6.HesapActirma(hesap6, hesap6.HesapNo);

            musteri6.Ad_Validasyon(kimlik6);
            musteri6.Soyad_Validasyon(kimlik6);

            MessageBox.Show(musteri6.HesapListesiGoruntule(musteri6, hesap6));            
        }

        private void hesapAcmaAnaMenuyeGeriDon_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
        }

        private void hesapAcmaIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
