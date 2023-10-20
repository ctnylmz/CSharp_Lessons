using System;
using _5DayHomeWork.Abstract;
using _5DayHomeWork.Concrete;
using _5DayHomeWork.Entities;

namespace _5DayHomeWork
{
    internal class Program
    {
        //Class
        static void Main(string[] args)
        {
        
           BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1985, 1, 6),
                FirstName = "Engin",
                LastName = "Demiroğ",
                NationalityId = "28861408"
            });



        }
    }
  
}
