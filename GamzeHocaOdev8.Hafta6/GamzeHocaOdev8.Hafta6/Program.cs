using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev8.Hafta6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;
            Console.WriteLine(" d-Formatı:{0:d}", d);
            Console.WriteLine(" D-Formatı:{0:D}", d);
            Console.WriteLine(" t-Formatı:{0:t}", d);
            Console.WriteLine(" T-Formatı:{0:T}", d);
            Console.WriteLine(" f-Formatı:{0:f}", d);
            Console.WriteLine(" F-Formatı:{0:F}", d);
            Console.WriteLine(" g-Formatı:{0:g}", d);
            Console.WriteLine(" G-Formatı:{0:G}", d);
            Console.WriteLine(" m-Formatı:{0:m}", d);
            Console.WriteLine(" M-Formatı:{0:M}", d);
            Console.WriteLine(" r-Formatı:{0:r}", d);
            Console.WriteLine(" R-Formatı:{0:R}", d);
            Console.WriteLine(" s-Formatı:{0:s}", d);
            Console.WriteLine(" u-Formatı:{0:u}", d);
            Console.WriteLine(" U-Formatı:{0:U}", d);
            Console.WriteLine(" y-Formatı:{0:y}", d);
            Console.WriteLine(" Y-Formatı:{0:Y}", d);
        }
    }
}
