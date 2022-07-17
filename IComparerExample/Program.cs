using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Stok> stoktakiler = new List<Stok>();
            stoktakiler.Add(new Stok() { Urun = "Kitap", Fiyat = 20, Tedarikci = "Göker Kitap", IndirimOrani = 10 });
            stoktakiler.Add(new Stok() { Urun = "Defter", Fiyat = 30, Tedarikci = "Zırt Kitap", IndirimOrani = 15 });
            stoktakiler.Add(new Stok() { Urun = "Kalem", Fiyat = 40, Tedarikci = "Zort Kitap", IndirimOrani = 5 });
            stoktakiler.Add(new Stok() { Urun = "Silgi", Fiyat = 50, Tedarikci = "Cart Kitap", IndirimOrani = 20 });

            foreach (Stok item in stoktakiler)
            {
                Console.WriteLine(item);
            }

            Console.Write("Stokları ürüne göre sıralamak için 1'e, tedarikçiye göre sıralamak için 2'ye, fiyata göre sıralamak için 3'e basınız: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            IComparer<Stok> comparer = ComparerGetter(secim);
            stoktakiler.Sort(comparer);
            Console.Clear();

            foreach (Stok item in stoktakiler)
            {
                Console.WriteLine(item);
            }


            IComparer<Stok> ComparerGetter(int _secim)
            {
                comparer = null;
                switch (_secim)
                {
                    case 1:
                        comparer = new StokUrunSiralama();
                        break;
                    case 2:
                        comparer = new StokTedarikciSiralama();
                        break;
                    case 3:
                        comparer = new StokFiyatSiralama();
                        break;
                }
                return comparer;
            }


            Console.ReadLine();
        }
    }
}
