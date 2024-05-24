/* Matris
    6. 100 adet (a,b,c) üçlüsü verilsin. Y=a+b+c. Asal olan Y değerlerini büyükten küçüğe sıralayınız.
*/

using System;
class Program
{
    static void Main()
    {        
        Random rnd = new Random();
        int[,] dizi = new int[100,3];
        int[] y = new int[100];
        int[] asaly = new int[100];
        int zort = 0;

        for (int i = 0; i < 100; i++) {
            bool asallik = true;
            for (int j = 0; j < 3; j++) {
                dizi[i,j] = rnd.Next(0,10);
                Console.Write(dizi[i,j]+" ");
                y[i] += dizi[i,j];
            }

            for (int k = y[i]-1; k>1; k--) {            
                if(y[i] % k == 0) {
                    asallik = false;
                    break;
                }
            }

            if (asallik == true && y[i] != 1 ) {
                asaly[zort++] = y[i];
            }

            Console.WriteLine("");
        }

        Array.Sort(asaly);
        Array.Reverse(asaly);

        foreach (int asal in asaly)
            if (asal > 0) {
                Console.Write(asal+" ");
            }
    }
}

/* 23 19 19 19 19 17 17 17 17 17 17 17 17 17 17 13 13 13 13 13 11 11 11 11 11 11 11 11 7 3 3

canım çıktı yeminle */
