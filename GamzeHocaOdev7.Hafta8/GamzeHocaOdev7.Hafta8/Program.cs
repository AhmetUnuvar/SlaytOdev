using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev7.Hafta8
{
    class Deneme
    {
        public int a;
        public int b;

    }
    public Deneme (int a , int b)
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
            GamzeHocaOdev7.Hafta8.Deneme d = new GamzeHocaOdev7.Hafta8.Deneme(1, 2);
            Console.WriteLine(d.a);
            Console.WriteLine(GamzeHocaOdev7.Hafta8.Deneme.Topla(2, 3));
        }
    }
}
