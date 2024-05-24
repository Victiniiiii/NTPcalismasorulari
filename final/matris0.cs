/* Matris
C# ile iki 10×10 luk iki boyutlu bir dizi oluşturarak, oluşturulan bu çok boyutlu dizi içine rastgele sayılar atan ve daha sonra bu dizideki her bir satır ve sütunun toplamını hesaplayarak ekranda gösteren örneği oluşturalım.
Yukarıdaki soruların matriste/matrisin satırlarında uygulanması
*/

using System;
class Program
{
    static void Main()
    {
        int[,] matris = new int[10,10]; // virgül lazım
        Random rnd = new Random();
        int[] satirlartoplam = new int[10];
        int[] sutunlartoplam = new int[10];

        for (int i = 0; i < 10; i++) {            
            for (int j = 0; j < 10; j++) {
                matris[i,j] = rnd.Next(0,10);
                satirlartoplam[i] += matris[i,j];
                sutunlartoplam[j] += matris[i,j];
                Console.Write(matris[i,j]+" "); // bu ve altındaki satır matrisi yazdırmak için
            }
            Console.WriteLine(" "); // her satır bitince boşluk bırakıyor alt satıra geçmek için
        }

        for (int i = 0; i < 10; i++) {
            Console.WriteLine(i+". Satırın toplamı:"+satirlartoplam[i]);
        }

        for (int j = 0; j < 10; j++) {
            Console.WriteLine(j+". Sütünun toplamı:"+sutunlartoplam[j]);
        }
    }
}

/* 1 1 4 8 4 5 4 2 6 4  
9 2 0 7 8 3 4 1 7 3
2 0 3 1 8 5 2 6 5 9
6 7 7 5 0 3 1 8 9 9
9 0 2 1 1 5 0 2 5 9
8 5 0 6 7 7 3 7 0 5
9 4 6 1 7 5 2 8 2 7
3 6 9 3 9 6 8 6 8 9
8 2 5 3 2 1 7 1 1 8
7 5 4 6 7 3 7 7 6 0
0. Satirin toplami:39
1. Satirin toplami:44
2. Satirin toplami:41
3. Satirin toplami:55
4. Satirin toplami:34
5. Satirin toplami:48
6. Satirin toplami:51
7. Satirin toplami:67
8. Satirin toplami:38
9. Satirin toplami:52
0. Sütünun toplami:62
1. Sütünun toplami:32
2. Sütünun toplami:40
3. Sütünun toplami:41
4. Sütünun toplami:53
5. Sütünun toplami:43
6. Sütünun toplami:38
7. Sütünun toplami:48
8. Sütünun toplami:49
9. Sütünun toplami:63 */
