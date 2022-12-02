using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev9.Hafta12
{
    class Temsilciler
    { public delegate void KomutMetodu();
       
    
         public struct KomutYapisi
        { 
         public KomutMetodu KomutMetot;
    
         public string Komut;
    
     }
        public static void Komut1()
        { 
        Console.WriteLine("Komut1 çalıştı.");
        }
        public static void Komut2()
{
    
         Console.WriteLine("Komut2 çalıştı.");
}
        public static void Komut3() 
            Console.WriteLine("Komut3 çalıştı."); }
            public static void Komut4() 

         { Console.WriteLine("Komut4 çalıştı."); }

    class Program
    {
        static void Main(string[] args)
        {
            {
                KomutYapisi[] komutlar = new KomutYapisi[4];

                
                 komutlar[0].Komut = "komut1";
                
                komutlar[0].KomutMetot = new KomutMetodu(Komut1); 

                

        }
    }
}
