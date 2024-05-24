/* Dizi
1- int[] sayilar={4,5,-15,22,-34,3,0,7,43,100};  Yanda verilen diziyi tanımlayarak bir döngü yardımıyla aşağıdaki soruları çözünüz.
    a- sayilar dizisi içerisindeki 3 e bölünebilen değerleri ekrana alt alta yazdırınız */

using System;
class Program
{
    static void Main()
    {
        int[] sayilar={4,5,-15,22,-34,3,0,7,43,100};
        
        for (int i = 0; i < 10 ; i++) {
            if (sayilar[i] % 3 == 0) {
                Console.WriteLine(sayilar[i]);
            }
        }
    }
}

/* 
-15
3
0 */
