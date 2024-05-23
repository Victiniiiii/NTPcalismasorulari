// 1. Bir sınıftaki 150 öğrencinin vize notları verilsin.
//    a. En yüksek notu bulun.

using System;

class Program
{
    static void Main()
    {
        int[] notlar = new int[150];
        int max = 0;

        for (int i = 0; i < 150; i++)  
        {
            Console.WriteLine("Öğrencinin notunu giriniz:");
            notlar[i] = Convert.ToInt32(Console.ReadLine());             
            
            if (notlar[i] > max)  
            {
                max = notlar[i];
            }
        }

        Console.WriteLine("En yüksek not: " + max);  
    }
}
/*
Ögrencinin notunu giriniz:
78
Ögrencinin notunu giriniz:
1
Ögrencinin notunu giriniz:
1
Ögrencinin notunu giriniz:
1 
.... ( evet tamamını girdim)
Ögrencinin notunu giriniz:
1
En yüksek not: 78
*/
