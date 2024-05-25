/* Matris
    15. Bir seyahat şirketi 4 farklı ülkeye havayolu ile 30 günde yolcu taşıyacaktır. Gün içerisinde bir ülkeye en az bir kez yolcu taşınabileceğine göre, her gün için klavyeden gidilen ülke ve yolcu sayısı girildiğinde
    b) 30 gün sonunda en az yolcunun taşındığı ülkeyi ve yolcu sayısını
*/

using System;
class Program
{
    static void Main()
    {        
        int[,] matris = new int[4,30];
        Random rnd = new Random();
        int[] ulke = new int[4];
        int min = 0; int minno = 0;

        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 30; j++) {
                matris[i,j] = rnd.Next(0,10); // elle girin diyo da kim uğraşcak 
                ulke[i] += matris[i,j];
                Console.Write(matris[i,j]+" ");
            }
            Console.WriteLine("");
            if (i == 0) {
                min = ulke[0];
            }
            else if (ulke[i] < min) {
                min = ulke[i];
                minno = i;
            }
        }
        Console.WriteLine("En az yolcu taşıyan ülke "+minno+" numaralı ülke, toplam "+min+" yolcu taşıdılar!");
    }
}
/* 
6 4 1 8 1 6 7 4 4 4 1 5 8 9 5 9 6 0 8 9 8 8 8 4 1 4 3 3 7 5 
3 4 0 7 4 9 4 6 8 9 9 0 7 0 9 2 3 8 8 7 8 8 2 5 8 4 2 0 7 8
4 8 3 4 0 0 7 4 1 7 3 7 9 6 5 1 7 1 5 5 4 9 2 7 9 3 1 3 0 9
8 6 7 5 5 6 6 1 4 8 4 0 7 0 8 5 1 0 3 9 1 3 2 8 9 3 3 4 4 3
En az yolcu tasiyan ülke 3 numarali ülke, toplam 133 yolcu tasidilar!
*/
