using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrgDi113
{
    class Deneme
    {
        public int a;
        public int b;
    }
    public Deneme(int a , int b)
    {
        this.a = a;
        this.b = b;

    }
    public static int Topla(int x , int y)
    {
        return x + y;
    }
    class Program
    {

        static void Main(string[] args)
        {
            PrgDi113.Deneme d = new PrgDi113.Deneme(1, 2);
            Console.WriteLine(d.a);
            Console.WriteLine(PrgDi113.Deneme.Topla(2, 3));
        }
    }
}
