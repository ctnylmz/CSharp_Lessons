using _GameProjectSimulation.Concrete;
using _GameProjectSimulation.Entites;
using System;

namespace _GameProjectSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                FirstName = "Çetin",
                LastName = "Yılmaz",
                DateOfBirth = new DateTime(2004,06, 01),
                Identity = "123"
            };

            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Create(gamer1);

            Sale sale1 = new Sale();
            sale1.Id = 1;
            sale1.Name = "Pubg";
            sale1.Price = 99;

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.Name = "Welcome %50";
            campaign1.DiscountRate = 0.5;


            SaleManager saleManager = new SaleManager();
            saleManager.Sale(gamer1, sale1, campaign1);



        }
    }
}
