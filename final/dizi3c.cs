/* Dizi
    3-  Örneğimizde 20 elemanlı dizi içine rastgele 1-100 arası sayılar gireceğiz. Senaryomuz şu şekilde olacak. 20 kişilik bir sınıfın almış olduğu sınav notları ve bu notlarla ilgili aşağıdaki işlemlerin gerçekleştirilmesi.
        c- Notu 5 olan öğrenci sayısını bulunuz. (Notu 85 ve üstü)
*/

using System;
class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] sayilar = new int [20];
        int notu5olanlar = 0;

        for (int i = 0; i < 20; i++) {
            sayilar[i] = rnd.Next(1,100);
            if (sayilar[i] >= 85) {
                notu5olanlar++;
            }
        }

        Console.WriteLine("Notu 5 olan öğrenci sayısı: "+notu5olanlar);
    }
}

// Notu 5 olan ögrenci sayisi: 3
// https://tr.wikibooks.org/wiki/C_Sharp_Programlama_Dili/Rastgele_say%C4%B1_%C3%BCretme - Rastgele sayı üretme
