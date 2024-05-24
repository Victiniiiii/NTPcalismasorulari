/* Matris
    3. Bir hastanede 120 hasta ve 20 doktor vardır. Her bir doktor 6 hastadan sorumlu olabilir. Bir doktor bir hastadan sorumlu ise 1 aksi halde 0 ile ifade edilir.
    a. 3. doktorun sorumlu olduğu hastaları bulan,
*/

using System;
class Program
{
    static void Main()
    {
        int[,] matris = new int [120,20];
        int hastano = 0;
        Console.Write("3. doktorun sorumlu olduğu hastaların numaraları: ");

        for (int i = 0; i < 20; i++) {
            for (int j = 0; j < 6; j++) {
                matris[i,j] = hastano++;
                
                if (i == 3) {
                    Console.Write(hastano+" "); 
                }             
            }            
        }
    }
}

/* 3. doktorun sorumlu olduğu hastaların numaraları: 19 20 21 22 23 24 
*/
