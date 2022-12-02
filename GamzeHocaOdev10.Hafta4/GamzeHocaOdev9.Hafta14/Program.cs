using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev9.Hafta14
{
    public void ButonKlik()
        { Console.WriteLine("{0} nolu pencere olayı algıladı.",PencereNo);
         }
         }
         public class OlayTest
    class Program
    {
        static void Main(string[] args)
        {
        Buton buton = new Buton();
        Pencere p1 = new Pencere(1);
        Pencere p2 = new Pencere(2);

        buton.ButonKlik += new OlayYoneticisi(ButonKlik);
        buton.Kliklendi();
        Console.WriteLine();

        buton.ButonKlik += new OlayYoneticisi(p1.ButonKlik);
        buton.Kliklendi();
        Console.WriteLine();
    }
    }
}
