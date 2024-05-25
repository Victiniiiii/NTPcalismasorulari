/* Matris
    12. Bir hastanedeki 10 hastanın günde 5 kez ateşi ölçülüyor.
    a) her bir hastanın ortalama ateşini
*/

using System;
class Program
{
    static void Main()
    {        
        int[,] matris = new int[10,5];
        int[] ortalamalar = new int[10];
        Random rnd = new Random();

        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 5; j++) {
                matris[i,j] = rnd.Next(30,40);
                ortalamalar[i] += matris[i,j]/5;
                Console.Write(matris[i,j]+" ");
            }
            Console.WriteLine("");
        }
        Console.Write("Ortalama ateşler: ");
        for (int i = 0; i < 10; i++) {
            Console.Write(ortalamalar[i]+" ");
        }
    }
}

/* doğrudur herhalde
36 38 32 34 39 
39 37 32 35 33
30 33 38 37 33
30 32 36 32 33
30 34 34 30 31
32 32 35 34 39
39 35 36 32 33
30 39 36 32 31
36 30 38 33 37
39 31 30 33 36
Ortalama atesler: 33 33 32 31 30 32 33 32 33 32 
*/
