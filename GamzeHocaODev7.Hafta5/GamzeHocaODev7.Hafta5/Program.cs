using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaODev7.Hafta5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tarihsaat = new DateTime();
                tarihsaat = DateTime.Now;
                Console.WriteLine(tarihsaat);
                DateTime tarih = new DateTime();
                tarih = DateTime.Today;
                Console.WriteLine(tarih);
        }
    }
}
