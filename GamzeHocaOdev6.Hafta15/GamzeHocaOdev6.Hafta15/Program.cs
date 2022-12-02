using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev6.Hafta15
{
    enum Gunler : byte
    {
        Pazartesi,
            Salı,
            Çarşamba,
            Perşembe,
            Cuma,
            Cumartesi,
            Pazar
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Gunler.Pazartesi);
            Console.WriteLine((int)Gunler.Pazar);
        }

    }
}
