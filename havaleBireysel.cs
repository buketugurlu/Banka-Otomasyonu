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
    public partial class havaleBireysel : Form
    {
        public havaleBireysel()
        {
            InitializeComponent();
        }
        public int seciliHesapNo1;
        public int seciliHesapNo2;
        public int seciliHesapNo3;
        public int seciliHesapNo4;
        public int seciliHesapNo6;

        public int seciliHesapNo7;
        public int seciliHesapNo8;
        public int seciliHesapNo9;
        public int seciliHesapNo10;
        public int seciliHesapNo12;

        public Hesap hesap2 = new Hesap() { Bakiye = 400, hesapNo_kaydet = 1267 };
        public Hesap hesap3 = new Hesap() { Bakiye = 400, hesapNo_kaydet = 2402 };
        public Hesap hesap4 = new Hesap() { Bakiye = 400, hesapNo_kaydet = 3267 };
        public Hesap hesap5 = new Hesap() { Bakiye = 400, hesapNo_kaydet = 4002 };
        public Musteri musteri = new Musteri();

        public IslemBilgisi Islem2 = new IslemBilgisi();
        public IslemBilgisi Islem3 = new IslemBilgisi();
        public IslemBilgisi Islem4 = new IslemBilgisi();
        public IslemBilgisi Islem5 = new IslemBilgisi();
        public IslemBilgisi Islem6 = new IslemBilgisi();

        public static string havaleB2_kaydet = "";
        public static string havaleB3_kaydet = "";
        public static string havaleB4_kaydet = "";
        public static string havaleB5_kaydet = "";
        public static string havaleB6_kaydet = "";
        private void havale_Load(object sender, EventArgs e)
        {
            comboBoxHavaleYapanBireysel.Items.Add("1267");
            comboBoxHavaleYapanBireysel.Items.Add("2402");
            comboBoxHavaleYapanBireysel.Items.Add("3267");
            comboBoxHavaleYapanBireysel.Items.Add("4002");

            foreach (int no in hesapAcma.musteri6.HesapNumaralarıListesi)
            {
                comboBoxHavaleYapanBireysel.Items.Add(no);
            }
            havaleBireyselHesapNo.Items.Add("1267");
            havaleBireyselHesapNo.Items.Add("2402");
            havaleBireyselHesapNo.Items.Add("3267");
            havaleBireyselHesapNo.Items.Add("4002");

            foreach (int no in hesapAcma.musteri6.HesapNumaralarıListesi)
            {
                havaleBireyselHesapNo.Items.Add(no);
            }
        }

        private void havaleOnayla_Click(object sender, EventArgs e)
        {

            hesap2.hesapNo_kaydet = seciliHesapNo1;
            hesap3.hesapNo_kaydet = seciliHesapNo2;
            hesap3.hesapNo_kaydet = seciliHesapNo3;
            hesap4.hesapNo_kaydet = seciliHesapNo4;
            hesapAcma.hesap6.hesapNo_kaydet = seciliHesapNo6;


            seciliHesapNo1 = Convert.ToInt32(comboBoxHavaleYapanBireysel.Items[comboBoxHavaleYapanBireysel.SelectedIndex]);
            seciliHesapNo2 = Convert.ToInt32(comboBoxHavaleYapanBireysel.Items[comboBoxHavaleYapanBireysel.SelectedIndex]);
            seciliHesapNo3 = Convert.ToInt32(comboBoxHavaleYapanBireysel.Items[comboBoxHavaleYapanBireysel.SelectedIndex]);
            seciliHesapNo4 = Convert.ToInt32(comboBoxHavaleYapanBireysel.Items[comboBoxHavaleYapanBireysel.SelectedIndex]);


            hesap2.hesapNo_kaydet = seciliHesapNo7;
            hesap3.hesapNo_kaydet = seciliHesapNo8;
            hesap3.hesapNo_kaydet = seciliHesapNo9;
            hesap4.hesapNo_kaydet = seciliHesapNo10;
            hesapAcma.hesap6.hesapNo_kaydet = seciliHesapNo12;

            seciliHesapNo7 = Convert.ToInt32(havaleBireyselHesapNo.Items[havaleBireyselHesapNo.SelectedIndex]);
            seciliHesapNo8 = Convert.ToInt32(havaleBireyselHesapNo.Items[havaleBireyselHesapNo.SelectedIndex]);
            seciliHesapNo9 = Convert.ToInt32(havaleBireyselHesapNo.Items[havaleBireyselHesapNo.SelectedIndex]);
            seciliHesapNo10 = Convert.ToInt32(havaleBireyselHesapNo.Items[havaleBireyselHesapNo.SelectedIndex]);

            decimal Tutar_havale = Convert.ToDecimal(havaleTutar.Text);

            if (seciliHesapNo1 == 1267)
            {
                if (seciliHesapNo7 == 1267)
                {
                    MessageBox.Show("Kendi hesabınıza havale yapamazsınız!!!!");
                }

                else if (seciliHesapNo8 == 2402)
                {
                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                    bireyselMusteri.HavaleYap(hesap2, Tutar_havale);
                    hesap3.Havale(hesap3, Tutar_havale);

                    Islem2.Detay = "Havale işlemi (bireysel hesap)";
                    Islem2.HesapNo = 1267;
                    Islem2.IslemTarihi = DateTime.Now;
                    Islem2.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB2_kaydet += Islem2.IslemTarihi + "  " + Islem2.Detay + "  " + "Miktar:" + Islem2.Tutar + "TL" + "  \n   ";

                    Islem3.Detay = "Hesaba gelen havale işlemi";
                    Islem3.HesapNo = 2402;
                    Islem3.IslemTarihi = DateTime.Now;
                    Islem3.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB3_kaydet += Islem3.IslemTarihi + "  " + Islem3.Detay + "  " + "Miktar:" + Islem3.Tutar + "TL" + "  \n   ";

                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesap2.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesap3.Bakiye.ToString());

                }

                else if (seciliHesapNo9 == 3267)
                {
                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                    bireyselMusteri.HavaleYap(hesap2, Tutar_havale);
                    hesap4.Havale(hesap4, Tutar_havale);

                    Islem2.Detay = "Havale işlemi (bireysel hesap)";
                    Islem2.HesapNo = 1267;
                    Islem2.IslemTarihi = DateTime.Now;
                    Islem2.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB2_kaydet += Islem2.IslemTarihi + "  " + Islem2.Detay + "  " + "Miktar:" + Islem2.Tutar + "TL" + "  \n   ";

                    Islem4.Detay = "Hesaba gelen havale işlemi";
                    Islem4.HesapNo = 3267;
                    Islem4.IslemTarihi = DateTime.Now;
                    Islem4.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB4_kaydet += Islem4.IslemTarihi + "  " + Islem4.Detay + "   " + "Miktar:" + Islem4.Tutar + "TL" + "\n ";

                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesap2.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesap4.Bakiye.ToString());

                }

                else if (seciliHesapNo10 == 4002)
                {
                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                    bireyselMusteri.HavaleYap(hesap2, Tutar_havale);
                    hesap5.Havale(hesap5, Tutar_havale);

                    Islem2.Detay = "Havale işlemi (bireysel hesap)";
                    Islem2.HesapNo = 1267;
                    Islem2.IslemTarihi = DateTime.Now;
                    Islem2.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB2_kaydet += Islem2.IslemTarihi + "  " + Islem2.Detay + "  " + "Miktar:" + Islem2.Tutar + "TL" + "  \n   ";

                    Islem5.Detay = "Hesaba gelen havale işlemi";
                    Islem5.HesapNo = 4002;
                    Islem5.IslemTarihi = DateTime.Now;
                    Islem5.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB5_kaydet += Islem5.IslemTarihi + "  " + Islem5.Detay + "   " + "Miktar:" + Islem5.Tutar + "TL" + "\n ";

                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesap2.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesap5.Bakiye.ToString());

                }
                else
                {
                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                    bireyselMusteri.HavaleYap(hesap2, Tutar_havale);
                    hesapAcma.hesap6.Havale(hesapAcma.hesap6, Tutar_havale);

                    Islem2.Detay = "Havale işlemi (bireysel hesap)";
                    Islem2.HesapNo = 1267;
                    Islem2.IslemTarihi = DateTime.Now;
                    Islem2.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB2_kaydet += Islem2.IslemTarihi + "  " + Islem2.Detay + "  " + "Miktar:" + Islem2.Tutar + "TL" + "  \n   ";

                    Islem6.Detay = "Hesaba gelen havale işlemi";
                    Islem6.HesapNo = hesapAcma.hesap6.HesapNo;
                    Islem6.IslemTarihi = DateTime.Now;
                    Islem6.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB6_kaydet += Islem6.IslemTarihi + "  " + Islem6.Detay + "   " + "Miktar:" + Islem6.Tutar + "TL" + "\n ";

                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesap2.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesapAcma.hesap6.Bakiye.ToString());
                }

            }



            else if (seciliHesapNo2 == 2402)
            {

                if (seciliHesapNo8 == 2402)
                {
                    MessageBox.Show("Kendi hesabınıza havale yapamazsınız!!!!");
                }

                else if (seciliHesapNo7 == 1267)
                {

                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                    bireyselMusteri.HavaleYap(hesap3, Tutar_havale);
                    hesap2.Havale(hesap2, Tutar_havale);

                    Islem3.Detay = "Havale işlemi (bireysel hesap)";
                    Islem3.HesapNo = 2402;
                    Islem3.IslemTarihi = DateTime.Now;
                    Islem3.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB3_kaydet += Islem3.IslemTarihi + "  " + Islem3.Detay + "  " + "Miktar:" + Islem3.Tutar + "TL" + "  \n   ";

                    Islem2.Detay = "Hesaba gelen havale işlemi";
                    Islem2.HesapNo = 1267;
                    Islem2.IslemTarihi = DateTime.Now;
                    Islem2.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB2_kaydet += Islem2.IslemTarihi + "  " + Islem2.Detay + "   " + "Miktar:" + Islem2.Tutar + "TL" + "\n ";

                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesap3.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesap2.Bakiye.ToString());
                }

                else if (seciliHesapNo9 == 3267)
                {
                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                    bireyselMusteri.HavaleYap(hesap3, Tutar_havale);
                    hesap4.Havale(hesap4, Tutar_havale);

                    Islem3.Detay = "Havale işlemi (bireysel hesap)";
                    Islem3.HesapNo = 2402;
                    Islem3.IslemTarihi = DateTime.Now;
                    Islem3.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB3_kaydet += Islem3.IslemTarihi + "  " + Islem3.Detay + "  " + "Miktar:" + Islem3.Tutar + "TL" + "  \n   ";

                    Islem4.Detay = "Hesaba gelen havale işlemi";
                    Islem4.HesapNo = 3267;
                    Islem4.IslemTarihi = DateTime.Now;
                    Islem4.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB4_kaydet += Islem4.IslemTarihi + "  " + Islem4.Detay + "   " + "Miktar:" + Islem4.Tutar + "TL" + "\n ";

                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesap3.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesap4.Bakiye.ToString());

                }

                else if (seciliHesapNo10 == 4002)
                {
                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                    bireyselMusteri.HavaleYap(hesap3, Tutar_havale);
                    hesap5.Havale(hesap5, Tutar_havale);

                    Islem3.Detay = "Havale işlemi (bireysel hesap)";
                    Islem3.HesapNo = 2402;
                    Islem3.IslemTarihi = DateTime.Now;
                    Islem3.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB3_kaydet += Islem3.IslemTarihi + "  " + Islem3.Detay + "  " + "Miktar:" + Islem3.Tutar + "TL" + "  \n   ";

                    Islem5.Detay = "Hesaba gelen havale işlemi";
                    Islem5.HesapNo = 4002;
                    Islem5.IslemTarihi = DateTime.Now;
                    Islem5.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB5_kaydet += Islem5.IslemTarihi + "  " + Islem5.Detay + "   " + "Miktar:" + Islem5.Tutar + "TL" + "\n ";

                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesap3.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesap5.Bakiye.ToString());

                }
                else
                {
                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                   bireyselMusteri.HavaleYap(hesap3, Tutar_havale);
                    hesapAcma.hesap6.Havale(hesapAcma.hesap6, Tutar_havale);

                    Islem3.Detay = "Havale işlemi (bireysel hesap)";
                    Islem3.HesapNo = 2402;
                    Islem3.IslemTarihi = DateTime.Now;
                    Islem3.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB3_kaydet += Islem3.IslemTarihi + "  " + Islem3.Detay + "  " + "Miktar:" + Islem3.Tutar + "TL" + "  \n   ";

                    Islem6.Detay = "Hesaba gelen havale işlemi";
                    Islem6.HesapNo = hesapAcma.hesap6.HesapNo;
                    Islem6.IslemTarihi = DateTime.Now;
                    Islem6.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB6_kaydet += Islem6.IslemTarihi + "  " + Islem6.Detay + "   " + "Miktar:" + Islem6.Tutar + "TL" + "\n ";

                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesap3.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesapAcma.hesap6.Bakiye.ToString());
                }

            }


            else if (seciliHesapNo3 == 3267)
            {

                if (seciliHesapNo8 == 2402)
                {

                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                    bireyselMusteri.HavaleYap(hesap4, Tutar_havale);
                    hesap3.Havale(hesap3, Tutar_havale);

                    Islem4.Detay = "Havale işlemi (bireysel hesap)";
                    Islem4.HesapNo = 3267;
                    Islem4.IslemTarihi = DateTime.Now;
                    Islem4.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB4_kaydet += Islem4.IslemTarihi + "  " + Islem4.Detay + "  " + "Miktar:" + Islem4.Tutar + "TL" + "  \n   ";

                    Islem3.Detay = "Hesaba gelen havale işlemi";
                    Islem3.HesapNo = 2402;
                    Islem3.IslemTarihi = DateTime.Now;
                    Islem3.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB3_kaydet += Islem3.IslemTarihi + "  " + Islem3.Detay + "  " + "Miktar:" + Islem3.Tutar + "TL" + "  \n   ";

                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesap4.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesap3.Bakiye.ToString());


                }

                else if (seciliHesapNo7 == 1267)
                {

                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                    bireyselMusteri.HavaleYap(hesap4, Tutar_havale);
                    hesap2.Havale(hesap2, Tutar_havale);

                    Islem4.Detay = "Havale işlemi (bireysel hesap)";
                    Islem4.HesapNo = 3267;
                    Islem4.IslemTarihi = DateTime.Now;
                    Islem4.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB4_kaydet += Islem4.IslemTarihi + "  " + Islem4.Detay + "  " + "Miktar:" + Islem4.Tutar + "TL" + "  \n   ";

                    Islem2.Detay = "Hesaba gelen havale işlemi";
                    Islem2.HesapNo = 1267;
                    Islem2.IslemTarihi = DateTime.Now;
                    Islem2.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB2_kaydet += Islem2.IslemTarihi + "  " + Islem2.Detay + "   " + "Miktar:" + Islem2.Tutar + "TL" + "\n ";

                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesap4.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesap2.Bakiye.ToString());
                }

                else if (seciliHesapNo9 == 3267)
                {
                    MessageBox.Show("Kendi hesabınıza havale yapamazsınız!!!!");

                }

                else if (seciliHesapNo10 == 4002)
                {
                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                    bireyselMusteri.HavaleYap(hesap4, Tutar_havale);
                    hesap5.Havale(hesap5, Tutar_havale);

                    Islem4.Detay = "Havale işlemi (bireysel hesap)";
                    Islem4.HesapNo = 3267;
                    Islem4.IslemTarihi = DateTime.Now;
                    Islem4.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB4_kaydet += Islem4.IslemTarihi + "  " + Islem4.Detay + "  " + "Miktar:" + Islem4.Tutar + "TL" + "  \n   ";

                    Islem5.Detay = "Hesaba gelen havale işlemi";
                    Islem5.HesapNo = 4002;
                    Islem5.IslemTarihi = DateTime.Now;
                    Islem5.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB5_kaydet += Islem5.IslemTarihi + "  " + Islem5.Detay + "   " + "Miktar:" + Islem5.Tutar + "TL" + "\n ";

                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesap4.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesap5.Bakiye.ToString());

                }
                else
                {
                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                    bireyselMusteri.HavaleYap(hesap4, Tutar_havale);
                    hesapAcma.hesap6.Havale(hesapAcma.hesap6, Tutar_havale);

                    Islem4.Detay = "Havale işlemi (bireysel hesap)";
                    Islem4.HesapNo = 3267;
                    Islem4.IslemTarihi = DateTime.Now;
                    Islem4.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB4_kaydet += Islem4.IslemTarihi + "  " + Islem4.Detay + "  " + "Miktar:" + Islem4.Tutar + "TL" + "  \n   ";

                    Islem6.Detay = "Hesaba gelen havale işlemi";
                    Islem6.HesapNo = hesapAcma.hesap6.HesapNo;
                    Islem6.IslemTarihi = DateTime.Now;
                    Islem6.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB6_kaydet += Islem6.IslemTarihi + "  " + Islem6.Detay + "   " + "Miktar:" + Islem6.Tutar + "TL" + "\n ";

                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesap4.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesapAcma.hesap6.Bakiye.ToString());
                }

            }

            else if (seciliHesapNo4 == 4002)
            {

                if (seciliHesapNo8 == 2402)
                {

                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                    bireyselMusteri.HavaleYap(hesap5, Tutar_havale);
                    hesap3.Havale(hesap3, Tutar_havale);

                    Islem5.Detay = "Havale işlemi (bireysel hesap)";
                    Islem5.HesapNo = 4002;
                    Islem5.IslemTarihi = DateTime.Now;
                    Islem5.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB5_kaydet += Islem5.IslemTarihi + "  " + Islem5.Detay + "  " + "Miktar:" + Islem5.Tutar + "TL" + "  \n   ";

                    Islem3.Detay = "Hesaba gelen havale işlemi";
                    Islem3.HesapNo = 2402;
                    Islem3.IslemTarihi = DateTime.Now;
                    Islem3.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB3_kaydet += Islem3.IslemTarihi + "  " + Islem3.Detay + "  " + "Miktar:" + Islem3.Tutar + "TL" + "  \n   ";

                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesap5.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesap3.Bakiye.ToString());
                }

                else if (seciliHesapNo7 == 1267)
                {

                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                    bireyselMusteri.HavaleYap(hesap5, Tutar_havale);
                    hesap2.Havale(hesap2, Tutar_havale);

                    Islem5.Detay = "Havale işlemi (bireysel hesap)";
                    Islem5.HesapNo = 4002;
                    Islem5.IslemTarihi = DateTime.Now;
                    Islem5.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB5_kaydet += Islem5.IslemTarihi + "  " + Islem5.Detay + "  " + "Miktar:" + Islem5.Tutar + "TL" + "  \n   ";

                    Islem2.Detay = "Hesaba gelen havale işlemi";
                    Islem2.HesapNo = 1267;
                    Islem2.IslemTarihi = DateTime.Now;
                    Islem2.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB2_kaydet += Islem2.IslemTarihi + "  " + Islem2.Detay + "   " + "Miktar:" + Islem2.Tutar + "TL" + "\n ";

                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesap5.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesap2.Bakiye.ToString());
                }

                else if (seciliHesapNo9 == 3267)
                {
                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                    bireyselMusteri.HavaleYap(hesap5, Tutar_havale);
                    hesap4.Havale(hesap4, Tutar_havale);

                    Islem5.Detay = "Havale işlemi (bireysel hesap)";
                    Islem5.HesapNo = 4002;
                    Islem5.IslemTarihi = DateTime.Now;
                    Islem5.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB5_kaydet += Islem5.IslemTarihi + "  " + Islem5.Detay + "  " + "Miktar:" + Islem5.Tutar + "TL" + "  \n   ";

                    Islem4.Detay = "Hesaba gelen havale işlemi";
                    Islem4.HesapNo = 3267;
                    Islem4.IslemTarihi = DateTime.Now;
                    Islem4.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB4_kaydet += Islem4.IslemTarihi + "  " + Islem4.Detay + "   " + "Miktar:" + Islem4.Tutar + "TL" + "\n ";

                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesap5.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesap4.Bakiye.ToString());


                }

                else if (seciliHesapNo10 == 4002)
                {
                    MessageBox.Show("Kendi hesabınıza havale yapamazsınız!!!!");
                }
                else
                {
                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                   bireyselMusteri.HavaleYap(hesap5, Tutar_havale);
                    hesapAcma.hesap6.Havale(hesapAcma.hesap6, Tutar_havale);

                    Islem5.Detay = "Havale işlemi (bireysel hesap)";
                    Islem5.HesapNo = 4002;
                    Islem5.IslemTarihi = DateTime.Now;
                    Islem5.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB5_kaydet += Islem5.IslemTarihi + "  " + Islem5.Detay + "  " + "Miktar:" + Islem5.Tutar + "TL" + "  \n   ";

                    Islem6.Detay = "Hesaba gelen havale işlemi";
                    Islem6.HesapNo = hesapAcma.hesap6.HesapNo;
                    Islem6.IslemTarihi = DateTime.Now;
                    Islem6.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB6_kaydet += Islem6.IslemTarihi + "  " + Islem6.Detay + "   " + "Miktar:" + Islem6.Tutar + "TL" + "\n ";

                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesap5.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesapAcma.hesap6.Bakiye.ToString());
                }

            }
            else
            {
                if (seciliHesapNo8 == 2402)
                {

                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                    bireyselMusteri.HavaleYap(hesapAcma.hesap6, Tutar_havale);
                    hesap3.Havale(hesap3, Tutar_havale);

                    Islem6.Detay = "Havale işlemi (bireysel hesap)";
                    Islem6.HesapNo = hesapAcma.hesap6.HesapNo;
                    Islem6.IslemTarihi = DateTime.Now;
                    Islem6.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB6_kaydet += Islem6.IslemTarihi + "  " + Islem6.Detay + "  " + "Miktar:" + Islem6.Tutar + "TL" + "  \n   ";

                    Islem3.Detay = "Hesaba gelen havale işlemi";
                    Islem3.HesapNo = 2402;
                    Islem3.IslemTarihi = DateTime.Now;
                    Islem3.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB3_kaydet += Islem3.IslemTarihi + "  " + Islem3.Detay + "  " + "Miktar:" + Islem3.Tutar + "TL" + "  \n   ";
                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesapAcma.hesap6.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesap3.Bakiye.ToString());
                }

                else if (seciliHesapNo7 == 1267)
                {

                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                    bireyselMusteri.HavaleYap(hesapAcma.hesap6, Tutar_havale);
                    hesap2.Havale(hesap2, Tutar_havale);

                    Islem6.Detay = "Havale işlemi (bireysel hesap)";
                    Islem6.HesapNo = hesapAcma.hesap6.HesapNo;
                    Islem6.IslemTarihi = DateTime.Now;
                    Islem6.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB6_kaydet += Islem6.IslemTarihi + "  " + Islem6.Detay + "  " + "Miktar:" + Islem6.Tutar + "TL" + "  \n   ";

                    Islem2.Detay = "Hesaba gelen havale işlemi";
                    Islem2.HesapNo = 1267;
                    Islem2.IslemTarihi = DateTime.Now;
                    Islem2.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB2_kaydet += Islem2.IslemTarihi + "  " + Islem2.Detay + "   " + "Miktar:" + Islem2.Tutar + "TL" + "\n ";

                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesapAcma.hesap6.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesap2.Bakiye.ToString());
                }

                else if (seciliHesapNo9 == 3267)
                {

                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                    bireyselMusteri.HavaleYap(hesapAcma.hesap6, Tutar_havale);
                    hesap4.Havale(hesap4, Tutar_havale);

                    Islem6.Detay = "Havale işlemi (bireysel hesap)";
                    Islem6.HesapNo = hesapAcma.hesap6.HesapNo;
                    Islem6.IslemTarihi = DateTime.Now;
                    Islem6.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB6_kaydet += Islem6.IslemTarihi + "  " + Islem6.Detay + "  " + "Miktar:" + Islem6.Tutar + "TL" + "  \n   ";

                    Islem4.Detay = "Hesaba gelen havale işlemi";
                    Islem4.HesapNo = 3267;
                    Islem4.IslemTarihi = DateTime.Now;
                    Islem4.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB4_kaydet += Islem4.IslemTarihi + "  " + Islem4.Detay + "   " + "Miktar:" + Islem4.Tutar + "TL" + "\n ";

                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesapAcma.hesap6.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesap4.Bakiye.ToString());
                }
                else if (seciliHesapNo10 == 4002)
                {
                    BireyselMusteri bireyselMusteri = new BireyselMusteri();
                   bireyselMusteri.HavaleYap(hesapAcma.hesap6, Tutar_havale);
                    hesap5.Havale(hesap5, Tutar_havale);

                    Islem6.Detay = "Havale işlemi (bireysel hesap)";
                    Islem6.HesapNo = hesapAcma.hesap6.HesapNo;
                    Islem6.IslemTarihi = DateTime.Now;
                    Islem6.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB6_kaydet += Islem6.IslemTarihi + "  " + Islem6.Detay + "  " + "Miktar:" + Islem6.Tutar + "TL" + "  \n   ";

                    Islem5.Detay = "Hesaba gelen havale işlemi";
                    Islem5.HesapNo = 4002;
                    Islem5.IslemTarihi = DateTime.Now;
                    Islem5.Tutar = Convert.ToInt32(havaleTutar.Text);
                    havaleB5_kaydet += Islem5.IslemTarihi + "  " + Islem5.Detay + "   " + "Miktar:" + Islem5.Tutar + "TL" + "\n ";

                    MessageBox.Show("Hesabınızda kalan bakiye miktarı : " + hesapAcma.hesap6.Bakiye.ToString() + "\n"
                        + "Alıcı hesabın bakiye miktarı : " + hesap5.Bakiye.ToString());
                }
            }
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

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}





