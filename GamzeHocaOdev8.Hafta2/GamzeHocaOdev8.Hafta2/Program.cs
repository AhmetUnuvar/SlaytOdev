using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev8.Hafta2
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1 = String.Concat("Bilgisayar", " Öğretmenliği");
            Console.WriteLine(str1);
            String str2 = String.Concat("Z", "5", "s", "3", "f");
            Console.WriteLine(str2);
            String str3 = "Bilgisayar" + " Öğretmenliği";
            Console.WriteLine(str3);
            String str4 = String.Concat(5, "A");
            Console.WriteLine(str4);
        }
    }
}
