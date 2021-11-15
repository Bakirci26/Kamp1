using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 5678;
            product1.Name = "Camera";
            product1.Price = 1000;


            Product product2 = new Product();
            product2.ID = 5679;
            product2.Name = "Laptop";
            product2.Price = 3500;


            Product product3 = new Product();
            product3.ID = 5680;
            product3.Name = "Phone";
            product3.Price = 2500;

            Product[] products = new Product[] { product1, product2, product3 };
            foreach (var product in products)
            {
                Console.WriteLine(product.ID+" "+product.Name+" "+product.Price);
            }
            Console.WriteLine("----------foreach loop-------------------------------------");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ID+" "+products[i].Name+" "+products[i].Price);
            }
            Console.WriteLine("-------------for loop---------------------------------------");

            int k = 0;
            while (k<products.Length)
            {
                Console.WriteLine(products[k].ID + " " + products[k].Name + " " + products[k].Price);
                k++;
            }
            Console.WriteLine("---------------while loop-------------------------------------");
        }
        class Product
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }

        }




    }
}
