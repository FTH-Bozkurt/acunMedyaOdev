using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._03._2025_Odev.Araba
{
    public class Taşıt
    {
        public string Markası;
        public araba araba;


        public Taşıt(string markası, araba araba)
        {
            this.araba = araba;
            this.Markası = markası;
        }


        public void ekranaYaz()
        {
            Console.WriteLine("Arabanın markası:" + Markası +
                              ", Arabanın Modeli:" + araba.Model.Modeli +
                              ", Kapı sayısı:" + araba.kapı.kapıSayısı +
                              ", Pencere sayısı:" + araba.Pencere.pencereSayısı +
                              ", Kasası:" + araba.Kasa.kasası +
                              ", Fiyatı:" + araba.fiyat.fiyati + "Tl'dir. ");
        }
    }
}
