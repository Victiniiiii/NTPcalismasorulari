/* Matris
    11. 5x5 lik bir A matrisi giriliyor
    c) Matrisin üst üçgenindeki 4 ile tam bölünebilen elemanların en büyüğünü bulan
*/

using System;
class Program
{
    static void Main()
    {        
        Random rnd = new Random();
        int[,] matris = new int[5,5];
        int[] sayilar = new int [10];
        int max = 0; int zort = 0;

        for (int i = 0; i < 5; i++){
            for (int j = 0; j < 5; j++) {
                matris[i,j] = rnd.Next(0,111);
                Console.Write(matris[i,j]+" ");
                if (j > i && matris[i,j] % 4 == 0 && matris[i,j] != 0) {
                    sayilar[zort] = matris[i,j];
                }
            }            
            Console.WriteLine("");
        }

        foreach (int sayi in sayilar)
            if (sayi > max) {
                max = sayi;
            }
        Console.WriteLine("Matrisin üst üçgeninde 4 ile tam bölünebilen elemanların en büyüğü: "+max);
    }
}


/* 
73 15 7 57 96 
91 47 27 53 72
14 94 26 42 5
12 84 6 3 50
78 102 23 11 15
Matrisin üst üçgeninde 4 ile tam bölünebilen elemanlarin en büyügü: 72
*/
