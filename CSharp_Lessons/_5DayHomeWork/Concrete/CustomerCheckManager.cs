using _5DayHomeWork.Abstract;
using _5DayHomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5DayHomeWork.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
      

        bool ICustomerCheckService.CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
