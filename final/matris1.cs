/* Matris
    1. 10x10 boyutundaki A matrisine 0-100 arasında değerler giriliyor.A matrisini 20x5 boyutundaki B matrisine aktarınız.
*/

using System;
class Program
{
    static void Main()
    {
        int[,] Amatris = new int[10,10];
        int[,] Bmatris = new int[20,5];
        Random rnd = new Random();

        for (int i = 0; i < 10; i++) {            
            for (int j = 0; j < 10; j++) {
                Amatris[i,j] = rnd.Next(0,10);
                Console.Write(Amatris[i,j]+" "); // bu ve altındaki satır matrisi yazdırmak için
            }
            Console.WriteLine(" "); // her satır bitince boşluk bırakıyor alt satıra geçmek için
        }

        int[] flatAmatris = new int[100]; // 2 boyutludan tek boyutluya indirmeye çalışıyorum
        int zort = 0;

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                flatAmatris[zort++] = Amatris[i, j];
            }
        }

        int zort2 = 0;        
        Console.WriteLine(" "); // iki matris arasında boşluk

        for (int i = 0; i < 20; i++) {
            for (int j = 0; j < 5; j++) {
                Bmatris[i,j] = flatAmatris[zort2++];
                Console.Write(Bmatris[i,j]+" "); 
            }
            Console.WriteLine(" ");
        }
    }
}

/* 2 5 2 1 8 2 1 6 1 3  
5 3 9 2 1 4 1 1 2 0
3 8 4 4 2 7 2 0 0 5
1 0 8 2 6 6 5 6 4 8
2 3 8 5 5 7 4 0 8 3
7 1 7 7 6 2 0 9 4 2
5 3 5 7 6 2 1 2 1 8
7 0 3 6 7 7 5 8 0 4
5 1 7 3 8 8 0 7 3 8
9 1 6 5 1 6 5 7 8 7

2 5 2 1 8
2 1 6 1 3
5 3 9 2 1
4 1 1 2 0
3 8 4 4 2
7 2 0 0 5
1 0 8 2 6
6 5 6 4 8
2 3 8 5 5
7 4 0 8 3
7 1 7 7 6
2 0 9 4 2
5 3 5 7 6
2 1 2 1 8
7 0 3 6 7
7 5 8 0 4
5 1 7 3 8
8 0 7 3 8
9 1 6 5 1
6 5 7 8 7 */
