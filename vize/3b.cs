// Klavyeden girilen 5 sayının toplamını hesaplayan C# programını yazınız.

using System; 
class Program
{
    static void Main()
    {
        int toplam = 0;
        
        for ( int i = 0 ; i<5 ; i++ ) {
            Console.WriteLine("Sayı giriniz");
            string input = Console.ReadLine();
            int sayi = Convert.ToInt32(input);
            toplam += sayi;
        }
        
        int ortalama = toplam / 5;
        Console.WriteLine("Girdiğiniz 5 sayının toplamı: " + toplam + " ortalamaları ise "+ ortalama);
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
