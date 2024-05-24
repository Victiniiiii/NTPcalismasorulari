/* Dizi
1- int[] sayilar={4,5,-15,22,-34,3,0,7,43,100};  Yanda verilen diziyi tanımlayarak bir döngü yardımıyla aşağıdaki soruları çözünüz.
    c- sayilar dizisi içerisinde yeralan elemanlardan kaçtanesi çift , kaçtanesi tek sayı olduğunu bularak sonucu ekrana yazdırınız. */

using System;
class Program
{
    static void Main()
    {
        int[] sayilar={4,5,-15,22,-34,3,0,7,43,100};
        int tek = 0;
        int cift = 0;
        
        for (int i = 0; i < 10 ; i++) {
            if (sayilar[i]%2 == 0){cift++;}
            else {tek++;}
        }

        Console.WriteLine("Tekler sayısı "+tek+", çiftler sayısı ise "+cift);
    }
}

/* Tekler sayisi 5, çiftler sayisi ise 5 
*/
