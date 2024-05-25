/* Matris
    9. 6x6 lıkbir A matrisi girildiğinde
    b) matrisin her bir satırındaki elemanların en büyüğünü ve hangi satır sütun indisinden elde edildiğini bulup yazdıran bir programı yazınız.
*/

using System;
class Program
{
    static void Main()
    {        
        int[,] matris = new int[6,6];
        int[] max = new int[6];
        int[] maxindeks = new int[6];
        Random rnd = new Random();

        for (int i = 0; i < 6; i++) {
            for (int j = 0; j < 6; j++) {
                matris[i,j] = rnd.Next(0,10);
                Console.Write(matris[i,j]+" ");
                if (matris[i,j] > max[i]) { 
                    max[i] = matris[i,j];
                    maxindeks[i] = j;
                }
            }
            Console.WriteLine("");
        }

        for (int i = 0; i < 6; i++) {
            Console.WriteLine(i+". satırın en büyük elemanı: "+max[i]+", ve bu elemanın sütun indeksi: "+maxindeks[i]);
        }
    }
}

/* 
2 6 5 6 0 4 
5 3 3 6 8 6
6 4 5 2 9 0
4 6 8 9 4 0
0 2 6 1 4 2
6 6 7 6 1 8
0. satirin en büyük elemani: 6, ve bu elemanin sütun indeksi: 1
1. satirin en büyük elemani: 8, ve bu elemanin sütun indeksi: 4
2. satirin en büyük elemani: 9, ve bu elemanin sütun indeksi: 4
3. satirin en büyük elemani: 9, ve bu elemanin sütun indeksi: 3
4. satirin en büyük elemani: 6, ve bu elemanin sütun indeksi: 2
5. satirin en büyük elemani: 8, ve bu elemanin sütun indeksi: 5
*/
