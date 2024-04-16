// Klavyeden girilen sayı n olsun. n! i hesaplayan programı yazınız.

using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        BigInteger faktoriyel = 1; // Faktöriyel sayıları çok büyük olduğu için en başta System.Numerics ile BigInteger'i aktive ettik ve burada int yerine BigInteger kullandık 
        Console.WriteLine("Bir sayı giriniz:");
        string input = Console.ReadLine();
        int n = Convert.ToInt32(input);

        for (int i = n; i >= 1; i--)
        {
            faktoriyel *= i;
        }

        if (n < 0) {
            Console.WriteLine("Lütfen pozitif bir tam sayı giriniz.");
        }
        else {
            Console.WriteLine("Faktöriyel sonucu: " + faktoriyel);
        }        
    }
}

// Bir sayi giriniz
// 6
// faktoriyel sonucu: 720
// Bir sayi giriniz:
// 31
// Faktöriyel sonucu: 8222838654177922817725562880000000
// Bir sayi giriniz:
// -3
// Lütfen pozitif bir tam sayi giriniz.
