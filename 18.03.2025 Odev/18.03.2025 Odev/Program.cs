



using _18._03._2025_Odev.Araba;
using _18._03._2025_Odev.Matematik;



Pencere pencere = new Pencere(4);
Model model = new Model("X5");
Kasa kasa = new Kasa("sedan");
kapı kapı = new kapı(4);
Fiyat fiyat = new Fiyat(2000000);
araba araba = new araba(fiyat, kapı, kasa, model, pencere);
Taşıt taşıt = new Taşıt("BMW", araba);
taşıt.ekranaYaz();

Matematik matematik = new Matematik();
int toplam = matematik.topla(12, 45);
double toplama = matematik.topla(2.5, 6.8, 9.5);
int carp = matematik.carp(9, 62);
double carpma = matematik.carp(5.4, 7.2);

Console.WriteLine("toplam sonuç: " + toplam);
Console.WriteLine("toplam sonuç: " + toplama);
Console.WriteLine("Çarpma sonuç:" + carp);
Console.WriteLine("Çarpma sonuç: " + carpma);
