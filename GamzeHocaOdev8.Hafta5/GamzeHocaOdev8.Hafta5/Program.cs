using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev8.Hafta5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Teknoloji Fakültesi Yazılım Mühendisliği Bölümü";
            char[] ayırıcı = { ' ' };
            string[] ayır = str.Split(ayırıcı);
            foreach (string i in ayır)
            Console.WriteLine(i);
            Console.WriteLine();
            ayır = str.Split(ayırıcı, 2);
            foreach (string i in ayır)
            Console.WriteLine(i);
        }
    }
}
