// 1. Bir sınıftaki 150 öğrencinin vize notları verilsin.
//    e. Sınıf ortalamasının altında not alan kaç öğrenci vardır?

using System;
class Program
{
    static void Main()
    {
        int[] notlar = new int[15];
        int toplam = 0;
        int ortalama = 0;
        int adet = 0;

        for (int i = 0; i < 15; i++)  
        {
            Console.WriteLine("Öğrencinin notunu giriniz:");
            notlar[i] = Convert.ToInt32(Console.ReadLine());             
            toplam = toplam + notlar[i];
        }

        ortalama = toplam / 15;

        for (int i = 0; i < 15; i++)  
        {
            if (notlar[i] < ortalama) {
                adet++;
            }
        }

        Console.WriteLine("Sınıf ortalamasının altında not alan öğrenci sayısı: "+adet);
    }
}

// Sinif ortalamasinin altinda not alan ögrenci sayisi: 14
