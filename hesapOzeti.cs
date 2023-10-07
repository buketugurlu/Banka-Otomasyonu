using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banka_otomasyonu_210601028_210601048
{
    public partial class hesapOzeti : Form
    {
        public hesapOzeti()
        {
            InitializeComponent();
        }

        private void hesapOzeti_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("1267");
            comboBox1.Items.Add("2402");
            comboBox1.Items.Add("3267");
            comboBox1.Items.Add("4002");

            foreach (int no in hesapAcma.musteri6.HesapNumaralarıListesi)
            {
                comboBox1.Items.Add(no);
            }

            comboBoxTarih.Items.Add("01/01/2023-15/01/2023");
            comboBoxTarih.Items.Add("16/01/2023-01/02/2023");
            comboBoxTarih.Items.Add("02/02/2023-15/02/2023");
            comboBoxTarih.Items.Add("16/02/2023-01/03/2023");
            comboBoxTarih.Items.Add("10/01/2023");
        }
        private void bttnHesapOzetiGoruntule_Click(object sender, EventArgs e)
        {

            HesapÖzetiListeleri hesapÖzetiListeleri = new HesapÖzetiListeleri();

            string turusec = comboBoxTarih.SelectedItem.ToString();
            string secim = comboBox1.Items[comboBox1.SelectedIndex].ToString();


            if (secim == "1267")
            {
                switch (turusec)
                {
                    case "01/01/2023-15/01/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("1267 nolu hesabın 01/01/2023-15/01/2023 tarihlerindeki hesap hareketleri\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("01/01/2023   20:38  'Para Çekme'       Miktar:200 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("02/01/2023   09:20  'Para Yatırma'     Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("05/01/2023   19:00  'Para Çekme'       Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("07/01/2023   09:20  'Havale Yapma'     Miktar:200 TL   Kime(HesapNo):2402 \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("08/01/2023   09:20  'Havale ile Gelen'   Miktar:500 TL   Kimden(Hesap No):1267\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("13/01/2023   15:20  'Para Yatırma'     Miktar:2300 TL \n ");
                        break;

                    case "16/01/2023-01/02/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("1267 nolu hesabın 16/01/2023-01/02/2023 tarihlerindeki hesap hareketleri\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("15/01/2023  20:38 'Para Yatırma' Miktar:500 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("17/01/2023  09:20 'Para Çekme' Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("20/01/2023  19:00 'Para Çekme' Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("21/01/2023  09:20 'Havale Yapma' Miktar:200 TL  Kime(HesapNo):2402 \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("27/01/2023  09:20 'Havale ile Gelen' Miktar:500 TL Kimden(Hesap No):1267\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("30/01/2023  15:20 'Para Yatırma' Miktar:2300 TL \n ");
                        break;


                    case "02/02/2023-15/02/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("1267 nolu hesabın 02/02/2023-15/02/2023 tarihlerindeki hesap hareketleri\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("01/02/2023  20:38 'Para Yatırma' Miktar:500 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("02/02/2023  09:20 'Para Çekme' Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("03/02/2023  19:50 'Para Çekme' Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("05/02/2023  19:00 'Para Çekme' Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("07/02/2023  09:20 'Havale Yapma' Miktar:200 TL  Kime(HesapNo):2402 \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("08/02/2023  09:20 'Havale ile Gelen' Miktar:500 TL Kimden(Hesap No):1267\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("09/02/2023  19:00 'Para Çekme' Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("13/02/2023  15:20 'Para Yatırma' Miktar:2300 TL \n ");
                        break;


                    case "16/02/2023-01/03/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("1267 nolu hesabın 16/02/2023-01/03/2023 tarihlerindeki hesap hareketleri\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("15/02/2023  20:38 'Para Yatırma' Miktar:500 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("17/02/2023  09:20 'Para Çekme' Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("18/02/2023  19:00 'Para Çekme' Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("20/02/2023  09:20 'Havale Yapma' Miktar:200 TL  Kime(HesapNo):2402 \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("29/02/2023  09:20 'Havale ile Gelen' Miktar:500 TL Kimden(Hesap No):1267\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("30/02/2023  15:20 'Para Yatırma' Miktar:2300 TL \n ");
                        break;

                    case "10/01/2023":                      
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("1267 nolu hesabın  " + DateTime.Now + "  tarihlerindeki hesap hareketleri \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(paraCekme.islem2_kaydet);
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(paraYatırma.pYatirma2_kaydet);
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(havaleTicari.havaleT2_kaydet);
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(havaleBireysel.havaleB2_kaydet);
                        break;
                }
                hesapÖzetiListeleri.Show();
            }
            else if (secim == "2402")
            {
                switch (turusec)
                {
                    case "01/01/2023-15/01/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("2402 nolu hesabın 01/01/2023-15/01/2023 tarihlerindeki hesap hareketleri\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("01/01/2023  20:38 'Para Çekme' Miktar:200 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("02/01/2023  09:20 'Para Yatırma' Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("05/01/2023  19:00 'Para Çekme' Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("07/01/2023  09:20 'Havale ile Gelen' Miktar:200 TL  Kimden(HesapNo):1267 \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("08/01/2023  09:20 'Havale Yapma' Miktar:500 TL Kime(Hesap No):1267\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("13/01/2023  15:20 'Para Yatırma' Miktar:2300 TL \n ");
                        break;

                    case "16/01/2023-01/02/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("2402 nolu hesabın 16/01/2023-01/02/2023 tarihlerindeki hesap hareketleri\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("15/01/2023  20:38 'Para Yatırma' Miktar:500 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("17/01/2023  09:20 'Para Çekme' Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("20/01/2023  19:00 'Para Çekme' Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("21/01/2023  09:20 'Havale ile Gelen' Miktar:200 TL  Kimden(HesapNo):1267 \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("27/01/2023  09:20 'Havale Yapma' Miktar:500 TL Kime(Hesap No):1267\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("30/01/2023  15:20 'Para Yatırma' Miktar:2300 TL \n ");
                        break;


                    case "02/02/2023-15/02/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("2402 nolu hesabın 02/02/2023-15/02/2023 tarihlerindeki hesap hareketleri\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("01/02/2023  20:38 'Para Yatırma' Miktar:500 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("02/02/2023  09:20 'Para Çekme' Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("03/02/2023  19:50 'Para Çekme' Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("05/02/2023  19:00 'Para Çekme' Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("07/02/2023  09:20 'Havale ile Gelen' Miktar:200 TL  Kimden(HesapNo):1267 \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("08/02/2023  09:20 'Havale Yapma' Miktar:500 TL Kime(Hesap No):1267\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("09/02/2023  19:00 'Para Çekme' Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("13/02/2023  15:20 'Para Yatırma' Miktar:2300 TL \n ");
                        break;


                    case "16/02/2023-01/03/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("2402 nolu hesabın 16/02/2023-01/03/2023 tarihlerindeki hesap hareketleri\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("15/02/2023  20:38 'Para Yatırma' Miktar:500 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("17/02/2023  09:20 'Para Çekme' Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("18/02/2023  19:00 'Para Çekme' Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("20/02/2023  09:20 'Havale ile Gelen' Miktar:200 TL  Kimden(HesapNo):1267 \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("29/02/2023  09:20 'Havale Yapma' Miktar:500 TL Kime(Hesap No):1267\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("30/02/2023  15:20 'Para Yatırma' Miktar:2300 TL \n ");
                        break;

                    case "10/01/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("2402 nolu hesabın  " + DateTime.Now + "  tarihlerindeki hesap hareketleri \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(paraCekme.islem3_kaydet);                    
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(paraYatırma.pYatirma3_kaydet);
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(havaleTicari.havaleT3_kaydet);
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(havaleBireysel.havaleB3_kaydet);
                        break;
                }
                hesapÖzetiListeleri.Show();
            }


            else if (secim == "3267")
            {
                switch (turusec)
                {
                    case "01/01/2023-15/01/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("3267 nolu hesabın 01/01/2023-15/01/2023 tarihlerindeki hesap hareketleri\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("01/01/2023  20:38 'Para Çekme' Miktar:200 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("02/01/2023  09:20 'Para Yatırma' Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("05/01/2023  19:00 'Para Çekme' Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("07/01/2023  09:20 'Havale Yapma' Miktar:200 TL  Kime(HesapNo):4002 \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("08/01/2023  09:20 'Havale ile Gelen' Miktar:500 TL Kimden(Hesap No):4002\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("13/01/2023  15:20 'Para Yatırma' Miktar:2300 TL \n ");
                        break;

                    case "16/01/2023-01/02/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("3267 nolu hesabın 16/01/2023-01/02/2023 tarihlerindeki hesap hareketleri\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("15/01/2023  20:38 'Para Yatırma' Miktar:500 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("17/01/2023  09:20 'Para Çekme' Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("20/01/2023  19:00 'Para Çekme' Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("21/01/2023  09:20 'Havale Yapma' Miktar:200 TL  Kime(HesapNo):4002 \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("27/01/2023  09:20 'Havale ile Gelen' Miktar:500 TL Kimden(Hesap No):4002\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("30/01/2023  15:20 'Para Yatırma' Miktar:2300 TL \n ");
                        break;


                    case "02/02/2023-15/02/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("3267 nolu hesabın 02/02/2023-15/02/2023 tarihlerindeki hesap hareketleri\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("01/02/2023  20:38 'Para Yatırma' Miktar:500 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("02/02/2023  09:20 'Para Çekme' Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("03/02/2023  19:50 'Para Çekme' Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("05/02/2023  19:00 'Para Çekme' Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("07/02/2023  09:20 'Havale Yapma' Miktar:200 TL  Kime(HesapNo):4002 \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("08/02/2023  09:20 'Havale ile Gelen' Miktar:500 TL Kimden(Hesap No):4002\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("09/02/2023  19:00 'Para Çekme' Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("13/02/2023  15:20 'Para Yatırma' Miktar:2300 TL \n ");
                        break;


                    case "16/02/2023-01/03/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("3267 nolu hesabın 16/02/2023-01/03/2023 tarihlerindeki hesap hareketleri\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("15/02/2023  20:38 'Para Yatırma' Miktar:500 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("17/02/2023  09:20 'Para Çekme' Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("18/02/2023  19:00 'Para Çekme' Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("20/02/2023  09:20 'Havale Yapma' Miktar:200 TL  Kime(HesapNo):4002\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("29/02/2023  09:20 'Havale ile Gelen' Miktar:500 TL Kimden(Hesap No):4002\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("30/02/2023  15:20 'Para Yatırma' Miktar:2300 TL \n ");
                        break;

                    case "10/01/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("3267 nolu hesabın  " + DateTime.Now + "  tarihlerindeki hesap hareketleri \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(paraCekme.islem4_kaydet);                        
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(paraYatırma.pYatirma4_kaydet);
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(havaleTicari.havaleT4_kaydet);
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(havaleBireysel.havaleB4_kaydet);
                        break;
                }
                hesapÖzetiListeleri.Show();
            }



            else if (secim == "4002")
            {
                switch (turusec)
                {
                    case "01/01/2023-15/01/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("4002 nolu hesabın 01/01/2023-15/01/2023 tarihlerindeki hesap hareketleri\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("01/01/2023  20:38 'Para Çekme' Miktar:200 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("02/01/2023  09:20 'Para Yatırma' Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("05/01/2023  19:00 'Para Çekme' Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("07/01/2023  09:20 'Havale ile Gelen' Miktar:200 TL  Kimden(HesapNo):3267 \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("08/01/2023  09:20 'Havale Yapma' Miktar:500 TL Kime(Hesap No):3267\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("13/01/2023  15:20 'Para Yatırma' Miktar:2300 TL \n ");
                        break;

                    case "16/01/2023-01/02/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("4002 nolu hesabın 16/01/2023-01/02/2023 tarihlerindeki hesap hareketleri\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("15/01/2023  20:38 'Para Yatırma' Miktar:500 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("17/01/2023  09:20 'Para Çekme' Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("20/01/2023  19:00 'Para Çekme' Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("21/01/2023  09:20 'Havale ile Gelen' Miktar:200 TL  Kimden(HesapNo):3267 \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("27/01/2023  09:20 'Havale Yapma' Miktar:500 TL Kime(Hesap No):3267\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("30/01/2023  15:20 'Para Yatırma' Miktar:2300 TL \n ");
                        break;


                    case "02/02/2023-15/02/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("4002 nolu hesabın 02/02/2023-15/02/2023 tarihlerindeki hesap hareketleri\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("01/02/2023  20:38 'Para Yatırma' Miktar:500 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("02/02/2023  09:20 'Para Çekme' Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("03/02/2023  19:50 'Para Çekme' Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("05/02/2023  19:00 'Para Çekme' Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("07/02/2023  09:20 'Havale ile Gelen' Miktar:200 TL  Kimden(HesapNo):3267 \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("08/02/2023  09:20 'Havale Yapma' Miktar:500 TL Kime(Hesap No):3267\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("09/02/2023  19:00 'Para Çekme' Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("13/02/2023  15:20 'Para Yatırma' Miktar:2300 TL \n ");
                        break;


                    case "16/02/2023-01/03/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("4002 nolu hesabın 16/02/2023-01/03/2023 tarihlerindeki hesap hareketleri\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("15/02/2023  20:38 'Para Yatırma' Miktar:500 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("17/02/2023  09:20 'Para Çekme' Miktar:800 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("18/02/2023  19:00 'Para Çekme' Miktar:350 TL \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("20/02/2023  09:20 'Havale ile Gelen' Miktar:200 TL  Kimden(HesapNo):3267 \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("29/02/2023  09:20 'Havale Yapma' Miktar:500 TL Kime(Hesap No):3267\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("30/02/2023  15:20 'Para Yatırma' Miktar:2300 TL \n ");
                        break;

                    case "10/01/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("4002 nolu hesabın  " + DateTime.Now + "  tarihlerindeki hesap hareketleri \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(paraCekme.islem5_kaydet);
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(paraYatırma.pYatirma5_kaydet);
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(havaleTicari.havaleT5_kaydet);
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(havaleBireysel.havaleB5_kaydet);
                        break;
                }
                hesapÖzetiListeleri.Show();
            }
    
            else 
            {
                switch (turusec)
                {
                    case "10/01/2023":
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(hesapAcma.hesap6.HesapNo + "  nolu hesabın  " + DateTime.Now + "  tarihlerindeki hesap hareketleri \n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add("\n ");
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(paraCekme.islem6_kaydet);
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(paraYatırma.pYatirma6_kaydet);
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(havaleTicari.havaleT6_kaydet);
                        hesapÖzetiListeleri.ListBoxHesapOzetiListeleri.Items.Add(havaleBireysel.havaleB6_kaydet);
                        break;
                }

                hesapÖzetiListeleri.Show();
            }
        }
        }
    }
    

   
