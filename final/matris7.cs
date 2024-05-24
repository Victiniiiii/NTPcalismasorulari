/* Matris
    7. 30 kişilik bir sınıfta Matematik dersine ait vize notları ve öğrenci isimleri verilsin. Öğrencileri vize notlarına göre isimleriyle birlikte küçükten büyüğe sıralayınız.
*/

using System;
using System.Numerics;
class Program
{
    static void Main()
    {        
        Random rnd = new Random();
        int[] vizeler = new int[30];
        string[] isimler = new string[30];

        for (int i = 0; i < 30; i++) {
            Console.WriteLine("Öğrencinin ismini giriniz.");
            isimler[i] = Console.ReadLine();
            Console.WriteLine("Öğrencinin vize notunu giriniz.");
            vizeler[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(vizeler,isimler);
        Console.WriteLine("Öğrencilerin vize notlarına göre isimleriyle küçükten büyüğe sıralanışı: ");

        for (int i = 0; i < 30; i++) {            
            Console.WriteLine(isimler[i]+" isimli öğrenci vizeden "+vizeler[i]+" aldı.");
        }   
    }
}

/* Öğrencilerin vize notlarına göre isimleriyle küçükten büyüğe sıralanışı: 
a isimli öğrenci vizeden 1 aldı.
a isimli öğrenci vizeden 1 aldı.
a isimli öğrenci vizeden 1 aldı.
a isimli öğrenci vizeden 1 aldı.
enayi isimli öğrenci vizeden 1 aldı.
q isimli öğrenci vizeden 1 aldı.
q isimli öğrenci vizeden 1 aldı.
b isimli öğrenci vizeden 2 aldı.
c isimli öğrenci vizeden 3 aldı.
c isimli öğrenci vizeden 4 aldı.
d isimli öğrenci vizeden 5 aldı.
f isimli öğrenci vizeden 5 aldı.
e isimli öğrenci vizeden 6 aldı.
f isimli öğrenci vizeden 7 aldı.
g isimli öğrenci vizeden 8 aldı.
g isimli öğrenci vizeden 9 aldı.
h isimli öğrenci vizeden 10 aldı.
q isimli öğrenci vizeden 11 aldı.
as isimli öğrenci vizeden 12 aldı.
as isimli öğrenci vizeden 12 aldı.
as isimli öğrenci vizeden 12 aldı.
as isimli öğrenci vizeden 12 aldı.
as isimli öğrenci vizeden 12 aldı.
osuruk isimli öğrenci vizeden 12 aldı.
as isimli öğrenci vizeden 12 aldı.
as isimli öğrenci vizeden 13 aldı.
dursun isimli öğrenci mat2 vizesinden 20 aldı.
wef isimli öğrenci vizeden 23 aldı.
dsfs isimli öğrenci vizeden 44 aldı.
abdulmecided  isimli öğrenci vizeden 3333333 aldı. 
*/
