// Klavyeden girilen sayı n olsun. n in mükemmel sayı olup olmadığını hesaplayan programı yazınız.

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Bir sayı giriniz");
        string input = Console.ReadLine();
        int n = Convert.ToInt32(input);
        int tambolenlertoplami = 0;

        for(int i = n-1; i>0; i--)
        {
            if(n % i == 0){
                tambolenlertoplami += i;
            }
        }

        if (n == tambolenlertoplami) {
            Console.WriteLine("Sayınız "+n+" ve tam bölenler toplamı "+tambolenlertoplami+" ve sayınız mükemmel! ");
        }
        else {
            Console.WriteLine("Sayınız "+n+" ve tam bölenler toplamı "+tambolenlertoplami+" ve sayınız mükemmel değil.");
        }
    }
}

// Bir sayi giriniz
// 28
// Sayiniz 28 ve tam bölenler toplami 28 ve sayiniz mükemmel!
// Bir sayi giriniz
// 6
// Sayiniz 6 ve tam bölenler toplami 6 ve sayiniz mükemmel!
// Bir sayi giriniz
// 8128
// Sayiniz 8128 ve tam bölenler toplami 8128 ve sayiniz mükemmel!
// Bir sayi giriniz
// 5000
// Sayiniz 5000 ve tam bölenler toplami 6715 ve sayiniz mükemmel degil.
