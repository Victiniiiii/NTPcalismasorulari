// 1. Bir sınıftaki 150 öğrencinin vize notları verilsin.
//    e. Sınıf ortalamasının altında not alan kaç öğrenci vardır?

using System;
class Program
{
    static void Main()
    {
        int[] notlar = new int[150];
        int toplam = 0;
        int ortalama = 0;
        int adet = 0;

        for (int i = 0; i < 150; i++)  
        {
            Console.WriteLine("Öğrencinin notunu giriniz:");
            notlar[i] = Convert.ToInt32(Console.ReadLine());             
            toplam = toplam + notlar[i];
        }

        ortalama = toplam / 150;

        for (int i = 0; i < 150; i++)  
        {
            if (notlar[i] < ortalama) {
                adet++;
            }
        }

        Console.WriteLine("Sınıf ortalamasının altında not alan öğrenci sayısı: "+adet);
    }
}

// Sinif ortalamasinin altinda not alan ögrenci sayisi: burayı gerçekten okuyor musun
