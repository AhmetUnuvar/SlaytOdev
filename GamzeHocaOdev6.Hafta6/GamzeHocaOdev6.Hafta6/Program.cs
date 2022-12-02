using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev6.Hafta6
{
    class indeksleyici
    {
        private int[] dizi;
        public indeksleyici(int dizi_uzunluk)
        {
            dizi = new int[dizi_uzunluk];
        }
        public int diziBoyutu
        {
            get { return dizi.Length; }

            
        }
        public int this [int indeks]
        {
            get { return dizi[indeks]; }
            set { dizi[indeks] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            indeksleyici i = new indeksleyici(10);
            for (int k = 0; k <  i.diziBoyutu; k++){
                Console.WriteLine("i[{0}]={1}", k, i[k] = k);
            }
        }
    }
}
