// Negatif değer girilinceye kadar Klavyeden girilen sayıların toplamını hesaplayan C# programını yazınız.

using System;
class Program
{
    static void Main()
    {
        int toplam = 0;

        while(true) {
            Console.WriteLine("Sayı giriniz");
            string cevap = Console.ReadLine();
            int sayi = Convert.ToInt32(cevap);
                if (sayi < 0)
                    break;

                else {
                    toplam += sayi;
                }

                Console.WriteLine("Girdiğiniz sayıların toplamı: " + toplam);
        }
    }
}

// Sayı giriniz
// 4
// Girdiğiniz sayıların toplamı: 4
// Sayı giriniz
// 7
// Girdiğiniz sayıların toplamı: 11
// Sayı giriniz
// 3
// Girdiğiniz sayıların toplamı: 14
// Sayı giriniz
// 1
// Girdiğiniz sayıların toplamı: 15
// Sayı giriniz
// 7
// Girdiğiniz sayıların toplamı: 22
// Sayı giriniz
// 3
// Girdiğiniz sayıların toplamı: 25
// Sayı giriniz
// 8
// Girdiğiniz sayıların toplamı: 33
// Sayı giriniz
// 3
// Girdiğiniz sayıların toplamı: 36
// Sayı giriniz
// -44
