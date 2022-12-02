using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev8.Hafta4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Bilgisayar";
            Console.WriteLine("Eklemeden önce");
            Console.WriteLine("" + a);
            a = a.PadLeft(15);
            Console.WriteLine("Sola Boşluk Eklemeden sonra");
            Console.WriteLine("" + a);
            Console.WriteLine("Karakter Eklemeden sonra");
            a = "Bilgisayar";
            a = a.PadLeft(15, 'E');
            Console.WriteLine("" + a);
            Console.WriteLine("");
        }
    }
}
