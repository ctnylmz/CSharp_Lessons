using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string productName = "Elma";
            //string description = "Amasya Elması";
            //double price = 15;


            Products products1 = new Products();
            products1.Name = "Elma";
            products1.Description = "Amasya Elamsı";
            products1.Price = 15;

            Products products2 = new Products();
            products2.Name = "Karpuz";
            products2.Description = "Adana Karpuzu";
            products2.Price = 200;

            Products[] products = new Products[] { products1,products2};

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.Price);
                Console.WriteLine("----------------------");
            }


            Console.WriteLine("------------ Methods  ----------");

            BasketManager basketManager = new BasketManager();
            basketManager.Add(products2);
        }
    }
}
