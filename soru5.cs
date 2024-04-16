// Bir sınıftaki 144 öğrencinin NTPG dersinden aldığı vize notlarının ortalamasını bulan C# programını yazınız.

using System;
class Program
{
    static void Main()
    {
        int toplam = 0;

        for (int i = 0; i < 144; i++){
            Console.WriteLine("Notu giriniz");
            string giris = Console.ReadLine();
            int not = Convert.ToInt32(giris);
            toplam += not;
        }

        int ortalama = toplam / 144;
        Console.WriteLine("Notların ortalaması "+ortalama);
    }
}

// ( çalışıyor denedim ama çok uzun )
