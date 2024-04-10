class Program
{
    static void Main()
    {
        int faktoriyel = 1;
        Console.WriteLine("Bir sayı giriniz");
        string input = Console.ReadLine();
        int n = Convert.ToInt32(input);

        for (int i = n; i>=1; i--)
        {
            faktoriyel *= i;
        }

        Console.WriteLine("faktoriyel sonucu: "+faktoriyel);
    }
}

// Bir sayi giriniz
// 6
// faktoriyel sonucu: 720
