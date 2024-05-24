/* Dizi
1- int[] sayilar={4,5,-15,22,-34,3,0,7,43,100};  Yanda verilen diziyi tanımlayarak bir döngü yardımıyla aşağıdaki soruları çözünüz.
    d- sayilar dizisi içerisindeki en büyük sayıyı bularak sonucu ekrana yazdırınız.
*/

using System;
class Program
{
    static void Main()
    {
        int[] sayilar={4,5,-15,22,-34,3,0,7,43,100};
        int max = sayilar[0];
        
        for (int i = 0; i < 10 ; i++) {
            if (sayilar[i]>max) {max = sayilar[i];}            
        }

        Console.WriteLine("En büyük sayı: "+max);
    }
}

/* En büyük sayi: 100
*/
