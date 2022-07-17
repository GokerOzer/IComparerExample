using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparerExample
{
    class Stok
    {
        public string Urun { get; set; }

        public string Tedarikci { get; set; }

        public decimal Fiyat { get; set; }

        public decimal IndirimOrani { get; set; }

        public override string ToString()
        {
            return $"Ürün={Urun}, Fiyat={Fiyat}  \tTedarikçi={Tedarikci}, İndirim Oranı={IndirimOrani}";
        }
    }
}
