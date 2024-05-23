// 1. Bir sınıftaki 150 öğrencinin vize notları verilsin.
//    d. Sınıf ortalamasını bulun.

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
        Console.WriteLine("Sınıf ortalaması: " + ortalama);  
    }
}

// çalışıyor denendi onaylandı
