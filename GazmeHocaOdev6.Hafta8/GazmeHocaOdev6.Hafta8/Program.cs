using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GazmeHocaOdev6.Hafta8
{
     struct ayapi { public int cx; public int cy; }
     class bsinif { public int cx; public int cy; }
    class Program
    {
        static void Main(string[] args)
        {
            ayapi ay1, ay2;
             ay1.cx = 10; ay1.cy = 20;
            ay2 = ay1;
            ay1.cx = 30; ay1.cy = 40;
            Console.WriteLine("Yapılar:");
            Console.WriteLine("ay1 için {0},{1}", ay1.cx, ay1.cy);
            Console.WriteLine("ay2 için {0},{1}", ay2.cx, ay2.cy);

            bsinif bs1, bs2;
            bs1 = new bsinif();
            bs1.cx = 10; bs1.cy = 20;
            bs2 = bs1;
            bs1.cx = 30; bs1.cy = 40;
            Console.WriteLine("Sınıflar:");
            Console.WriteLine("bs1 için {0},{1}", bs1.cx, bs1.cy);
            Console.WriteLine("bs2 için {0},{1}", bs2.cx, bs2.cy);
        }
    }
}
