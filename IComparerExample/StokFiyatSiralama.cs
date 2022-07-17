using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparerExample
{
    class StokFiyatSiralama : IComparer<Stok>
    {
        public int Compare(Stok x, Stok y)
        {
            if (x.Fiyat > y.Fiyat)
                return 1;
            else if (x.Fiyat == y.Fiyat)
                return 0;
            else
                return -1;
        }
    }

    class StokTedarikciSiralama : IComparer<Stok>
    {
        public int Compare(Stok x, Stok y)
        {
            return x.Tedarikci.CompareTo(y.Tedarikci);
        }
    }

    class StokUrunSiralama : IComparer<Stok>
    {
        public int Compare(Stok x, Stok y)
        {
            return x.Urun.CompareTo(y.Urun);
        }
    }
}
