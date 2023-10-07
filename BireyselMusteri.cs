using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banka_otomasyonu_210601028_210601048
{
    public class BireyselMusteri : Musteri
    {
        public decimal havaleUcreti { get; set; }
        public BireyselMusteri()
        {

        }
        public override void HavaleYap(Hesap h_gonderici, decimal Tutar)
        {
            decimal havaleUcreti = (Tutar * 2) / 100;
            h_gonderici.Bakiye -= (Tutar + havaleUcreti);
        }
    }
}
