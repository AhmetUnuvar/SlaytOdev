using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev7.Hafta10
{
    class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme 1");
        }
    }
    namespace isimalani2
    {
        class Deneme
        {
            public Deneme()
            {
                Console.WriteLine("Deneme 2");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GamzeHocaOdev7.Hafta10.Deneme d1 = new GamzeHocaOdev7.Hafta10.Deneme();
            isimalani2.Deneme d2 = new isimalani2.Deneme();
    }
}
