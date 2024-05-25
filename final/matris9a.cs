/* Matris
    9. 6x6 lıkbir A matrisi girildiğinde
    a) matrisin üst üçgenindeki elemanların en küçüğünü
*/

using System;
class Program
{
    static void Main()
    {        
        int[,] matris = new int[6,6];
        int min = 10; // en büyük rastgele sayı 10 olduğu için 10 dedim. duruma göre rnd.next'daki ikinci elemana eşitlenebilir.
        Random rnd = new Random();

        for (int i = 0; i < 6; i++) {
            for (int j = 0; j < 6; j++) {
                matris[i,j] = rnd.Next(0,10);
                Console.Write(matris[i,j]+" ");
                if (i < j && matris[i,j] < min) { 
                    min = matris[i,j];
                }
            }
            Console.WriteLine("");
        }
        Console.WriteLine("Matrisin üst üçgenindeki elemanların en küçüğü: "+min);
    }
}

/* 
8 7 7 7 4 4 
1 3 6 6 9 7
9 3 5 6 4 4
3 1 0 0 4 6
1 5 7 5 2 8
7 8 3 4 3 3
Matrisin üst üçgenindeki elemanlarin en küçügü: 4
*/
