/* Matris
    3. Bir hastanede 120 hasta ve 20 doktor vardır. Her bir doktor 6 hastadan sorumlu olabilir. Bir doktor bir hastadan sorumlu ise 1 aksi halde 0 ile ifade edilir.
    b. hasta 2 ve hasta 60 tan sorumlu doktorları bulan programı yazınız.
*/

using System;
class Program
{
    static void Main()
    {
        int[,] matris = new int [120,20];
        int hastano = 0;
        Console.Write("Hasta 2 ve hasta 60 tan sorumlu doktorların numaraları: ");

        for (int i = 0; i < 20; i++) {
            for (int j = 0; j < 6; j++) {
                matris[i,j] = hastano++;
                
                if (hastano == 2 || hastano == 60) {
                    Console.Write(i+" "); 
                }             
            }            
        }
    }
}

/* Hasta 2 ve hasta 60 tan sorumlu doktorların numaraları: 0 9 
*/
