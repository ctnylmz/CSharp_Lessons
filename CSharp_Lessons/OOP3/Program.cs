using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needCreditManager = new NeedCreditManager();

            ICreditManager vehicleCreditManager = new VehicleCreditManager();

            ICreditManager homeCreditManager = new HomeCreditManager();

            ApplicationManager applicationManager = new ApplicationManager();

            List<ICreditManager> credits = new List<ICreditManager>()
            {
                needCreditManager,
                homeCreditManager
            };
            

            applicationManager.CreditSummary(credits);
        }
    }
}
