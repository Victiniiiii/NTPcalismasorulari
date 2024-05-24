/* Matris
    2. 30 elemanlı A ve B dizileri verilsin. her dizi için en küçük çift sayıyı bulan programı yazınız
*/

using System;
class Program
{
    static void Main()
    {
        int[] Adizi = new int[30];
        int[] Bdizi = new int[30];
        int Amin = 100; // :)
        int Bmin = 100; 
        Random rnd = new Random();

        for (int i = 0; i < 30; i++) {
            Adizi[i] = rnd.Next(0,100);
            Bdizi[i] = rnd.Next(0,100);
            if (i != 0 && Adizi[i] % 2 == 0 && Adizi[i] < Amin) { // 30 rastgele sayının hiç birinin çift olmama olasılığı inanılmaz düşük olduğu için hesaba katmadım 
                Amin = Adizi[i];
            }
            if (i != 0 && Bdizi[i] % 2 == 0 && Bdizi[i] < Bmin) { // tüm koşullara ayrı ayrı bakması için else kullanmadım, else olsaydı iki koşul geçerli olsa da sadece üstteki çalışırdı
                Bmin = Bdizi[i];
            }
        }

        Console.WriteLine("A dizisinin en küçük çift sayısı: "+Amin+" ve B dizisinin en küçük çift sayısı: "+Bmin);
    }
}

/* A dizisinin en küçük çift sayısı: 10 ve B dizisinin en küçük çift sayısı: 6
*/
