

using System.ComponentModel.Design;

Console.Write("Lütfen bir sayı giriniz : ");

// Girilen sayıyı değerini değişkene atadım. 

int sayi = Convert.ToInt32(Console.ReadLine()); 

if (sayi == 10) 
{ 
    Console.WriteLine("Sayı 10'dur.");
}
else if (sayi > 10)
{   Console.WriteLine("Sayı 10'dan büyüktür.");
}
else
{
    Console.WriteLine("Sayı 10'dan küçüktür.");
}

// Üstte bu yapıyı kullanma sebebim if döngüsü true çevirirse sayının 10 ile ilgili başka bir ilişkisini kontrol etmek istemiyorum.


// Alt kısımda yeniden if ile başlaa sebebim ise bu döngüye girmeyi zorlamam lazım ki çift mi tek mi olduğunu anlayım. 


if (sayi % 2 == 0)
{
    Console.WriteLine("Sayı çifttir.");
}
else
{
    Console.WriteLine("Girilen sayı tektir.");
}