using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hafta Örnek 1 Operatör

            int a = 2, b = 3, c = 6, d = 1;

            Console.WriteLine(" (a<b) && (c<d) -->" + ((a < b) && (c < d)));
            Console.WriteLine(" (a<b)||(c<d) --> " + ((a < b) || (c < d)));
            Console.WriteLine(" ! (a<b) -->" + (!(a < b)));
            Console.WriteLine(" (a<b)&(c<d) --> " + ((a < b) & (c < d)));
            Console.WriteLine(" (a<b)|(c<d) --> " + ((a < b) | (c < d)));
            Console.WriteLine(" (a<b)^(c<d) --> " + ((a < b) ^ (c < d)));

            //3. Hafta Örnek 2 Operatör

            int a1 = 2, b1 = 3, c1 = 6;
            Console.WriteLine(" (a1 & b1) --> " + (a1 & b1));
            Console.WriteLine(" (a1 | b1) --> " + (a1 | b1));
            Console.WriteLine(" (a1 ^ b1) --> " + (a1 ^ b1));
            Console.WriteLine(" ( ~a1 ) --> " + (~a1));
            Console.WriteLine(" ( ~b1 ) --> " + (~b1));
            Console.WriteLine(" ( ~c1) --> " + (~c1));

            // 3. Hafta Örnek 3 While Döngüsü

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("i = " + i);
                i++;
            }

            // 3. Hafta Örnek 4 do while döngüsü

            int i1 = 0;
            do
            {
                Console.WriteLine("i =" + i);
                i++;
            } while (i < 0);

            // 3. Hafta Örnek 5 Do While ve Switch

            int secim;
            do
            {
                Console.WriteLine("İşlemler \n========");
                Console.WriteLine("1 - Toplama");
                Console.WriteLine("2 - Çıkarma");
                Console.WriteLine("3 - Çarpma");
                Console.WriteLine("4 - Bölme");
                Console.WriteLine("0 - Çıkış\n");
                Console.WriteLine("İşleminizi Seçin:");
                secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1: Console.WriteLine("Toplama İşlemi Seçildi"); break;
                    case 2: Console.WriteLine("Çıkarma İşlemi Seçildi"); break;
                    case 3: Console.WriteLine("Çarpma İşlemi Seçildi"); break;
                    case 4: Console.WriteLine("Bölme İşlemi Seçildi"); break;
                    case 0: Console.WriteLine("Çıkış Seçildi"); break;
                    default: Console.WriteLine("Yanlış Seçim"); break;

                }

            } while (secim != 0);

            // 3. Hafta Örnek 6 For Döngüsü
            for (int i2 = 0 , j = 0; i2 < 20 ; i++, j++){
                i2*= j;
                Console.WriteLine("i = " + i + " j =" + j);
            }

            // 3. Hafta Örnek 7 For Döngüsü

            string s;
            for (s = Console.ReadLine(); s != "Çıkış"; s = Console.ReadLine()) ;
            Console.WriteLine(s);

            // 3. Hafta Örnek 8 For Döngüsü

            int i3 = 0, k, l;

            Console.Write("Bir Sayı Girin : ");
            l = Convert.ToInt32(Console.ReadLine());

            Console.Write("Artım Miktarı : ");
            k = Convert.ToInt32(Console.ReadLine());

            for(; k < l;)
            {
                Console.Write("{0} ", k);
                i3 += k;
            }

            // 3. Hafta Örnek 9  For Döngüsü

            int o, p, toplam, n1, n2;

            Console.Write("Aralık Başlangıcı : ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Aralık Sonu      :");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 <= n2)
            {
                for (o = n1; o <= n2; o++)
                {
                    toplam = 0;
                    for (p = 1; p <= o; p++) { if (o % p == 0) toplam = toplam + p; }
                    if (toplam == o + 1) Console.WriteLine(o);
                }
            }
            else
                Console.WriteLine("Geçerli Bir Aralık Giriniz !!!");

            // 3. Hafta Örnek 10 For Döngüsü

            int sayi;
            Console.Write("Bir Tam Sayı Giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());

            for(int bit = 32; bit >= 1; bit--)
            {
                Console.WriteLine("{0}", (sayi >> bit - 1) & 1);
            }
            Console.WriteLine();
        }

    }
}
