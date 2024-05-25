/* Matris
    10. 4x5 lik bir A matrisi giriliyor.
    a) Matrisin her bir satırındaki asal olan elemanlarının sayısını
*/

using System;
class Program
{
    static void Main()
    {        
        int[,] matris = new int[4,5];
        int[] asalsayisi = new int[4];
        Random rnd = new Random();
        bool asallik = true;

        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 5; j++) {
                matris[i,j] = rnd.Next(0,10);
                Console.Write(matris[i,j]+" ");
                asallik = true;
                for (int k = matris[i,j]-1; k>1; k--) {
                    if (matris[i,j] % k == 0) {
                        asallik = false;
                        break;
                    }
                }
                if (asallik == true && matris[i,j] != 0 && matris[i,j] != 1) {
                    asalsayisi[i] += 1;
                }
            }
            Console.WriteLine("");
        }
        for (int i = 0; i < 4; i++) {
            Console.WriteLine(i+". satırdaki asal sayı sayısı: "+asalsayisi[i]);
        }
    }
}

/* 
9 0 5 0 6 
1 7 0 8 3
0 4 4 8 5
6 3 7 7 5
0. satirdaki asal sayi sayisi: 1
1. satirdaki asal sayi sayisi: 2
2. satirdaki asal sayi sayisi: 1
3. satirdaki asal sayi sayisi: 4
*/
