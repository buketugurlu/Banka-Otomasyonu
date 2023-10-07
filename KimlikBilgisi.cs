using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banka_otomasyonu_210601028_210601048
{
    public class KimlikBilgisi
    {
        public long TCKimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set;}
         
        public KimlikBilgisi()
        {
            
        }
    }
}
