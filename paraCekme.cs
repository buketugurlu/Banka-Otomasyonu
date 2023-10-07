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
    public partial class paraCekme : Form
    {
        public paraCekme()
        {
            InitializeComponent();
        }
        public int seciliHesapNo1;
        public int seciliHesapNo2;
        public int seciliHesapNo3;
        public int seciliHesapNo4;
        public int seciliHesapNo6;

        public static Hesap hesap2 = new Hesap() { Bakiye = 400, hesapNo_kaydet = 1267 };
        public static Hesap hesap3 = new Hesap() { Bakiye = 400, hesapNo_kaydet = 2402 };
        public static Hesap hesap4 = new Hesap() { Bakiye = 400, hesapNo_kaydet = 3267 };
        public static Hesap hesap5 = new Hesap() { Bakiye = 400, hesapNo_kaydet = 4002 };

        public IslemBilgisi Islem2 = new IslemBilgisi();
        public IslemBilgisi Islem3 = new IslemBilgisi();
        public IslemBilgisi Islem4 = new IslemBilgisi();
        public IslemBilgisi Islem5 = new IslemBilgisi();
        public IslemBilgisi Islem6 = new IslemBilgisi();

        public static string islem2_kaydet = "";
        public static string islem3_kaydet = "";
        public static string islem4_kaydet = "";
        public static string islem5_kaydet = "";
        public static string islem6_kaydet = "";
        private void paraCekme_Load(object sender, EventArgs e)
        {

            comboBoxParaCekme.Items.Add("1267");
            comboBoxParaCekme.Items.Add("2402");
            comboBoxParaCekme.Items.Add("3267");
            comboBoxParaCekme.Items.Add("4002");

            foreach (int no in hesapAcma.musteri6.HesapNumaralarıListesi)
            {
                comboBoxParaCekme.Items.Add(no);
            }
        }

        private void paraCekmeOnayla_Click(object sender, EventArgs e)
        {
            hesap2.hesapNo_kaydet = seciliHesapNo1;
            hesap3.hesapNo_kaydet = seciliHesapNo2;
            hesap3.hesapNo_kaydet = seciliHesapNo3;
            hesap4.hesapNo_kaydet = seciliHesapNo4;
            
            hesapAcma.hesap6.hesapNo_kaydet = seciliHesapNo6;

            seciliHesapNo1 = Convert.ToInt32(comboBoxParaCekme.Items[comboBoxParaCekme.SelectedIndex]);
            seciliHesapNo2 = Convert.ToInt32(comboBoxParaCekme.Items[comboBoxParaCekme.SelectedIndex]);
            seciliHesapNo3 = Convert.ToInt32(comboBoxParaCekme.Items[comboBoxParaCekme.SelectedIndex]);
            seciliHesapNo4 = Convert.ToInt32(comboBoxParaCekme.Items[comboBoxParaCekme.SelectedIndex]);

            if (seciliHesapNo1 == 1267)
            { 
                    hesap2.ParaCekme(Convert.ToDecimal(paraCekmeTutar.Text));
                    Islem2.Detay = "Para çekme işlemi";
                    Islem2.HesapNo = 1267;
                    Islem2.IslemTarihi = DateTime.Now;
                    Islem2.Tutar = Convert.ToInt32(paraCekmeTutar.Text);
                islem2_kaydet +=  Islem2.IslemTarihi + "  " + Islem2.Detay + "  " + "Miktar:" + Islem2.Tutar + "TL" + "  \n   ";
                hesap2.IslemBilgisiEkle(Islem2);

                MessageBox.Show("Kalan Bakiyeniz:" + hesap2.Bakiye.ToString() +
                    "\nKalan Ek Hesap Bakiyeniz:" + hesap2.ekHesapBakiye.ToString());
            }

            else if (seciliHesapNo2 == 2402)
            {
                hesap3.ParaCekme(Convert.ToDecimal(paraCekmeTutar.Text));
                Islem3.Detay = "Para çekme işlemi";
                Islem3.HesapNo = 2402;
                Islem3.IslemTarihi = DateTime.Now;
                Islem3.Tutar = Convert.ToInt32(paraCekmeTutar.Text);
                hesap3.IslemBilgisiEkle(Islem3);
                islem3_kaydet += Islem3.IslemTarihi + "  " + Islem3.Detay + "  " + "Miktar:" + Islem3.Tutar + "TL" + "  \n   ";

                MessageBox.Show("Kalan Bakiyeniz:" + hesap3.Bakiye.ToString() +
                    "\nKalan Ek Hesap Bakiyeniz:" + hesap3.ekHesapBakiye.ToString());
            }

            else if (seciliHesapNo3 == 3267)
            {
                hesap4.ParaCekme(Convert.ToDecimal(paraCekmeTutar.Text));
                Islem4.Detay = "Para çekme işlemi";
                Islem4.HesapNo = 3267;
                Islem4.IslemTarihi = DateTime.Now;
                Islem4.Tutar = Convert.ToInt32(paraCekmeTutar.Text);
                hesap4.IslemBilgisiEkle(Islem4);
                islem4_kaydet += Islem4.IslemTarihi + "  " + Islem4.Detay + "  " + "Miktar:" + Islem4.Tutar + "TL" + "  \n   ";

                MessageBox.Show("Kalan Bakiyeniz:" + hesap4.Bakiye.ToString() +
                    "\nKalan Ek Hesap Bakiyeniz:" + hesap4.ekHesapBakiye.ToString());
            }

            else if (seciliHesapNo4 == 4002)
            {
                hesap5.ParaCekme(Convert.ToDecimal(paraCekmeTutar.Text));
                Islem5.Detay = "Para çekme işlemi";
                Islem5.HesapNo = 4002;
                Islem5.IslemTarihi = DateTime.Now;
                Islem5.Tutar = Convert.ToInt32(paraCekmeTutar.Text);
                hesap5.IslemBilgisiEkle(Islem5);
                islem5_kaydet += Islem5.IslemTarihi + "  " + Islem5.Detay + "  " + "Miktar:" + Islem5.Tutar + "TL" + "  \n   ";

                MessageBox.Show("Kalan Bakiyeniz:" + hesap5.Bakiye.ToString() +
                    "\nKalan Ek Hesap Bakiyeniz:" + hesap5.ekHesapBakiye.ToString());

            }
            else
            {
                hesapAcma.hesap6.ParaCekme(Convert.ToDecimal(paraCekmeTutar.Text));
                Islem6.Detay = "Para çekme işlemi";
                Islem6.HesapNo = hesapAcma.hesap6.HesapNo;
                Islem6.IslemTarihi = DateTime.Now;
                Islem6.Tutar = Convert.ToInt32(paraCekmeTutar.Text);
                hesapAcma.hesap6.IslemBilgisiEkle(Islem6);
                islem6_kaydet += Islem6.IslemTarihi + "  " + Islem6.Detay + "  " + "Miktar:" + Islem6.Tutar + "TL" + "  \n   ";

                MessageBox.Show("Kalan Bakiyeniz:" + hesapAcma.hesap6.Bakiye.ToString() +
                    "\nKalan Ek Hesap Bakiyeniz:" + hesapAcma.hesap6.ekHesapBakiye.ToString());

            }
            hesap2.Tutar_Validasyon(Convert.ToDecimal(paraCekmeTutar.Text));
            hesap3.Tutar_Validasyon(Convert.ToDecimal(paraCekmeTutar.Text));
            hesap4.Tutar_Validasyon(Convert.ToDecimal(paraCekmeTutar.Text));
            hesap5.Tutar_Validasyon(Convert.ToDecimal(paraCekmeTutar.Text));
            hesapAcma.hesap6.Tutar_Validasyon(Convert.ToDecimal(paraCekmeTutar.Text));
        }

        private void button1_Click(object sender, EventArgs e)
            {
                anasayfa anasayfa = new anasayfa();
                anasayfa.Show();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    } 

