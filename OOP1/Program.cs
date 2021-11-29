using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Sandalye";
            product1.UnıtPrice = 500;
            product1.UnitsInStock = 7;

            Product product2 = new Product();
            product2.ID = 2;
            product2.CategoryId = 3;
            product2.ProductName = "Kalem";
            product2.UnıtPrice = 400;
            product2.UnitsInStock = 8;

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

        }
    }
}
