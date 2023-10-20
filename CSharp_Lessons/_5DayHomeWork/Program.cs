using System;

namespace _5DayHomeWork
{
    internal class Program
    {
        //Class
        static void Main(string[] args)
        {
        
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Çetin";
            customer.LastName = "Yılmaz";
            customer.City = "İstanbul";

            Console.WriteLine(customer.FirstName + " " + customer.LastName );



        }
    }
  
}
