using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHoca3.Ödev4.Hafta
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hafta Örnek 1 Diziler 

            Random rnd = new Random();
            int[] dizi = new int[20];
            char[] chr = new char[20];

            for(int i2 = 0; i2<20; i2++)
            {
                dizi[i2] = rnd.Next(1, 51);
                chr[i2] = (char)rnd.Next(20, 126);

            }
            for(int i2 = 0; i2<20; i2++)
            {
                Console.Write("{0,2}. değer {1,2} ->", i2, dizi[i2]);
                for (int j2 = 0; j2<dizi[i2]; j2++)
                {
                    Console.Write(chr[i2]);
                    
                }
                Console.WriteLine();
            }

            // 4. Hafta Örnek 2 Matris Dizileri

            int[,] dizi2 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            for(int i = 0; i<3; i++)
                for(int j = 0; j <2; j++)
                {
                    Console.WriteLine(dizi2[i, j]);
                }
            // 4. Hafta Örnek 3 Düzensiz Diziler 

            int[][] dizi3 = new int[3][];

            dizi3[0] = new int[] { 1, 2 };
            dizi3[1] = new int[] { 3, 4, 5, 6, 7 };
            dizi3[2] = new int[] { 8, 9, 0 };

            foreach (int[] boyut in dizi3)
            {
                foreach ( int eleman in boyut)
                {
                    Console.Write("{0,3}", eleman);

                }Console.WriteLine();
            }

            // 4. Hafta Örnek 4 Diziler

            int[,] d = { { 2, 3 }, { 4, 5 }, { 6, 7 } };
            d[2, 1] = 33;
            Console.WriteLine(d.GetValue(2, 1));
            int[][] dd = new int[2][];
            dd[0] = new int[2];
            dd[1] = new int[1];
            dd[0][0] = 23;
            dd[0][1] = 234;
            dd[1][0] = 44;
            Random rn = new Random();
            int[] dizi4 = new int[3];
            dizi4[0] = rn.Next(2, 10);
            dizi4[1] = rn.Next(50);
            dizi[2] = rn.Next();
            Console.WriteLine(dizi.GetValue(2));
            Console.WriteLine(dd[1][0]);

            // 4. Hafta Örnek 5 foreach

            string[] isimler = { "ali", "ahmet", "selda", "canan", "melike" };
            Console.WriteLine("aranan isim =");
            string aranan = Console.ReadLine();
            foreach(ss in isimler)
            {
                if (aranan.Equals(isimler[0]))
                    Console.WriteLine("aranan isim bulundu ");
                else Console.WriteLine("isim yok");
            }

            

           
           
            

           
        }
    }
}
