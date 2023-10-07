using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banka_otomasyonu_210601028_210601048
{
    public class Banka
    {
        public List<Musteri> musterilistesi { get; set; } = new List<Musteri>();
        public decimal toplamPara { get; set; }
        public decimal gelenPara { get; set; }
        public decimal gidenPara { get; set; }
        public Banka()
        {

        }


        public void MusteriEkle(Musteri musteri)
        {
            musterilistesi.Add(musteri);
        }
        public static string listele { get; set; }
        public string MusteriGoruntule(KimlikBilgisi k, Musteri m)
        {           
           listele += k.Ad + "     " + k.Soyad + "    " + 
                     "Müşteri No:  "+   m.MusteriNo.ToString() + "       " + m.MusteriTipi.ToString() + "\n";          
           return listele;
       
        }
    }
}
