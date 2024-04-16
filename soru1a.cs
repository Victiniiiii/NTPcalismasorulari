// Klavyeden girilen 5 sayının toplamını hesaplayan C# programını yazınız.

using System; 
class Program
{
    static void Main()
    {
        int toplam = 0;

        for (int i = 1; i <= 10; i++)
        {
            toplam += i;
        }

        Console.WriteLine("1'den 10'a kadar olan sayıların toplamı: " + toplam);
    }
}

// Sayı giriniz
// 1
// Sayı giriniz
// 2
// Sayı giriniz
// 3
// Sayı giriniz
// 4
// Sayı giriniz
// 5
// Girdiğiniz 5 sayının toplamı: 15 ortalamaları ise 3
