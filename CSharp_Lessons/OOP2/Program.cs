using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Individual
            Individual individual1 = new Individual();
            individual1.Id = 1;
            individual1.CustomerNumber = "1";
            individual1.Name = "Çetin";
            individual1.Lastname = "Yılmaz";
            individual1.IdentificationNumber = "12345678910";


            //Corporate
            Corporate corporate1 = new Corporate();
            corporate1.Id = 2;
            corporate1.CustomerNumber = "001";
            corporate1.CompanyName = "Karsal Yazılım";
            corporate1.TaxNumber = "146514512";

            //SOLID

            Customer customer3 = new Individual();

            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individual1);
            customerManager.Add(corporate1);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

        }
    }
}
