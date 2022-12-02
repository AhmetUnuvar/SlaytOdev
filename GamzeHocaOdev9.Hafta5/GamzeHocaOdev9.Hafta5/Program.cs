using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev9.Hafta5
{
    abstract class A
    {
        public int x;
        abstract public int y
        {
            set;
            get;
        }
        public A(int x)
        {
            this.x = x;
        }
        abstract public void Metot();

    }
    class S : A
    {
        int z;
        public S(int x ) : base(x)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
