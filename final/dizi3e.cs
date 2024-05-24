/* Dizi
    3-  Örneğimizde 20 elemanlı dizi içine rastgele 1-100 arası sayılar gireceğiz. Senaryomuz şu şekilde olacak. 20 kişilik bir sınıfın almış olduğu sınav notları ve bu notlarla ilgili aşağıdaki işlemlerin gerçekleştirilmesi.
        e- En yüksek notu bulunuz.
*/

using System;
class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] sayilar = new int [20];
        int maxnot = 1;

        for (int i = 0; i < 20; i++) {
            sayilar[i] = rnd.Next(1,100);
            if (maxnot < sayilar[i]) {
                maxnot = sayilar[i];
            }
        }

        Console.WriteLine("En yüksek not: "+maxnot);
    }
}

// En yüksek not: 97
