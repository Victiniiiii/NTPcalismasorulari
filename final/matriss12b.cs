/* Matris
    12. Bir hastanedeki 10 hastanın günde 5 kez ateşi ölçülüyor.
    b) her bir ölçümdeki toplam ateş miktarını
*/

using System;
class Program
{
    static void Main()
    {        
        int[,] matris = new int[10,5]; // anladığım bir "ölçüm"den kastı, 10 kişinin bir kere ölçülmesi
        int[] toplam = new int[5];
        Random rnd = new Random();

        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 5; j++) {
                matris[i,j] = rnd.Next(30,40); 
                toplam[j] += matris[i,j];           
                Console.Write(matris[i,j]+" ");
            }
            Console.WriteLine("");
        }
        Console.Write("Toplam ateşler: ");
        for (int i = 0; i < 5; i++) {
            Console.Write(toplam[i]+" ");
        }
    }
}
/* 
30 33 37 35 35 
36 37 30 39 36
36 35 32 33 35
34 32 38 31 33
34 34 35 35 34
33 35 30 33 32
39 36 32 36 36
38 30 37 39 38
38 30 30 35 37
34 30 32 33 34
Toplam atesler: 352 332 333 349 350 */
