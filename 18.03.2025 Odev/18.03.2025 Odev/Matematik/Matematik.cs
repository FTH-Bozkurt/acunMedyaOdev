using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _18._03._2025_Odev.Matematik
{
    public class Matematik
    {
        public int topla(int sayı1, int sayı2)
        {
            int sonuc = 0;
            sonuc = sayı1 + sayı2;
            return sonuc;
        }

        public int topla(int sayı1, int sayı2, int sayı3)
        {
            int sonuc = 0;
            sonuc = sayı1 + sayı2 + sayı3;
            return sonuc;
        }

        public double topla(double sayı1, double sayı2)
        {
            double sonuc = 0;
            sonuc = sayı1 + sayı2;
            return sonuc;

        }


        public double topla(double sayı1, double sayı2, double sayı3)
        {
            double sonuc = 0;
            sonuc = sayı1 + sayı2 + sayı3;
            return sonuc;
        }


        public int carp(int sayı1, int sayı2)
        {
            int sonuc = 0;
            sonuc = sayı1 * sayı2;
            return sonuc;
        }

        public int carp(int sayı1,int sayı2, int sayı3)
        {
            int sonuc = 0;
            sonuc = sayı1 * sayı2 * sayı3;
            return sonuc;
        }

        public double carp(double sayı1, double sayı2)
        {
            double sonuc = 0;
            sonuc = sayı1 * sayı2;
            return sonuc;
        }

        public double carp(double sayı1, double sayı2, double sayı3)
        {
            double sonuc = 0;
            sonuc = sayı1 * sayı2 * sayı3;
            return sonuc;
        }


    }
}
