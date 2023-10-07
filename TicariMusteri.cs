using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banka_otomasyonu_210601028_210601048
{
    public class TicariMusteri : Musteri
    {
        public TicariMusteri()
        {

        }
        public override void HavaleYap(Hesap h, decimal Tutar)
        {
            base.HavaleYap(h, Tutar);
        }
    }
}
