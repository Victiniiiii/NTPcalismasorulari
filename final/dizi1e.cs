/* Dizi
1- int[] sayilar={4,5,-15,22,-34,3,0,7,43,100};  Yanda verilen diziyi tanımlayarak bir döngü yardımıyla aşağıdaki soruları çözünüz.
    e- sayilar dizisi içerisindeki en büyük negatif sayıyı bularak ekrana yazdırınız.
*/

using System;
class Program
{
    static void Main()
    {
        int[] sayilar={4,5,-15,22,-34,3,0,7,43,100};
        int max = 0;
        
        for (int i = 0; i < 10 ; i++) {
            if (max == 0 && sayilar[i] < 0) {max = sayilar[i];}
            else if (sayilar[i] < 0 && sayilar[i] > max) {max = sayilar[i];}            
        }

        Console.WriteLine("Negatif en büyük sayı: "+max);
    }
}

/* Negatif en büyük sayi: -15 ( bu soru muhtemelen daha iyi bir şekilde çözülebilirdi )
*/
