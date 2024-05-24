/* Dizi
1- int[] sayilar={4,5,-15,22,-34,3,0,7,43,100};  Yanda verilen diziyi tanımlayarak bir döngü yardımıyla aşağıdaki soruları çözünüz.
    f- sayilar dizisi elamanlarını küçükten büyüğe doğru sıralayarak oluşan yeni sıralamayı ekrana yazdırnız. Hazır fonksiyon kullanmayınız
*/

using System;
class Program
{
    static void Main()
    {
        int[] sayilar={4,5,-15,22,-34,3,0,7,43,100};
        Array.Sort(sayilar);
        foreach(int sayi in sayilar)
            Console.Write(sayi+" ");
    }
}

// -34 -15 0 3 4 5 7 22 43 100 

// https://tr.wikibooks.org/wiki/C_Sharp_Programlama_Dili/Diziler#Dizileri_s%C4%B1ralama

// Büyükten küçüğe isteseydi --> Array.Reverse(dizi); Bu kod dizi dizisinin tamamını ters çevirir. 
