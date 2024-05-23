// 1. Bir sınıftaki 150 öğrencinin vize notları verilsin.
//    b. En düşük not alan öğrenciyi bulun.

using System;

class Program
{
    static void Main()
    {
        int[] notlar = new int[150];
        int min = 100;

        for (int i = 0; i < 150; i++)  
        {
            Console.WriteLine("Öğrencinin notunu giriniz:");
            notlar[i] = Convert.ToInt32(Console.ReadLine());             
            
            if (notlar[i] < min)  
            {
                min = notlar[i];
            }
        }

        Console.WriteLine("En düşük not: " + min);  
    }
}
/*
öncekinin aynısı
*/
