/* Dizi
2-  string[] sehirler={"Kayıt Yok", "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara"}
    Yukarıda verilen diziyi tanımlayarak aşağıdaki soruları bu diziye göre çözünüz.
    a- Klavyeden plaka kodu girilen il adını ekrana yazdırınız. Girilen koda ait il yok ise kayıt bulunamadı olarak mesaj veriniz.
*/

using System;
class Program
{
    static void Main()
    {
        string[] sehirler={"Kayıt Yok", "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara"};
        Console.WriteLine("Bir plaka giriniz.");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input < 0 || input > 6) { // ortadaki || sembolü "OR" anlamına gelir ( veya )
            Console.WriteLine("Kayıt bulunamadı");
        }
        else {
            Console.WriteLine(sehirler[input]);
        }
    }
}

/* Bir plaka giriniz.
4
Agri
Bir plaka giriniz.
55
Kayit bulunamadi */
