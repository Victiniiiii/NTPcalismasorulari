/* Matris
    12. Bir hastanedeki 10 hastanın günde 5 kez ateşi ölçülüyor.
    c) her bir hastanın günlük ölçümlerinden kaç tanesinin hastanın ortalama ateşinden fazla olduğunu bulan bir program yazınız
*/

using System;
class Program
{
    static void Main()
    {        
        int[,] matris = new int[10,5]; // anladığım bir "ölçüm"den kastı, 10 kişinin bir kere ölçülmesi
        int[] ortalama = new int[10];
        int[] ortalamaustu = new int[10];
        Random rnd = new Random();

        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 5; j++) {
                matris[i,j] = rnd.Next(30,40); 
                ortalama[i] += matris[i,j]/5;           
                Console.Write(matris[i,j]+" ");
            }
            Console.WriteLine("");
        }
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 5; j++) {
                if (matris[i,j] > ortalama[i]){
                    ortalamaustu[i]++;
                }          
            }
            Console.WriteLine(i+". hastanın ortalama üstündeki sıcaklık sayısı: "+ortalamaustu[i]);
        }
    }
}
/* 
38 35 36 38 30 doğru mu gram fikrim yok ama doğru gibi
32 32 33 30 37
33 34 38 32 39
35 38 34 33 36
33 37 38 32 36
30 32 32 30 30
33 34 39 38 35
32 38 30 34 36
32 32 32 33 34
39 34 30 31 39
0. hastanin ortalama üstündeki sicaklik sayisi: 4
1. hastanin ortalama üstündeki sicaklik sayisi: 4
2. hastanin ortalama üstündeki sicaklik sayisi: 4
3. hastanin ortalama üstündeki sicaklik sayisi: 4
4. hastanin ortalama üstündeki sicaklik sayisi: 3
5. hastanin ortalama üstündeki sicaklik sayisi: 2
6. hastanin ortalama üstündeki sicaklik sayisi: 4
7. hastanin ortalama üstündeki sicaklik sayisi: 3
8. hastanin ortalama üstündeki sicaklik sayisi: 5
9. hastanin ortalama üstündeki sicaklik sayisi: 3
*/
