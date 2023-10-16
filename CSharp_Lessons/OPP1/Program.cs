using System;

namespace OOP1
{
     class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 1;
            product1.Name = "Iphone 15";
            product1.Price = 50.000;
            product1.Stock = 9;

            Product product2 = new Product{
            Id = 2,
            CategoryId = 1,
            Name = "Iphone 15 Plus",
            Price = 60.000,
            Stock = 3,
            };

            Product product3 = new Product{
                Id = 2,
                CategoryId = 1,
                Name = "Iphone 15 Pro",
                Price = 80.000,
                Stock = 4,
            };

            Product product4 = new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "Iphone 15 Pro Max",
                Price = 95.000,
                Stock = 7,
            };

            ProductManager productManager = new ProductManager();
             productManager.Create(product1);


        }
    }
}
