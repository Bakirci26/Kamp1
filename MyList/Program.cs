
using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> names = new MyDictionary<string>();
            names.Add("Mustafa");
            names.Add("Berna");
            names.Add("Rana");
            names.Add("Ali");
            names.Print();
            Console.WriteLine(names.Count);
        }
    }
}