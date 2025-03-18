using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._03._2025_Odev.Araba
{
     public class araba
    {
        public Fiyat fiyat;
        public kapı kapı;
        public Kasa Kasa;
        public Model Model;
        public Pencere Pencere;

        public araba (Fiyat fiyat, kapı kapı, Kasa Kasa, Model Model, Pencere Pencere)
        {
            this.fiyat = fiyat;
            this.kapı = kapı;
            this.Kasa = Kasa;
            this.Model = Model;
            this.Pencere = Pencere;
        }

    }
}
