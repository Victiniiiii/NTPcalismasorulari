/* Matris
    14. 5x5 lik bir A matrisi veriliyor. Matrisin her bir satırını büyükten küçüğe doğru sıralayarak yeni bir B matrisi oluşturan 
    bu iki matrisin farkını (C=A-B) bir C matrisine atayan ve sonucu ekrana matris biçiminde yazan bir program yazınız.
*/

using System;
class Program
{
    static void Main()
    {        
        int[,] amatris = new int[5,5];
        int[] amatrisflat  = new int[25];
        int[,] bmatris = new int[5,5];
        int[,] cmatris = new int[5,5];
        int zort = 0; 
        Random rnd = new Random();

        Console.WriteLine("A Matrisi:");

        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                amatris[i,j] = rnd.Next(0,10);
                Console.Write(amatris[i,j]+" ");
            }
            Console.WriteLine("");
        }

        Console.WriteLine("Düzleştirilmiş A Matrisi: ");
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                amatrisflat[zort] = amatris[i,j];
                Console.Write(amatrisflat[zort++]+" ");
            }
        }

        Console.WriteLine("");
        zort = 0;

        for (int i = 0; i < 5; i++) {
            Array.Sort(amatrisflat,zort,5);
            Array.Reverse(amatrisflat, zort, 5);
            zort += 5;
        }

        zort = 0;

        Console.WriteLine("B Matrisi: ");
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                bmatris[i,j] = amatrisflat[zort++];
                Console.Write(bmatris[i,j]+" ");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("C Matrisi");
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                cmatris[i,j] = amatris[i,j] - bmatris[i,j];
                Console.Write(cmatris[i,j]+" ");
            }
            Console.WriteLine("");
        }
    }
}
/* 
CANIM ÇIKTI YEMİN EDERİM

A Matrisi:
2 1 7 5 6 
0 2 8 0 9
5 0 1 1 5
3 9 5 5 6
0 4 1 6 3
Düzlestirilmis A Matrisi:
2 1 7 5 6 0 2 8 0 9 5 0 1 1 5 3 9 5 5 6 0 4 1 6 3
B Matrisi:
7 6 5 2 1
9 8 2 0 0
5 5 1 1 0
9 6 5 5 3
6 4 3 1 0
C Matrisi
-5 -5 2 3 5
-9 -6 6 0 9
0 -5 0 0 5
-6 3 0 0 3
-6 0 -2 5 3
*/
