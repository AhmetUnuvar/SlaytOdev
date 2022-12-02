using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamzeHocaOdev6.Hafta1
{
    class karmasikSayi
    {
        private double mGercek;
        private double mSanal;

        public double Gercek
        {
            get { return mGercek; }
            set { mGercek = value; }
        }
        public double Sanal
        {
            get { return mSanal; }
            set { mSanal = value; }
        }

        public karmasikSayi(double x, double y)
        {
            mGercek = x;
            mSanal = y;
        }
        public karmasikSayi()
        {
            mGercek = 0;
            mSanal = 0;
        }
        public karmasikSayi(karmasikSayi k)
        {
            mGercek = k.mGercek;
            mSanal = k.mSanal;
        }
        public void yaz()
        {
            if (mSanal > 0)
                Console.WriteLine("{0} + {1}i", mGercek, mSanal);

            else
                Console.WriteLine("{0} - {1}i", mGercek, -mSanal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            karmasikSayi k = new karmasikSayi(-5, -6);
            k.yaz();
        }
    }
}
