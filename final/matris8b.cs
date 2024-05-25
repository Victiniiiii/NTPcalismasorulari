/* Matris
    8. 5 x 5 lik bir A matrisi girildiğinde
    b) Matrisin her bir sütunundaki elemanların çarpımını,
*/

using System;
class Program
{
    static void Main()
    {        
        int[,] matris = new int[5,5];
        int[] sutuncarpim = new int[5];
        Random rnd = new Random();
        
        for (int i = 0; i < 5; i++) {
            sutuncarpim[i] += 1; // diziler oluşurken içleri 0 olarak oluşurlar, ama çarpımları bulmak için 1 yapmam gerek
        }

        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                matris[i,j] = rnd.Next(0,10);
                sutuncarpim[j] *= matris[i,j];
                Console.Write(matris[i,j]+" ");
            }
            Console.WriteLine("");
        }

        foreach (int sutun in sutuncarpim)
            Console.WriteLine("Sütunun çarpımı: "+sutun);
    }
}

/* 9 6 1 3 6 
6 2 0 5 1
7 6 4 2 6
9 2 8 5 3
1 1 2 1 3
Sütunun çarpimi: 3402
Sütunun çarpimi: 144
Sütunun çarpimi: 0
Sütunun çarpimi: 150
Sütunun çarpimi: 324 */
