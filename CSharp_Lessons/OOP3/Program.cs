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

            ILoogerService databaseLoggerService = new DatabaseLoggerService();
            ILoogerService fileLogerService = new FileLoggerService();

            List<ILoogerService> loogerServices = new List<ILoogerService>() {
            databaseLoggerService,
            fileLogerService


            };

            applicationManager.Do(homeCreditManager, loogerServices);

            List<ICreditManager> credits = new List<ICreditManager>()
            {
                needCreditManager,
                homeCreditManager
            };


            //applicationManager.CreditSummary(credits);
        }
    }
}
