using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev6.Hafta4
{
    class Sinif
    {
        public int Sayi;
         public int this[int indeks]
        { get { return Sayi;
            }
        set { Sayi = value;
            }
    }

        }
        class Program
    {
        static void Main(string[] args)
        {
            static void Main()
         {
                Sinif a = new Sinif(); a[5] = 30;
                    Console.WriteLine(a[5]);
    }
        }
    }
}
