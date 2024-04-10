class Program
{
    static void Main()
    {
        int toplam = 0;
        Console.WriteLine("Bir sayı giriniz.");
        string giris = Console.ReadLine();
        int n = Convert.ToInt32(giris);

        for (int i = 1; i <= n; i++)
        {
            toplam += i;
        }

        Console.WriteLine("1'den " + n + "e kadar olan sayıların toplamı: " + toplam);
    }
}


// Bir sayı giriniz.
// 15
// 1'den 15e kadar olan sayıların toplamı: 120
