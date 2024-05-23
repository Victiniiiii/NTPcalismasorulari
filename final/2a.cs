/* 2. Bir sınıftaki 150 öğrencinin vize, ödev ve final notları verilsin.
Geçme notu gn= (v*0.7+ö*0.3)*0.4 + f*0.6 olarak hesaplansın.
    a. En yüksek gn alan öğrenciyi bulun. */

using System;
class Program
{
    static void Main()
    {
        int[] vizeler = new int[150];
        int[] odevler = new int[150];
        int[] finaller = new int[150];
        double[] genelnotlar = new double[150]; // yüksek ihtimalle virgüllü olacağı için double kullandım
        double maxnot = 0;
        int maxogrenci = 0;

        for (int i = 0; i < 150; i++)  
        {
            Console.WriteLine("Öğrencinin vize notunu giriniz:");
            vizeler[i] = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine("Öğrencinin ödev notunu giriniz:");
            odevler[i] = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine("Öğrencinin final notunu giriniz:");
            finaller[i] = Convert.ToInt32(Console.ReadLine());   
            genelnotlar[i] = vizeler[i] * 0.28 + odevler[i] * 0.12 + finaller[i] * 0.6;

            if (genelnotlar[i] > maxnot) {
                maxnot = genelnotlar[i];
                maxogrenci = i;
            }
        }

        Console.WriteLine("En yüksek genel not alan öğrenci " +maxnot + " ortalama ile " +maxogrenci+ ". sıradaki öğrenci");
    }
}

// En yüksek genel not alan ögrenci 90 ortalama ile 3. siradaki ögrenci
