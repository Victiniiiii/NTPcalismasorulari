/* Matris
    13. Elemanları tamsayı olan 10x10 luk bir A matrisi veriliyor. Matrisin her bir elemanın kaçar kez tekrarlandığını bulup yazdıran bir program yazınız.
*/

using System;
class Program
{
    static void Main()
    {        
        int[,] matris = new int[10,10];
        Random rnd = new Random();
        int[] tekrarlananlar = new int[10]; // bunun boyutunun 10 olmasının sebebi, rnd.next'in ikinci elemanından ilk elemanı çıkarırsak buluruz

        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                matris[i,j] = rnd.Next(0,10);
                Console.Write(matris[i,j]+" ");
                tekrarlananlar[matris[i,j]]++;
            }
            Console.WriteLine("");
        }
        Console.WriteLine("Tekrarlanma sayıları: ");
        foreach (int tekrar in tekrarlananlar)
            Console.Write(tekrar+" ");
    }
}
/* 
2 7 7 1 9 5 1 1 0 0 
0 7 7 7 2 8 5 8 9 6
4 9 2 2 7 8 5 6 2 0
6 7 9 3 2 4 5 5 7 5
9 1 5 4 4 2 0 3 4 9
1 0 5 6 4 0 6 2 6 6
6 2 5 8 8 0 7 6 7 9
1 7 2 8 9 4 8 8 2 5
4 7 2 0 4 8 4 9 0 7
1 4 0 5 0 5 6 7 4 3
Tekrarlanma sayilari:
12 7 12 3 12 12 10 14 9 9 */
