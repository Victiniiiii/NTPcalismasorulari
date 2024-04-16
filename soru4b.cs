// ortalama?

using System;
class Program
{
    static void Main()
    {
        int toplam = 0;
        int adet = 0;

        while(true) {
            Console.WriteLine("Sayı giriniz");
            string cevap = Console.ReadLine();
            int sayi = Convert.ToInt32(cevap);
                if (sayi < 0)
                    break;

                else {
                    toplam += sayi;
                    adet++;
                }

                int ortalama = toplam / adet;
                Console.WriteLine("Girdiğiniz sayıların toplamı: " + toplam+" ortalamaları ise "+ortalama);
        }
    }
}

// Sayı giriniz
// 3
// Girdiğiniz sayıların toplamı: 3 ortalamaları ise 3
// Sayı giriniz
// 6
// Girdiğiniz sayıların toplamı: 9 ortalamaları ise 4
// Sayı giriniz
// 44
// Girdiğiniz sayıların toplamı: 53 ortalamaları ise 17
// Sayı giriniz
// 1000
// Girdiğiniz sayıların toplamı: 1053 ortalamaları ise 263
// Sayı giriniz
// -5
