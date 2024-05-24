/* Dizi
2-  string[] sehirler={"Kayıt Yok", "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara"}
    Yukarıda verilen diziyi tanımlayarak aşağıdaki soruları bu diziye göre çözünüz.
    b- Klavyeden il adı girilen ile ait plaka kodunu ekrana yazdırınız. Plaka kodu bulunamayan il için kayıt bulunamadı mesajını veriniz
*/

using System;
class Program
{
    static void Main()
    {
        string[] sehirler={"Kayıt Yok", "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara"};
        Console.WriteLine("Bir il giriniz.");
        int sonuc = Array.BinarySearch(sehirler,Console.ReadLine());
        if (sonuc < 0) {
            Console.Write("Kayıt bulunamadı");
        } else {
            Console.Write(sonuc);
        }
    }
}

// https://tr.wikibooks.org/wiki/C_Sharp_Programlama_Dili/Diziler#Dizilerde_arama

/* Bir il giriniz.
Ankara
6
Bir il giriniz.
Amasya
5
Bir il giriniz.
Suşi
Kayit bulunamadi */
