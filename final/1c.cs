// 1. Bir sınıftaki 150 öğrencinin vize notları verilsin.
//    c. 70-80 aralığında not alan kaç öğrenci vardır?

using System;
class Program
{
    static void Main()
    {
        int[] notlar = new int[150];
        int sayi = 0;

        for (int i = 0; i < 150; i++)  
        {
            Console.WriteLine("Öğrencinin notunu giriniz:");
            notlar[i] = Convert.ToInt32(Console.ReadLine());             
            
            if (notlar[i] >= 70 && notlar[i] <= 80)
            {
                sayi++;
            }
        }

        Console.WriteLine("70-80 aralığında not alan öğrenci sayısı: " + sayi);  
    }
}

/* Ögrencinin notunu giriniz:
73
Ögrencinin notunu giriniz:
74
Ögrencinin notunu giriniz:
75
Ögrencinin notunu giriniz:
76
Ögrencinin notunu giriniz:
77
Ögrencinin notunu giriniz:
1
Ögrencinin notunu giriniz:
1
Ögrencinin notunu giriniz:
1
.... baya bir sayıda 1
70-80 araliginda not alan ögrenci sayisi: 5 */
