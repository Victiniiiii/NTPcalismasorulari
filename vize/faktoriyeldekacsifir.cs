// Klavyeden girilen sayı n olsun. n! i hesaplayan programı yazınız.

using System;
using System.Numerics; // <----- faktoriyel kullanacaginiz zaman 
class Program
{
    static void Main()
    {
        BigInteger faktoriyel = 1; // Faktöriyel sayıları çok büyük olduğu için en başta System.Numerics ile BigInteger'i aktive ettik ve burada int yerine BigInteger kullandık 
        Console.WriteLine("Bir sayı giriniz:");
        string input = Console.ReadLine();
        int n = Convert.ToInt32(input);
        int sifirsayisi = 0;

        for (int i = n; i > 0; i--){
            faktoriyel *= i;
            int j = i;

            while (true) {                
                if (j % 5 == 0) { // faktöriyelde sıfır sayısı beş ve iki sayılarından az olanın sayısına bağlı olduğu ve beşlerin sayısı hep ikiden daha az olduğu için burada beşe tam bölünme koşulunu koydum
                    j /= 5;
                    sifirsayisi += 1;
                } else {
                    break; // j 5'e daha fazla bölünemediği zaman loop'dan çık
                }
            }   
        }

        if (n < 0) {
            Console.WriteLine("Lütfen pozitif bir tam sayı giriniz.");
        }
        else {
            Console.WriteLine("Faktöriyel sonucu: " + faktoriyel + " ve sıfır sayısı ise "+sifirsayisi);
        }        
    }
}

// Bir sayi giriniz:
// 7
// Faktöriyel sonucu: 5040 ve sifir sayisi ise 1
// Bir sayi giriniz:
// 22
// Faktöriyel sonucu: 1124000727777607680000 ve sifir sayisi ise 4
// Bir sayi giriniz:
// 26
// Faktöriyel sonucu: 403291461126605635584000000 ve sifir sayisi ise 6
// Bir sayi giriniz:
// 50
// Faktöriyel sonucu: 30414093201713378043612608166064768844377641568960512000000000000 ve sifir sayisi ise 12
