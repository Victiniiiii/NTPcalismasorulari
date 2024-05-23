/* 2. Bir sınıftaki 150 öğrencinin vize, ödev ve final notları verilsin.
Geçme notu gn= (v*0.7+ö*0.3)*0.4 + f*0.6 olarak hesaplansın.
    b. Her harf notundan kaç öğrencinin olduğunu belirleyin.
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
        int AA = 0; int BA = 0; int BB = 0; int CB = 0; int CC = 0; int DC = 0; int DD = 0; int FD = 0; 

        for (int i = 0; i < 150; i++)  
        {
            Console.WriteLine("Öğrencinin vize notunu giriniz:");
            vizeler[i] = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine("Öğrencinin ödev notunu giriniz:");
            odevler[i] = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine("Öğrencinin final notunu giriniz:");
            finaller[i] = Convert.ToInt32(Console.ReadLine());   
            genelnotlar[i] = vizeler[i] * 0.28 + odevler[i] * 0.12 + finaller[i] * 0.6;

            if (genelnotlar[i] >= 88) {AA++;}
            else if (genelnotlar[i] >= 81) {BA++;}
            else if (genelnotlar[i] >= 74) {BB++;}
            else if (genelnotlar[i] >= 67) {CB++;}
            else if (genelnotlar[i] >= 60) {CC++;}
            else if (genelnotlar[i] >= 53) {DC++;}
            else if (genelnotlar[i] >= 46) {DD++;}
            else {FD++;}
        }

        Console.WriteLine("Her harf notundan öğrenci sayıları; AA: " +AA+ " BA: " +BA+ " BB: " +BB+ " CB: " +CB+ " CC: " +CC+ " DC: " +DC+ " DD: " +DD+ " FD: " +FD);
    }
}

// Her harf notundan ögrenci sayilari; AA: 0 BA: 0 BB: 2 CB: 1 CC: 1 DC: 0 DD: 0 FD: 1 ( 5 kişilik çalıştırdım )

/* 88 <= HBP <= 100 AA
81 <= HBP <= 87  BA
74 <= HBP <= 80  BB
67 <= HBP <= 73  CB
60 <= HBP <= 66  CC
53 <= HBP <= 59  DC
46 <= HBP <= 52  DD
00 <= HBP <= 45  FD
 */
