using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev6.Hafta10
{
    class Sinif
    {
        public enum Renkler: byte {Siyah,Beyaz,Kırmızı,Mavi,Sarı }
    }
    class Program
    {
        enum Gunler : byte { Pazartesi, Salı,Çarşamba,Perşembe,Cuma,Cumartesi,Pazar}
        static void Main(string[] args)
        {
            string[] a = Gunler.GetNames(typeof(Gunler));
            Console.WriteLine(a[0]);

            Sinif.Renkler b = (Sinif.Renkler)1;
            Console.WriteLine(b + "," + (byte)b);
        }
    }
}
