/* Dizi
    3-  Örneğimizde 20 elemanlı dizi içine rastgele 1-100 arası sayılar gireceğiz. Senaryomuz şu şekilde olacak. 20 kişilik bir sınıfın almış olduğu sınav notları ve bu notlarla ilgili aşağıdaki işlemlerin gerçekleştirilmesi.
        b- Kalan sayısını bulunuz. (Notu 50′ den düşük.
*/

using System;
class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] sayilar = new int [20];
        int kalanlar = 0;

        for (int i = 0; i < 20; i++) {
            sayilar[i] = rnd.Next(1,100);
            if (sayilar[i] < 50) {
                kalanlar++;
            }
        }
        Console.WriteLine("Kalan öğrenci sayısı: "+kalanlar);
    }
}

// Kalan ögrenci sayisi: 7
// https://tr.wikibooks.org/wiki/C_Sharp_Programlama_Dili/Rastgele_say%C4%B1_%C3%BCretme - Rastgele sayı üretme
