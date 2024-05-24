/* Dizi
1- int[] sayilar={4,5,-15,22,-34,3,0,7,43,100};  Yanda verilen diziyi tanımlayarak bir döngü yardımıyla aşağıdaki soruları çözünüz.
    b- sayilar dizisi içerisinde yer alan elemanları tersten alt alta yazdırınız Hazır fonksiyon kullanmayınız. (Örnek : için 100 den başlayarak 4 e doğru değerler ekrana yazdırılacak) */

using System;
class Program
{
    static void Main()
    {
        int[] sayilar={4,5,-15,22,-34,3,0,7,43,100};
        
        for (int i = 9; i >= 0 ; i--) {
            Console.Write(sayilar[i]+" ");
        }
    }
}

/* 100 43 7 0 3 -34 22 -15 5 4  */
