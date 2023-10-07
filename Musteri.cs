using banka_otomasyonu_210601028_210601048;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banka_otomasyonu_210601028_210601048
{
    public class Musteri : Kisi
    {
        public int MusteriNo
        {
            get
            {
                int[] dizi = new int[1000];
                int uretilen = 0;
                Random musterino = new Random();
                while (uretilen != 0)
                {
                    int musterino_test = musterino.Next(1, 1000);
                    if (!dizi.Contains(musterino_test))
                    {
                        dizi[uretilen] = musterino_test;
                        uretilen++;
                    }
                }
                return musterino.Next(1, 1000);
            }

        }
        public string MusteriTipi { get; set; }
        public KimlikBilgisi kimlikBilgisi { get; set; } = new KimlikBilgisi();

        public List<Hesap> hesapListesi { get; set; } = new List<Hesap>();
        public List<int> HesapNumaralarıListesi { get; set; } = new List<int>();
        public Musteri()
        {            
      
        }
        public void HesapActirma(Hesap h, int hesapno)
        {
            hesapListesi.Add(h);
            HesapNumaralarıListesi.Add(hesapno);
        }
        public string listele { get; set; }
     
        public string HesapListesiGoruntule(Musteri m,Hesap hesaplar)
        {      
                listele = m.kimlikBilgisi.Ad + "   " + m.kimlikBilgisi.Soyad + "  adlı müşterinin hesap numarası:  " + hesaplar.HesapNo + "\n" ;
                     
            return listele;
        }
        
        public virtual void HavaleYap(Hesap h, decimal Tutar)
        {
            h.Bakiye -= Tutar;
        }
        public string hataMesaji;
        public void Ad_Validasyon(KimlikBilgisi kimlik)
        {
            if (kimlik.Ad == "")
            {
                hataMesaji = "Ad alanı boş bırakılamaz.";
                System.Windows.Forms.MessageBox.Show(hataMesaji);
            }

        }
        public string hataMesaji2;
        public void Soyad_Validasyon(KimlikBilgisi kimlik)
        {
            if (kimlik.Soyad == "")
            {
                hataMesaji2 = "Soyad alanı boş bırakılamaz.";
                System.Windows.Forms.MessageBox.Show(hataMesaji2);

            }

        }



    }
}
