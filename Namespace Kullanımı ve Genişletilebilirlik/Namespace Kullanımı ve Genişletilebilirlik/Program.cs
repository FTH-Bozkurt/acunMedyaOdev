using System;

namespace MatematikIslemleri
{
    public class Hesaplama
    {

        
        public double Toplama(double sayı1, double sayı2)
        {
            return sayı1 + sayı2;
        }

        public double Carpma(double sayı1, double sayı2)
        {
            return sayı1 * sayı2;
        }
    }
}


namespace Uygulama

{
    using MatematikIslemleri;

    class program
    {
        static void Main()
        {
            Hesaplama hesaplama = new Hesaplama();
            double ToplamaSonucu = hesaplama.Toplama(12.5, 6.4);
            double CarpmaSonucu = hesaplama.Carpma(12.5, 6.4);

            Console.WriteLine("Toplam sonuç: " + ToplamaSonucu);
            Console.WriteLine("carpma sonucu: " + CarpmaSonucu);
        }

    }


}



