using _GameProjectSimulation.Abstract;
using _GameProjectSimulation.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GameProjectSimulation.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sale(Gamer gamer, Sale sale, Campaign campaign)
        {
            var newPrice = (sale.Price * campaign.DiscountRate);

            Console.WriteLine(gamer.FirstName +  " " + gamer.LastName + " adlı kullanıcının " + sale.Name + " " 
                + sale.Price + " TL " + "Ürünü Vardır." + " Kapanya : " + campaign.Name + " " + " Yeni Fiyatı : " + newPrice);
        }

       
    }
}
