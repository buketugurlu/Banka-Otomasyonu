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
    public partial class hesapListesi : Form
    {
        public hesapListesi()
        {
            InitializeComponent();
        }
  
        private void hesapListesi_Load(object sender, EventArgs e)
        {
            listBoxHesapListesi.Items.Add("Hesap No: 1267 Müşteri Ad: Cemre  Soyad: Doğan" + "\n" );
            listBoxHesapListesi.Items.Add("Hesap No: 2402 Müşteri Ad: Buket  Soyad: Uğurlu" + "\n");
            listBoxHesapListesi.Items.Add("Hesap No: 3267 Müşteri Ad: Ceren  Soyad: Doğan" + "\n");
            listBoxHesapListesi.Items.Add("Hesap No: 4002 Müşteri Ad: Yeliz  Soyad: Akmut" + "\n");

        }
        public string hesapNoListele;
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (int no in hesapAcma.musteri6.HesapNumaralarıListesi)
            {
                listBoxHesapListesi.Items.Add("Hesap No: " + no + "   Müşteri Adı: " + hesapAcma.musteri6.kimlikBilgisi.Ad + "  Müşteri Soyad: " + hesapAcma.musteri6.kimlikBilgisi.Soyad + "\n")  ; 
            }

        }
    }
   }
