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
    public partial class paraYatırma : Form
    {
        public paraYatırma()
        {
            InitializeComponent();
        }
        public int seciliHesapNo1;
        public int seciliHesapNo2;
        public int seciliHesapNo3;
        public int seciliHesapNo4;
        public int seciliHesapNo6;

        public Hesap hesap2 = new Hesap() { Bakiye = 400, hesapNo_kaydet = 1267 };
        public Hesap hesap3 = new Hesap() { Bakiye = 400, hesapNo_kaydet = 2402 };
        public Hesap hesap4 = new Hesap() { Bakiye = 400, hesapNo_kaydet = 3267 };
        public Hesap hesap5 = new Hesap() { Bakiye = 400, hesapNo_kaydet = 4002};

        public IslemBilgisi Islem2 = new IslemBilgisi();
        public IslemBilgisi Islem3 = new IslemBilgisi();
        public IslemBilgisi Islem4 = new IslemBilgisi();
        public IslemBilgisi Islem5 = new IslemBilgisi();
        public IslemBilgisi Islem6 = new IslemBilgisi();

        public static string pYatirma2_kaydet = "";
        public static string pYatirma3_kaydet = "";
        public static string pYatirma4_kaydet = "";
        public static string pYatirma5_kaydet = "";
        public static string pYatirma6_kaydet = "";

        private void paraYatırma_Load(object sender, EventArgs e)
        {
            paraYatirmaHesapNo.Items.Add("1267");
            paraYatirmaHesapNo.Items.Add("2402");
            paraYatirmaHesapNo.Items.Add("3267");
            paraYatirmaHesapNo.Items.Add("4002");
           
            foreach (int no in hesapAcma.musteri6.HesapNumaralarıListesi)
            {
                paraYatirmaHesapNo.Items.Add(no);
            }
    }

        private void paraYatirmaOnayla_Click(object sender, EventArgs e)
        {
            hesap2.hesapNo_kaydet = seciliHesapNo1;
            hesap3.hesapNo_kaydet = seciliHesapNo2;
            hesap3.hesapNo_kaydet = seciliHesapNo3;
            hesap4.hesapNo_kaydet = seciliHesapNo4;
            
            hesapAcma.hesap6.hesapNo_kaydet = seciliHesapNo6;

            seciliHesapNo1 = Convert.ToInt32(paraYatirmaHesapNo.Items[paraYatirmaHesapNo.SelectedIndex]);
            seciliHesapNo2 = Convert.ToInt32(paraYatirmaHesapNo.Items[paraYatirmaHesapNo.SelectedIndex]);
            seciliHesapNo3 = Convert.ToInt32(paraYatirmaHesapNo.Items[paraYatirmaHesapNo.SelectedIndex]);
            seciliHesapNo4 = Convert.ToInt32(paraYatirmaHesapNo.Items[paraYatirmaHesapNo.SelectedIndex]);
            
            if (seciliHesapNo1 == 1267)
            {
                hesap2.ParaYatırma(Convert.ToDecimal(paraYatirmaTutar.Text));
                Islem2.Detay = "Para yatırma işlemi";
                Islem2.HesapNo = 1267;
                Islem2.IslemTarihi = DateTime.Now;
                Islem2.Tutar = Convert.ToInt32(paraYatirmaTutar.Text);
                pYatirma2_kaydet += Islem2.IslemTarihi + "  " + Islem2.Detay + "  " + "Miktar:" + Islem2.Tutar + "TL" + "  \n   ";

                MessageBox.Show("Hesabınıza " + paraYatirmaTutar.Text + " TL para yatmıştır." +
                    "\nGüncel Bakiyeniz: " + hesap2.Bakiye.ToString());
            }

            else if (seciliHesapNo2 == 2402)
            {
                hesap3.ParaYatırma(Convert.ToDecimal(paraYatirmaTutar.Text));
                Islem3.Detay = "Para yatırma işlemi";
                Islem3.HesapNo = 2402;
                Islem3.IslemTarihi = DateTime.Now;
                Islem3.Tutar = Convert.ToInt32(paraYatirmaTutar.Text);
                pYatirma3_kaydet += Islem3.IslemTarihi + "  " + Islem3.Detay + "  " + "Miktar:" + Islem3.Tutar + "TL" + "  \n   ";

                MessageBox.Show("Hesabınıza " + paraYatirmaTutar.Text + " TL para yatmıştır." +
                    "\nGüncel Bakiyeniz: " + hesap3.Bakiye.ToString());
            }

            else if (seciliHesapNo3 == 3267)
            {
                hesap4.ParaYatırma(Convert.ToDecimal(paraYatirmaTutar.Text));
                Islem4.Detay = "Para yatırma işlemi";
                Islem4.HesapNo = 3267;
                Islem4.IslemTarihi = DateTime.Now;
                Islem4.Tutar = Convert.ToInt32(paraYatirmaTutar.Text);
                pYatirma4_kaydet += Islem4.IslemTarihi + "  " + Islem4.Detay + "  " + "Miktar:" + Islem4.Tutar + "TL" + "  \n   ";

                MessageBox.Show("Hesabınıza " + paraYatirmaTutar.Text + " TL para yatmıştır." +
                    "\nGüncel Bakiyeniz: " + hesap4.Bakiye.ToString());
            }

            else if (seciliHesapNo4 == 4002)
            {
                hesap5.ParaYatırma(Convert.ToDecimal(paraYatirmaTutar.Text));
                Islem5.Detay = "Para yatırma işlemi";
                Islem5.HesapNo = 4002;
                Islem5.IslemTarihi = DateTime.Now;
                Islem5.Tutar = Convert.ToInt32(paraYatirmaTutar.Text);
                pYatirma5_kaydet += Islem5.IslemTarihi + "  " + Islem5.Detay + "  " + "Miktar:" + Islem5.Tutar + "TL" + "  \n   ";

                MessageBox.Show("Hesabınıza " + paraYatirmaTutar.Text + " TL para yatmıştır." +
                    "\nGüncel Bakiyeniz: " + hesap5.Bakiye.ToString());
            }
            else 
                {
                hesapAcma.hesap6.ParaYatırma(Convert.ToDecimal(paraYatirmaTutar.Text));
                Islem6.Detay = "Para yatırma işlemi";
                Islem6.HesapNo = hesapAcma.hesap6.HesapNo;
                Islem6.IslemTarihi = DateTime.Now;
                Islem6.Tutar = Convert.ToInt32(paraYatirmaTutar.Text);
                pYatirma6_kaydet += Islem6.IslemTarihi + "  " + Islem6.Detay + "  " + "Miktar:" + Islem6.Tutar + "TL" + "  \n   ";

                MessageBox.Show("Hesabınıza " + paraYatirmaTutar.Text + " TL para yatmıştır." +
                        "\nGüncel Bakiyeniz: " + hesapAcma.hesap6.Bakiye.ToString());
                }
            hesap2.Tutar_Validasyon(Convert.ToDecimal(paraYatirmaTutar.Text));
            hesap3.Tutar_Validasyon(Convert.ToDecimal(paraYatirmaTutar.Text));
            hesap4.Tutar_Validasyon(Convert.ToDecimal(paraYatirmaTutar.Text));
            hesap5.Tutar_Validasyon(Convert.ToDecimal(paraYatirmaTutar.Text));
            hesapAcma.hesap6.Tutar_Validasyon(Convert.ToDecimal(paraYatirmaTutar.Text));
        }



        

    private void paraYatirmaHesapNo_SelectedIndexChanged(object sender, EventArgs e)
        {

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
