using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev6.Hafta7
{
    class Program
    {
        public struct Ogrenci
        {
            public int Numara;
            public string Ad;
            public string Soyad;

        }
        public static void Metot(Ogrenci o)
        {
            o.Numara = 999;
        }  


        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Numara = 123;
            ogr.Ad = "Ali";
            ogr.Soyad = "Türk";
            Metot(ogr);
            Console.WriteLine("{0} {1} {2}", ogr.Numara, ogr.Ad, ogr.Soyad);
        }
    }
}
