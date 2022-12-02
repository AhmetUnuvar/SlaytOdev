using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev8.Hafta1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vize1 = ");
             int vize1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("Vize2 = ");
             int vize2 = Convert.ToInt32(Console.ReadLine());
             Console.Write("Final = ");
             int final = Convert.ToInt32(Console.ReadLine());
             double a = ((double)vize1 * 0.2 + (double)vize2 * 0.3 +
             (double)final * 0.5);
             Console.WriteLine("Ortalama = {0}", a);
        }
    }
}
