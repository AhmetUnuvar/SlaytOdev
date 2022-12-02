using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev6.Hata9
{
    class Program
    {
        enum bolumler
             { Yazılım_Müh_,
                Elektrik_Elektronik_Müh_,
                Mektronik_Müh_,
                Bilgisayar_Müh_,
                Makina_Müh_,
    }
    static void Main(string[] args)
        {
            bolumler b;
             for (b = bolumler.Yazılım_Müh_; b <= bolumler.Makina_Müh_; b++)
                Console.WriteLine("{0} 'nın etiketi ={1,4:d}", b, (int)b);
        }
    }
}
