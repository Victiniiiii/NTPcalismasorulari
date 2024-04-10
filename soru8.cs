// Klavyeden girilen sayı n olsun. n! i hesaplayan programı yazınız.

using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger faktoriyel = 1;
        Console.WriteLine("Bir sayı giriniz:");
        string input = Console.ReadLine();
        int n = Convert.ToInt32(input);

        for (int i = n; i >= 1; i--)
        {
            faktoriyel *= i;
        }

        Console.WriteLine("Faktöriyel sonucu: " + faktoriyel);
    }
}


// Bir sayi giriniz
// 6
// faktoriyel sonucu: 720

// Bir sayi giriniz:
// 31
// Faktöriyel sonucu: 8222838654177922817725562880000000
