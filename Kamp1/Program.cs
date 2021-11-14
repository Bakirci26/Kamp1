using System;

namespace Kamp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety-tip güvenliği
            //değer tutucu, alias
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 55000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 9.95;
            double dolarBugun = 9.98;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Dolar düşmüş");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Dolar artmış");
            }
            else
            {
                Console.WriteLine("Dolar sabit");
            }
            Console.WriteLine(kategoriEtiketi);



        }
    }
}
