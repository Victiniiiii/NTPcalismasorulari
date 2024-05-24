/* Matris
    4. verilen bir x değeri için ∑_(i=1)^100▒(x^i-i!)/(x-5) ifadesini hesaplayınız.
*/

using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        Console.WriteLine("Bir x değeri giriniz.");
        int x = Convert.ToInt32(Console.ReadLine());
        BigInteger sonuc = 0;
        BigInteger ifaktoriyel = 1; // faktöriyel gördüğünde BigInteger ( en başta system.numerics unutma )

        for (int i = 1; i < 100; i++) {
            ifaktoriyel *= i;
            sonuc += (x^i - ifaktoriyel) / (x-5);
        }

        Console.WriteLine("Sonuç değeri:" + sonuc);
    }
}

/* i 100'e kadar çıkıyor, ve i faktöriyel sonucun hesaplanmasında kullanılıyor, doğruluğundan emin olmak zor ama
Bir x değeri giriniz.
1
Sonuç değeri:235696559941456644790148817051709845338688587400262743586348852601769557562397603614707529360654545183227800880052222342910414780339139110584132230105233805
*/
