/* 2. Bir sınıftaki 150 öğrencinin vize, ödev ve final notları verilsin.
Geçme notu gn= (v*0.7+ö*0.3)*0.4 + f*0.6 olarak hesaplansın.
    c. Her öğrencinin hangi harf notunu aldığını bulun.
*/

using System;
class Program
{
    static void Main()
    {
        int[] vizeler = new int[150];
        int[] odevler = new int[150];
        int[] finaller = new int[150];
        double[] genelnotlar = new double[150];

        for (int i = 0; i < 150; i++)  
        {
            Console.WriteLine("Öğrencinin vize notunu giriniz:");
            vizeler[i] = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine("Öğrencinin ödev notunu giriniz:");
            odevler[i] = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine("Öğrencinin final notunu giriniz:");
            finaller[i] = Convert.ToInt32(Console.ReadLine());   
            genelnotlar[i] = vizeler[i] * 0.28 + odevler[i] * 0.12 + finaller[i] * 0.6;

            if (genelnotlar[i] >= 88) {Console.WriteLine(i+". öğrenci, AA aldı.");}
            else if (genelnotlar[i] >= 81) {Console.WriteLine(i+". öğrenci, BA aldı.");}
            else if (genelnotlar[i] >= 74) {Console.WriteLine(i+". öğrenci, BB aldı.");}
            else if (genelnotlar[i] >= 67) {Console.WriteLine(i+". öğrenci, CB aldı.");}
            else if (genelnotlar[i] >= 60) {Console.WriteLine(i+". öğrenci, CC aldı.");}
            else if (genelnotlar[i] >= 53) {Console.WriteLine(i+". öğrenci, DC aldı.");}
            else if (genelnotlar[i] >= 46) {Console.WriteLine(i+". öğrenci, DD aldı.");}
            else {Console.WriteLine(i+". öğrenci, FD aldı.");}
        }

    }
}

// 3. ögrenci, FD aldi.

/* 88 <= HBP <= 100 AA
81 <= HBP <= 87  BA
74 <= HBP <= 80  BB
67 <= HBP <= 73  CB
60 <= HBP <= 66  CC
53 <= HBP <= 59  DC
46 <= HBP <= 52  DD
00 <= HBP <= 45  FD
 */
