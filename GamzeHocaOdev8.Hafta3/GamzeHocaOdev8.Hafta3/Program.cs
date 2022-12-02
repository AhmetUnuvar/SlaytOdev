using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev8.Hafta3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Ali";
             bool b = true;//false büyük küçük duyarsız
            string s = "aLi";
            int c = String.Compare(a, s, b);
            Console.WriteLine(c);
        }
    }
}
