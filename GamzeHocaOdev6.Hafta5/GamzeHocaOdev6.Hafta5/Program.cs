using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev6.Hafta5
{
    class Sinif
    {
        public int Sayi;
        public int this[int indeks]
        {
            get { return Sayi; }
            set { if (indeks > 0) Sayi += value;
                else if (indeks < 0) Sayi -= value;
                else Sayi = Sayi;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sinif a = new Sinif();
            a[5] = 45; a[-10] = 23; a[100] = 87; a[-80] = 100;
            Console.WriteLine(a[0]);
        }
    }
}
