/* Matris
    10. 4x5 lik bir A matrisi giriliyor.
    c) Matrisin her bir sütunundaki elemanların enbüyüğünü ve hangi satır sütun indisine sahip olduğunu bulup yazdıran programı yazınız.
*/

using System;
class Program
{
    static void Main()
    {        
        int[,] matris = new int[4,5];
        int[] sutunenbuyuk = new int[5];
        int[] indeks = new int[5]; // indi'den kastı indeks herhalde ?
        Random rnd = new Random();

        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 5; j++) {
                matris[i,j] = rnd.Next(0,10);
                Console.Write(matris[i,j]+" ");
                if (matris[i,j] > sutunenbuyuk[j]) {
                    sutunenbuyuk[j] = matris[i,j];
                    indeks[j] = i;
                }
            }
            Console.WriteLine("");
        }
        for (int i = 0; i < 5; i++) {
            Console.WriteLine(i+". sütundaki en büyük sayı: "+sutunenbuyuk[i]+" ve indeksi: "+indeks[i]);
        }
    }
}

/* 
2 3 7 9 8 
3 1 1 6 7 
5 9 0 5 0 
5 9 2 6 0 
0. sütundaki en büyük sayi: 5 ve indeksi: 2
1. sütundaki en büyük sayi: 9 ve indeksi: 2
2. sütundaki en büyük sayi: 7 ve indeksi: 0
3. sütundaki en büyük sayi: 9 ve indeksi: 0
4. sütundaki en büyük sayi: 8 ve indeksi: 0 
*/
