using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHoca3.Ödev4.HaftaPart9
{
    class Program
    {
        static void Yaz(object o)
        {
            Console.WriteLine("1.Metot:" + o);
        }
        static void Yaz(params object[] o)
        {
            if (o.Length == 0) return;
            Console.Write("2.Metot:");
            foreach (object n in o)
                Console.Write(n.ToString() + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Yaz(25);
            Yaz("Deneme 1 ", "Deneme 2");
            Yaz('a');
            Yaz('z', 1, 23f, 4, 56, "abc");
        }
    }
}
