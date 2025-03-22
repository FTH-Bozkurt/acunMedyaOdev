
namespace HesapMakinesi;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("birinci sayınızı giriniz: ");
        double a = Convert.ToDouble(Console.ReadLine());


        Console.Write("ikinci sayınızı giriniz: ");
        double b = Convert.ToDouble(Console.ReadLine());


        Console.Write("işlem numarasını giriniz(işlemler: " +
                      "1-Toplama, 2-Çıkarma, 3-Çarpma, 4-Bölme): ");
        int islem = Convert.ToInt16(Console.ReadLine());

        if (islem == 1)
        {
            Toplama(a, b);

        }
        else if (islem == 2)
        {
            Cikarma(a, b);
        }
        else if (islem == 3)
        {
            Carpma(a, b);
        }
        else if (islem == 4)
        {
            Bolme(a,b);
        }
        else
        {
            Console.WriteLine("Geçersiz işlem numarası");
        }

        static void Toplama(double a, double b)
        {
            Console.WriteLine("Toplama işlemi yapılıyor...");
            double sonuc = a + b;
            Console.Write("İşlem sonucu: " + sonuc);
        }
        static void Cikarma(double a, double b)
        {
            Console.WriteLine("Çıkarma işlemi yapılıyor...");
            double sonuc = a - b;
            Console.Write("İşlem sonucu: " + sonuc);
        }
        static void Carpma(double a, double b)
        {
            Console.WriteLine("Çarpma işlemi yapılıyor...");
            double sonuc = a * b;
            Console.Write("İşlem sonucu: " + sonuc);
        }
        static void Bolme(double a, double b)
        {
            Console.WriteLine("Bölme işlemi yapılıyor...");
            double sonuc = a / b;
            Console.Write("İşlem sonucu: " + sonuc);
        }



    }


}












