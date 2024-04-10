class Program
{
    static void Main()
    {
        int toplam = 0;
        int adet = 0;

        while(true) {
            Console.WriteLine("Sayı girin veya istemiyorsanız DUR yazın.");
            string cevap = Console.ReadLine();
                if (cevap == "DUR")
                    break;

                else {
                    int sayi = Convert.ToInt32(cevap);
                    toplam += sayi;
                    adet++;
                }

                int ortalama = toplam / adet ;
                Console.WriteLine("Girdiğiniz sayıların ortalaması: " + ortalama);
        }
    }
}

// Sayı girin veya istemiyorsanız DUR yazın.
// 555
// Girdiğiniz sayıların ortalaması: 555
// Sayı girin veya istemiyorsanız DUR yazın.
// 66
// Girdiğiniz sayıların ortalaması: 310
// Sayı girin veya istemiyorsanız DUR yazın.
// 222
// Girdiğiniz sayıların ortalaması: 281
// Sayı girin veya istemiyorsanız DUR yazın.
// 4444
// Girdiğiniz sayıların ortalaması: 1321
// Sayı girin veya istemiyorsanız DUR yazın.
// DUR
