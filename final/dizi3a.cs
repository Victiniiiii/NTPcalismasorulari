/* Dizi
    3-  Örneğimizde 20 elemanlı dizi içine rastgele 1-100 arası sayılar gireceğiz. Senaryomuz şu şekilde olacak. 20 kişilik bir sınıfın almış olduğu sınav notları ve bu notlarla ilgili aşağıdaki işlemlerin gerçekleştirilmesi.
        a- Geçen sayısını bulunuz. (Notu 50 ve üstü)
*/

using System;
class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] sayilar = new int [20];
        int gecenler = 0;

        for (int i = 0; i < 20; i++) {
            sayilar[i] = rnd.Next(1,100);
            if (sayilar[i] >= 50) {
                gecenler++;
            }
        }

        Console.WriteLine("Geçen öğrenci sayısı: "+gecenler);
    }
}

// Geçen ögrenci sayisi: 9
// https://tr.wikibooks.org/wiki/C_Sharp_Programlama_Dili/Rastgele_say%C4%B1_%C3%BCretme - Rastgele sayı üretme
