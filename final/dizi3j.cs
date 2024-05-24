/* Dizi
    3-  Örneğimizde 20 elemanlı dizi içine rastgele 1-100 arası sayılar gireceğiz. Senaryomuz şu şekilde olacak. 20 kişilik bir sınıfın almış olduğu sınav notları ve bu notlarla ilgili aşağıdaki işlemlerin gerçekleştirilmesi.
        j- Sınıf ortalamasının altında kalan puanların ortalamasını bulunuz.
*/

using System;
class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] sayilar = new int [20];
        int ortalama = 0;
        int kalankisisayisi = 0;
        int kalanlartotalnot = 0;
        int kalanlarortalama = 0;

        for (int i = 0; i < 20; i++) {
            sayilar[i] = rnd.Next(1,100);
            ortalama = ortalama + sayilar[i]/20;
        }
        for (int i = 0; i < 20; i++) {
            if (sayilar[i] < ortalama) {
                kalanlartotalnot = kalanlartotalnot + sayilar[i];
                kalankisisayisi++;
            }
        }
        kalanlarortalama = kalanlartotalnot / kalankisisayisi;
        Console.WriteLine("Sınıfın ortalamasının altında kalan kişilerin ortalaması: "+kalanlarortalama);
    }
}

/* Sinifin ortalamasinin altinda kalan kisilerin ortalamasi: 22
*/
