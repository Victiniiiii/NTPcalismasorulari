/* Matris
    15. Bir seyahat şirketi 4 farklı ülkeye havayolu ile 30 günde yolcu taşıyacaktır. Gün içerisinde bir ülkeye en az bir kez yolcu taşınabileceğine göre, her gün için klavyeden gidilen ülke ve yolcu sayısı girildiğinde
    c) 2. ülkeye en çok yolcunun taşındığı günü ve yolcu sayını bulup yazdıran bir program yazınız.
*/

using System;
class Program
{
    static void Main()
    {        
        int[,] matris = new int[4,30];
        Random rnd = new Random();
        int[] ulke = new int[4];
        int yolcusayisi = 0;
        int maxday = 0;
        int maxdayyolcu = 0;

        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 30; j++) {
                matris[i,j] = rnd.Next(0,100); 
                Console.Write(matris[i,j]+" ");
                if (i == 2 && matris[i,j] > maxdayyolcu) {
                    maxday = j;
                    maxdayyolcu = matris[i,j];
                }
            }
            Console.WriteLine("");
        }
        Console.WriteLine("2. ülkeye en çok yolcunun taşındığı gün "+maxday+ " ve yolcu sayısı "+maxdayyolcu);
    }
}
/* 
85 29 98 82 91 48 49 38 24 43 84 39 39 41 12 29 12 2 77 26 51 36 34 95 98 3 39 13 69 22 
81 78 45 99 58 45 34 54 17 9 5 0 12 6 23 49 61 95 33 89 70 68 46 67 68 72 94 2 50 67
16 94 94 93 65 7 49 33 32 13 1 24 69 18 6 7 80 36 60 3 53 84 95 41 1 93 37 29 82 0
73 35 53 89 1 28 71 81 7 47 28 82 5 87 33 8 86 71 54 61 25 19 29 3 56 81 41 51 47 96
2. ülkeye en çok yolcunun tasindigi gün 22 ve yolcu sayisi 95
*/
