/* Matris
    5. 3x2 ve 2x5 lik iki matrisin çarpımını yapan programı yazınız.
*/

using System;
class Program
{
    static void Main()
    {        
        Random rnd = new Random();
        int[,] ilkmatris = new int[3,2];
        int[,] ikincimatris = new int[2,5];
        int[,] sonucmatris = new int [3,5]; // sonuç 3x5 lik bir matris olacak

        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 2; j++) {
                ilkmatris[i,j]=rnd.Next(0,10);
                Console.Write(ilkmatris[i,j]+" ");
            }
            Console.WriteLine(" ");
        }

        Console.WriteLine(" "); 

        for (int i = 0; i < 2; i++) {
            for (int j = 0; j < 5; j++) {
                ikincimatris[i,j]=rnd.Next(0,10);
                Console.Write(ikincimatris[i,j]+" ");
            }
            Console.WriteLine(" ");
        }

        Console.WriteLine(" "); 

        for (int i = 0; i < 3 ; i++) {
            for (int j = 0; j < 5; j++) {
                for (int k = 0; k < 2; k++) {
                    sonucmatris[i,j] += ilkmatris[i,k] * ikincimatris[k,j];
                }
                Console.Write(sonucmatris[i,j]+" ");
            }
            Console.WriteLine(" ");
        }
    }
}

/*
8 7  
6 2
5 5

5 5 7 0 5
7 7 2 1 6

89 89 70 7 82
44 44 46 2 42
60 60 45 5 55 ( internetten kontrol ettim doğru )

*/
