/* Matris
    8. 5 x 5 lik bir A matrisi girildiğinde
    c) Matrisin köşegen elamanlarının kaç tanesinin 3 ile bölünebildiğini bulup yazdıran program yazınız.
*/

using System;
class Program
{
    static void Main()
    {        
        int[,] matris = new int[5,5];
        int bolunen = 0;
        Random rnd = new Random();

        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                matris[i,j] = rnd.Next(0,10);
                Console.Write(matris[i,j]+" ");
                if (i == j && matris[i,j] % 3 == 0 && matris[i,j] != 0) { // 3'e bölünebilenlerden 0'ı çıkardım
                    bolunen++;
                }
            }
            Console.WriteLine("");
        }
        Console.WriteLine("Üçe bölünebilen matris köşegen elemanı sayısı: "+bolunen);
    }
}

/*
0 5 4 9 4 
4 6 7 9 7
4 0 1 9 3
9 4 2 0 7
3 2 9 3 9
Üçe bölünebilen matris kösegen elemani sayisi: 2 
*/
