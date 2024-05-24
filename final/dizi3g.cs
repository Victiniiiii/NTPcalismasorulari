/* Dizi
    3-  Örneğimizde 20 elemanlı dizi içine rastgele 1-100 arası sayılar gireceğiz. Senaryomuz şu şekilde olacak. 20 kişilik bir sınıfın almış olduğu sınav notları ve bu notlarla ilgili aşağıdaki işlemlerin gerçekleştirilmesi.
        g- En düşük puan alan öğrencinin 2. sınavda alması gereken puanı bulunuz.
*/

using System;
class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] sayilar = new int [20];
        int minnot = 100;

        for (int i = 0; i < 20; i++) {
            sayilar[i] = rnd.Next(1,100);
            if (minnot > sayilar[i]) {
                minnot = sayilar[i];
            }
        }

        // 1. sınavın %40, 2. sınavın %60 olduğunu , ayrıca geçme notunun 60 (aslında 59.5) olduğunu farzediyorum

        double gereknot = (59.5 - (minnot * 0.4)) / 0.6;
        Console.WriteLine("En düşük alan öğrencinin ikinci sınavda alması gereken not: "+gereknot);
    }
}

/* En düsük alan ögrencinin ikinci sinavda almasi gereken not: 87.83333333333334
En düsük alan ögrencinin ikinci sinavda almasi gereken not: 97.83333333333334 */
