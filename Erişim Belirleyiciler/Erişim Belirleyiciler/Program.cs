using System;

namespace KullaniciYonetimi
{
    public class User
    {
        private string adSoyad;
        private int yas;
        public string Email { get; set; }

        
        public string GetAdSoyad()
        {
            return adSoyad;
        }

        public void SetAdSoyad(string ad)
        {
            adSoyad = ad;
        }

        public int GetYas()
        {
            return yas;
        }

        public void SetYas(int age)
        {
            if (age > 0)
                yas = age;
            else
                Console.WriteLine("Yaş negatif olamaz!");
        }

        public void BilgileriGoster()
        {
            Console.WriteLine($"Ad Soyad: {adSoyad}\nYaş: {yas}\nEmail: {Email}");
        }
    }
}

namespace ProgramUygulamasi
{
    using KullaniciYonetimi;

    class Program
    {
        static void Main()
        {
            User kullanici = new User();
            kullanici.SetAdSoyad("Ali Veli");
            kullanici.SetYas(25);
            kullanici.Email = "ali.veli@example.com";

            kullanici.BilgileriGoster();
        }
    }
}








