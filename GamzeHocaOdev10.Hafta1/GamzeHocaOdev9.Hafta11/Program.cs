using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev9.Hafta11
{
    class Program
    {
        private int final;
        private int vize;
        public notlar(int f, int v)
        { if(v>100)
        { throw new hatalınot(v,"yapıcı metot");
            }
        final=f;
        vize=v;
        }
        public void degerver(int f, int v)
        { if(v>100)
        throw new hatalınot(v,"degerver metodu");
        final=f;
        vize=v;
        static void Main(string[] args)
        {
        }
    }
    }
