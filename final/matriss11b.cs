/* Matris
    11. 5x5 lik bir A matrisi giriliyor
    b) Matrisin her bir satırındaki pozitif elemanların ortalamasını bulup bu değeri o satırdaki elemanlara ekleyen
*/

using System;
class Program
{
    static void Main()
    {        
        Random rnd = new Random();
        int[,] amatris = new int[5,5];
        int[] pozitifsatirort = new int[5];
        int[] pozitifelemansayi = new int[5];

        for (int i = 0; i < 5; i++){
            for (int j = 0; j < 5; j++) {
                amatris[i,j] = rnd.Next(-9,9);
                Console.Write(amatris[i,j]+" ");
                if (amatris[i,j] > 0) {
                    pozitifsatirort[i] += amatris[i,j];
                    pozitifelemansayi[i]++;
                }
            }            
            Console.WriteLine("");
        }
        Console.WriteLine("Eklemeden sonra:");
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                amatris[i,j] += pozitifsatirort[i] / pozitifelemansayi[i];
                Console.Write(amatris[i,j]+" ");
            }
            Console.WriteLine("");
        }
    }
}

// double kullanılabilirdi ama çok üşendim 
/* 
0 5 4 -8 -9 
-5 -3 -2 3 -4
-1 3 1 4 2
-8 -4 -6 -2 3
3 5 6 1 -6
Eklemeden sonra:
4 9 8 -4 -5
-2 0 1 6 -1
1 5 3 6 4
-5 -1 -3 1 6
6 8 9 4 -3
*/
