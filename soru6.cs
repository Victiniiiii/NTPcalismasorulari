// Bir sınıftaki öğrencilerin NTPG dersinden aldığı vize notlarının ortalamasını bulan C# programını yazınız. (belirsiz sayı)

class Program
{
    static void Main()
    {
        int toplam = 0;
        int adet = 0;

        while (true) {
            Console.WriteLine("Notu giriniz veya çıkmak için DUR");
            string input = Console.ReadLine();
            if (input=="DUR")
            {
                break;
            }
            else{
                int not = Convert.ToInt32(input);
                toplam += not;
                adet++;
            }
        }
        
        int ortalama = toplam / adet;
        Console.WriteLine("Notların ortalaması "+ortalama);
    }
}

// Notu giriniz veya çikmak için DUR
// 4
// Notu giriniz veya çikmak için DUR
// 8
// Notu giriniz veya çikmak için DUR
// 3
// Notu giriniz veya çikmak için DUR
// 2
// Notu giriniz veya çikmak için DUR
// 7
// Notu giriniz veya çikmak için DUR
// DUR
// Notlarin ortalamasi 4
