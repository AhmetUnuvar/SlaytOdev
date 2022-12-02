using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev9.Hafta13
{
    delegate void OlayYoneticisi();
    class Program
    {
        static void Main(string[] args)
        {
            AnaProgram nesne = new AnaProgram();            nesne.Olay += new OlayYoneticisi(Metot);
            nesne.Olay();
            static void Metot() { Console.WriteLine("Butona tıklandı."); }
            event OlayYoneticisi Olay;
    }
    }
}
