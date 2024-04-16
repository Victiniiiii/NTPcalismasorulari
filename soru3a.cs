// Klavyeden girilen 5 sayının toplamını hesaplayan C# programını yazınız.
using System; // online compiler kullanıyorsanız using System yazmalısınız
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

        Console.WriteLine("Girdiğiniz 5 sayının toplamı: " + toplam);
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
// Girdiğiniz 5 sayının toplamı: 15
