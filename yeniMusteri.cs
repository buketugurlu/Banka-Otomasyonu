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
    public partial class yeniMusteri : Form
    {
        public yeniMusteri()
        {
            InitializeComponent();
        }

        private void yeniMusteri_Load(object sender, EventArgs e)
        {
            yeniMüsteriMüsteriTipi.Items.Add("Bireysel Müşteri");
            yeniMüsteriMüsteriTipi.Items.Add("Ticari Müşteri");

        }

        public static string dogum_Tarihi;
        public Banka yeniMusteribanka = new Banka();
        public Musteri musteri1 = new Musteri();
        public KimlikBilgisi kimlik1 = new KimlikBilgisi();
        private void yeniMüsteriEkle_Click(object sender, EventArgs e)
        {
            
            kimlik1.Ad = yeniMüsteriAd.Text;
            kimlik1.Soyad = yeniMüsteriSoyad.Text;
           kimlik1.TCKimlikNo = Convert.ToInt32(yeniMüsteriTCKimlikNo.Text);

            dogum_Tarihi = kimlik1.DogumTarihi.ToShortDateString();
            dogum_Tarihi = yeniMusteriDogumTarihi.Text;
           
            musteri1.MusteriTipi = yeniMüsteriMüsteriTipi.SelectedItem.ToString();
            musteri1.kimlikBilgisi = kimlik1;

            yeniMusteribanka.MusteriEkle(musteri1);

        }

        private void yeniMusteriMusteriListGoruntule_Click(object sender, EventArgs e)
        {
            MessageBox.Show(yeniMusteribanka.MusteriGoruntule(kimlik1, musteri1));
            
        }
    }
}
