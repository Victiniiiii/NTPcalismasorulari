// 10 dan 1 e kadar olan sayıların toplamını hesaplayan C# programını yazınız.
using System; 
class Program
{
    static void Main()
    {
        int toplam = 0;

        for (int i = 10; i >= 1; i--)
        {
            toplam += i;
        }

        Console.WriteLine("10'dan 1'e kadar olan sayıların toplamı: " + toplam);
    }
}

// 10'dan 1'e kadar olan sayıların toplamı: 55
