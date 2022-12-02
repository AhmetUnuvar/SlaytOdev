using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev7.Hafta1
{
    class Deneme
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose() metodu çağrıldı.")
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using ( Deneme d = new Deneme())
            {
                Console.WriteLine("Using Bloğu Çağrıldı");
            }
            Console.WriteLine("Using dışında.");
        }
    }
}
