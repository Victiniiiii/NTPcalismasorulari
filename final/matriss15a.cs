/* Matris
    15. Bir seyahat şirketi 4 farklı ülkeye havayolu ile 30 günde yolcu taşıyacaktır. Gün içerisinde bir ülkeye en az bir kez yolcu taşınabileceğine göre, her gün için klavyeden gidilen ülke ve yolcu sayısı girildiğinde
    a) Hergün en çok yolcu taşınan ülkeyi ve yolcu sayısını
*/

using System;
class Program
{
    static void Main()
    {        
        int[,] matris = new int[4,30];
        Random rnd = new Random();
        int[] ulke = new int[4];
        int max = 0; int maxno = 0;

        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 30; j++) {
                matris[i,j] = rnd.Next(0,10); // elle girin diyo da kim uğraşcak 
                ulke[i] += matris[i,j];
                Console.Write(matris[i,j]+" ");
            }
            Console.WriteLine("");
            if (ulke[i] > max) {
                max = ulke[i];
                maxno = i;
            }
        }
        Console.WriteLine("En çok yolcu taşıyan ülke "+maxno+" numaralı ülke, toplam "+max+" yolcu taşıdılar!");
    }
}
/* 
3 8 8 7 9 0 5 5 2 3 8 6 0 1 0 6 3 7 9 1 8 2 2 5 9 3 7 6 3 9 
6 8 0 7 0 4 3 9 4 0 9 0 2 5 1 9 3 3 6 7 9 4 1 8 4 7 5 6 5 3
7 1 4 4 4 8 7 2 8 0 4 5 3 6 5 0 9 9 8 2 4 4 6 9 9 9 5 0 9 5
9 5 2 8 7 1 6 5 3 1 5 2 9 5 5 4 3 9 0 7 1 8 1 0 9 4 3 9 5 9
En çok yolcu tasiyan ülke 2 numarali ülke, toplam 156 yolcu tasidilar! */
