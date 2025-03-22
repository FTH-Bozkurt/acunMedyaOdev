Console.Write("birinci sayı giriniz: ");
int sayı = Convert.ToInt32(Console.ReadLine());

Console.Write("ikinci sayı giriniz: ");
int sayı2 = Convert.ToInt32(Console.ReadLine());

Console.Write("üçüncü sayı giriniz: ");
int sayı3 = Convert.ToInt32(Console.ReadLine());

Console.Write("dödüncü sayı giriniz: ");
int sayı4 = Convert.ToInt32(Console.ReadLine());

Console.Write("beşinci sayı giriniz: ");
int sayı5 = Convert.ToInt32(Console.ReadLine());


int[] sayılar = { sayı, sayı2, sayı3, sayı4, sayı5 };

int ToplamSayı = 0;
int ortalama = 0;

for (int i = 0; i < sayılar.Length; i++)
{
    ToplamSayı = ToplamSayı + sayılar[i];

}
ortalama = (ToplamSayı / 5) + ortalama;
Console.WriteLine(ortalama);














