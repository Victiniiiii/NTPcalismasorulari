/* Dizi
    3-  Örneğimizde 20 elemanlı dizi içine rastgele 1-100 arası sayılar gireceğiz. Senaryomuz şu şekilde olacak. 20 kişilik bir sınıfın almış olduğu sınav notları ve bu notlarla ilgili aşağıdaki işlemlerin gerçekleştirilmesi.
        d- Notu 3 olan öğrenci sayısını bulunuz. (Notu 60-70 arası)
*/

using System;
class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] sayilar = new int [20];
        int notu3olanlar = 0;

        for (int i = 0; i < 20; i++) {
            sayilar[i] = rnd.Next(1,100);
            if (60 <= sayilar[i] && sayilar[i] <= 70) {
                notu3olanlar++;
            }
        }

        Console.WriteLine("Notu 3 olan öğrenci sayısı: "+notu3olanlar);
    }
}

// Notu 3 olan ögrenci sayisi: 1
