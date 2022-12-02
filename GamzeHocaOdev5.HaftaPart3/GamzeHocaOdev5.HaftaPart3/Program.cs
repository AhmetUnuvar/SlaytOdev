using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev5.HaftaPart3
{
    class KrediHesabı
    {
        public ulong HesapNo;

    }
    class Program
    {
        static void Main(string[] args)
        {
            KrediHesabı hesap1 = new KrediHesabı();
            KrediHesabı hesap2 = new KrediHesabı();
            hesap1.HesapNo = 3450;
            hesap2.HesapNo = 1111;
            Console.WriteLine(hesap1.HesapNo);
            Console.WriteLine(hesap2.HesapNo);
        }
    }
}
