using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev5.HaftaPart9
{
    class Dortgen
    {
        public int En = 30; public int Boy = 23;
        public int Alan()
        { int Alan = En * Boy; return Alan;
        }
        class Program
        {
            static void Main(string[] args)
            {
                yaz d1 = new yaz(); d1.Yaz();
            }
            class yaz
            {
                public void Yaz()
                {
                    Console.WriteLine("En:{0,5}", Dortgen.En);
                    Console.WriteLine("Boy:{0,5}", Dortgen.Boy);
                    Console.WriteLine("Alan:{0,5}", Dortgen.Alan());
                }
            }
        }
    

