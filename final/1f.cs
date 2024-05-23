// 1. Bir sınıftaki 150 öğrencinin vize notları verilsin.
//    f. Sınıf ortalamasının üstünde not alan öğrenci numaralarını ekrana yazdırın.

using System;
class Program
{
    static void Main()
    {
        int[] notlar = new int[150];
        int toplam = 0;
        int ortalama = 0;

        for (int i = 0; i < 150; i++)  
        {
            Console.WriteLine("Öğrencinin notunu giriniz:");
            notlar[i] = Convert.ToInt32(Console.ReadLine());             
            toplam = toplam + notlar[i];
        }

        ortalama = toplam / 150;

        for (int i = 0; i < 150; i++)  
        {
            if (notlar[i] > ortalama) {
                Console.WriteLine(i);
            }
        }
    }
}

/*  10
11
12
13
14 */
