using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev6.Hafta3
{
    class Sinif
    {
        public int Sayi;
         public Sinif(int sayi) { Sayi = sayi; }
        public static bool operator true(Sinif a) { return true; }
        public static bool operator false(Sinif a) { return false; }
        public static Sinif operator &(Sinif a, Sinif b) { return new Sinif(20); }
        public static Sinif operator |(Sinif a, Sinif b) { return new Sinif(30); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sinif a = new Sinif(50); Sinif b = new Sinif(10);
            Console.WriteLine((a || b).Sayi);
            Console.WriteLine((a && b).Sayi);
        }
    }
}
