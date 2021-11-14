using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.Egitmen = "Mustafa BAKIRCI";
            kurs1.IzlenmeOranı = 50;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Java";
            kurs2.Egitmen = "Seher BAKIRCI";
            kurs2.IzlenmeOranı = 100;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Phyton";
            kurs3.Egitmen = "Gökhan BAKIRCI";
            kurs3.IzlenmeOranı = 45;



            //Console.WriteLine(kurs1.KursAdı+":"+kurs1.Egitmen);
            //Console.WriteLine(kurs2.KursAdı+":"+kurs2.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı+" : "+kurs.Egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdı { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
