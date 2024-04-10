class Program
{
    static void Main()
    {
        Console.WriteLine("Bir sayı giriniz");
        string input = Console.ReadLine();
        int n = Convert.ToInt32(input);
        bool asallik = true;

        for(int i = n-1; i>1; i--)
        {
            if(n % i == 0){
                asallik = false;
                break;
            }
        }

        if (asallik==true && n != 1 ){
            Console.WriteLine("Asaldır");
        }
        else {
            Console.WriteLine("Asal değildir");
        }
    }
}


// Bir sayi giriniz
// 5
// Asaldir
// Bir sayi giriniz
// 3
// Asaldir
// Bir sayi giriniz
// 8
// Asal degildir
// Bir sayi giriniz
// 1
// Asal degildir
