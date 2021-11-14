using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Bakırcı1 = "Baba";
            //string Bakrıcı2 = "Anne";
            //string Bakırcı3 = "Cocuk";

            string[] bakırcılar = new string[] {"Baba","Anne","Cocuk","Çocuk2" }; //dinamikleştirdik.



            for (int i = 0; i < bakırcılar.Length; i++)
            {
                Console.WriteLine(bakırcılar[i]);
            }

            Console.WriteLine("For döngüsü bitti");


            foreach (string bakırcı in bakırcılar)  //dizi temelli yapıları tek tek döneye yarıyor.
            {
                Console.WriteLine(bakırcı);         //"bakırcı" her bir elemanı dönerken verdiğimiz takma isim
            }
        }
    }
}
