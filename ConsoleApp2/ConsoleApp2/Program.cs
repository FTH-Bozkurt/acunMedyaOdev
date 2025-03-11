
//1. Ödev: Yaş Kategorisini Belirleme



using ConsoleApp2.Class;

Yas age = new Yas();
int gelenYas = age.yasHesapla(1700);


if (gelenYas > 0 && gelenYas <= 18)
{
    Console.WriteLine("Yaşınız : " + gelenYas + " küçüksünüz.");
}

else if (gelenYas > 18 && gelenYas <= 35)
{
    Console.WriteLine("Yaşınız : " + gelenYas + " Gençsiniz.");
}

else if (gelenYas > 35 && gelenYas <= 55)
{
    Console.WriteLine("Yaşınız : " + gelenYas + " Yetişkinsiniz.");
}

else if (gelenYas > 55 && gelenYas <= 75)
{
    Console.WriteLine("Yaşınız : " + gelenYas + " Yaşlısınız.");
}

else if (gelenYas > 75 && gelenYas <= 99)
{
    Console.WriteLine("Yaşınız : " + gelenYas + " Çok yaşlısınız");
}

else
{
    Console.WriteLine("Ya hiç doğmadınız ya da çoktan öldünüz...");
}


Console.WriteLine("-------------------------------------------------------------------------");

//2. Ödev: Araba Yaşı ve Durumu

Araba a = new Araba();
int Model = a.modelHesaplama(2000);


if (Model > 0 && Model <= 10)
{
    Console.WriteLine("Arabanın yaşı : " + Model + " Arabanız yeni");
}

else if (Model > 10 && Model <= 20)
{
    Console.WriteLine("Arabanın yaşı : " + Model + " Servise götürmeniz gerekebilir");
}

else if (Model > 20 && Model <= 30)
{
    Console.WriteLine("Arabanın yaşı : " + Model + " Arabanız hurdaya çıkabilir");
}

else
{
    Console.WriteLine("Ya hiç üretilmedi ya da trafikten men edilmiştir");
}


//Switch-case yapılanmasının en önemli özelliği , yalnızca ‘eşitlik’ durumlarını kontrol edebilmesi ve bu duruma göre işlem yapabilmesidir.
//Bu yapı, bir değişkenin değerini tanımlanan koşullardaki değerlerle karşılaştırarak kontrol eder ve sadece eşitlik sağlanan durumlarda ilgili işlemler gerçekleştirilir.
//Dolayısıyla bu yapı, iki değer arasındaki ‘büyüklük’, ‘küçüklük’, ‘küçük eşitlik’ gibi ilişkileri kontrol etmek için kullanılamaz.
//Eğer programımız bu tür ilişkileri kontrol etmeliyse, temel Switch-case yapısı yerine ‘if-else’ yapısını tercih etmemiz daha uygun olacaktır.
// fakat switch-case de "when" şart ifadesi kullanılarak kontrol ettiği eşitlik koşulunun yanı sıra, başka bir koşulun kontrolünü sağlayabilir.
// Aynı zamanda bu koşullar, sadece ‘eşitlik’ kontrolüyle sınırlı kalmaz; bir değeri ‘küçüklük’, ‘büyüklük’, ‘büyük eşitlik’ gibi ilişkiler açısından da kontrol edebilir.
// Bu sayede switch-case yapısı, kullandığımız ifadenin zenginleşmesini ve programımızın daha spesifik kontroller yapabilmesini sağlar.


Console.WriteLine("-------------------------------------------------------------------------");

//4. Ödev: Çalışanların Maaş Hesaplaması

int ToplamMaas = 0;
int GenelMudur = 80000;
int Mudur = 60000;
int Programcı = 40000;
int Stajyer = 5000;

string[] calısanlar = ["GenelMüdür ", "Müdür ", "Programcı ", "Stajyer "];
int[] Maas = { GenelMudur, Mudur, Programcı, Stajyer };

for (int M = 0; M < Maas.Length; M++)
{
    ToplamMaas = ToplamMaas + Maas[M];
    Console.WriteLine(calısanlar[M] + Maas[M]);

}

Console.WriteLine("Çalışanlar Toplam : " + ToplamMaas + " Tl maaş alıyorlar");

Console.WriteLine("-------------------------------------------------------------------------");

//5. Ödev: Arabaların Benzin Tüketimi

Araba arb = new Araba();



string[] cars = new string[3];
cars[0] = arb.brand = "Bmw ";
cars[1] = arb.brand = "Mercedes ";
cars[2] = arb.brand = "porsche ";

double[] fuel = new double[3];
fuel[0] = arb.fuelConsumption = 2.5;
fuel[1] = arb.fuelConsumption = 3.6;
fuel[2] = arb.fuelConsumption = 4.1;

double allFuel = 0;

for (int m = 0; m < fuel.Length; m++)
{
    allFuel = allFuel + fuel[m];
    Console.WriteLine(cars[m] + fuel[m]);
}

Console.WriteLine("Harcanan toplam benzin : " + allFuel);










