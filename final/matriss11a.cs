/* Matris
    11. 5x5 lik bir A matrisi giriliyor
    a) Alt üçgenindeki elemanları büyükten küçüğe doğru sıralayıp yazdıran
*/

using System;
class Program
{
    static void Main()
    {        
        Random rnd = new Random();
        int[,] amatris = new int[5,5];
        int[] altucgen = new int[10];
        int zort = 0;

        for (int i = 0; i < 5; i++){
            for (int j = 0; j < 5; j++) {
                amatris[i,j] = rnd.Next(0,9);
                Console.Write(amatris[i,j]+" ");
                if (i > j) {
                    altucgen[zort++] = amatris[i,j];
                }
            }
            Console.WriteLine("");
        }
        Array.Sort(altucgen);
        Array.Reverse(altucgen);
        Console.WriteLine("");
        foreach (int alt in altucgen)
            Console.Write(alt+" ");
    }
}


/* 
4 1 7 5 5 
2 0 0 8 6
8 2 1 6 2
1 7 6 0 8
2 7 6 7 6

8 7 7 7 6 6 2 2 2 1 
*/
