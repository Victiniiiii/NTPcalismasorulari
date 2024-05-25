/* Matris
    8. 5 x 5 lik bir A matrisi girildiğinde
    a) Matrisin her bir satırındaki elemanların toplamını,
*/

using System;
class Program
{
    static void Main()
    {        
        int[,] matris = new int[5,5];
        int[] satirtoplam = new int[5];
        Random rnd=new Random();

        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                matris[i,j] = rnd.Next(0,10);
                satirtoplam[i] += matris[i,j];
                Console.Write(matris[i,j]+" ");
            }
            Console.WriteLine("");
        }

        foreach (int satir in satirtoplam)
            Console.WriteLine("Satırın toplamı: "+satir);
    }
}

/* 
5 7 8 2 8 
2 1 7 3 9
0 6 5 9 6
1 1 0 7 3
0 2 8 6 2
Satirin toplami: 30
Satirin toplami: 22
Satirin toplami: 26
Satirin toplami: 12
Satirin toplami: 18 
*/
