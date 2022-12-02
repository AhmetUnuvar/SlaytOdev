extern alias Dosya1;
extern alias Dosya2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GamzeHocaOdev7.Hafta3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dosya1::IsimAlani.Sinif a = new Dosya1::IsimAlani.Sinif();
            Dosya2::IsimAlani.Sinif b = new Dosya2::IsimAlani.Sinif();
        }
    }
}
