using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev6.Hafta13
{
    enum notu: byte { basarisiz , basarili}
    class Program
    {
       
        static void Main(string[] args)
        {
            notu a = notu.basarili;
            if (a == (notu)1)
                Console.WriteLine("Başarılısınız");
            else
                Console.Write("Başarısızsınız");
        }
    }
}
