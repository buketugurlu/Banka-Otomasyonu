using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banka_otomasyonu_210601028_210601048
{
    public class Hesap
    {
        public int HesapNo
        {
            get
            {                               
                int[] dizi = new int[10000];
                int uretilen = 0;
                Random hesapno = new Random();
                while (uretilen != 0)
                {
                    int hesapno_test = hesapno.Next(1, 10000);
                    if (!dizi.Contains(hesapno_test))
                    {
                        dizi[uretilen] = hesapno_test;
                        uretilen++;
                    }
                }               
                  return hesapno.Next(1, 10000);                           
            }
          
        }
        public int hesapNo_kaydet;
        public decimal Bakiye { get; set; }
        public List<IslemBilgisi> islemBilgileri { get; set; } = new List<IslemBilgisi>();
        public decimal ekHesapBakiye { get; set; }      
        public Hesap()
        {
          hesapNo_kaydet = this.HesapNo;
        }
        public void ParaCekme(decimal Tutar)
        {
            decimal toplamBakiye = ekHesapBakiye + Bakiye;
            if (toplamBakiye != 0)
            {
                if (toplamBakiye >= Tutar)
                {
                    if (Tutar > 750)
                    {
                        MessageBox.Show("Günlük para çekme limiti 750 TL'dir. İşlem başarısız.");
                    }
                    if (Tutar <= 750)
                    {
                        if (Tutar < Bakiye)
                        {
                            Bakiye -= Tutar;
                            hesapAcma.banka.gidenPara += Tutar ;
                        }
                        else if (Tutar >= Bakiye)
                        {
                           decimal sayi = Bakiye;
                            ekHesapBakiye -= Tutar - sayi;
                            Bakiye -= Bakiye;
                            hesapAcma.banka.gidenPara += Tutar;
                        }
                    }
                }
                else
                    MessageBox.Show("Bakiye yetersiz");
                }       
        }
        public void IslemBilgisiEkle(IslemBilgisi islem)
        {
            islemBilgileri.Add(islem);
        }
          public void ParaYatırma(decimal Tutar)
          {
            Bakiye += Tutar;
            hesapAcma.banka.gelenPara += Tutar;
        }
          public void Havale( Hesap h_alici, decimal Tutar)
          {
            if (h_alici.HesapNo != 0)
            {
                h_alici.Bakiye += Tutar;
            }
        }
        public string hataMesaji3;
        public void Tutar_Validasyon(decimal Tutar)
        {
            if (Tutar == 0)
            {
                hataMesaji3 += "Bir tutar giriniz.";
                System.Windows.Forms.MessageBox.Show(hataMesaji3);
            }

        }
    }
}

