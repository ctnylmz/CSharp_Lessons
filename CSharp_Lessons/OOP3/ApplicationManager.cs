using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplicationManager
    {
        public void Do(ICreditManager creditManager,ILoogerService loogerService)
        {

            creditManager.Calculate();

            loogerService.Log();
        }

        public void CreditSummary(List<ICreditManager> credits)
        {
            foreach(var item in credits)
            {
                item.Calculate();
            }
        }

    }
}
