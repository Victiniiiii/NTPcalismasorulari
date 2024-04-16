// 8! i hesaplayan programı yazınız.

using System;
class Program
{
    static void Main()
    {
        int faktoriyel = 1;

        for (int i = 8; i>=1; i--)
        {
            faktoriyel *= i;
        }

        Console.WriteLine("faktoriyel sonucu: "+faktoriyel);
    }
}

// faktoriyel sonucu: 40320
