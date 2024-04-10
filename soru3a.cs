// Klavyeden girilen 5 sayının toplamını hesaplayan C# programını yazınız.

class Program
{
    static void Main()
    {
        Console.WriteLine("İlk sayıyı giriniz.");
        string sayibir = Console.ReadLine();
        int n1 = Convert.ToInt32(sayibir);

        Console.WriteLine("İkinci sayıyı giriniz.");
        string sayiiki = Console.ReadLine();
        int n2 = Convert.ToInt32(sayiiki);

        Console.WriteLine("Üçüncü sayıyı giriniz.");
        string sayiuc = Console.ReadLine();
        int n3 = Convert.ToInt32(sayiuc);

        Console.WriteLine("Dördüncü sayıyı giriniz.");
        string sayidort = Console.ReadLine();
        int n4 = Convert.ToInt32(sayidort);

        Console.WriteLine("Beşinci sayıyı giriniz.");
        string sayibes = Console.ReadLine();
        int n5 = Convert.ToInt32(sayibes);

        int toplam = n1 + n2 + n3 + n4 + n5;

        Console.WriteLine("Girdiğiniz 5 sayının toplamı: " + toplam);
    }
}

// İlk sayıyı giriniz.
// 7
// İkinci sayıyı giriniz.
// 9
// Üçüncü sayıyı giriniz.
// 13
// Dördüncü sayıyı giriniz.
// 55
// Beşinci sayıyı giriniz.
// 44
// Girdiğiniz 5 sayının toplamı: 128
