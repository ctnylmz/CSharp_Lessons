using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class DatabaseLoggerService : ILoogerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı");
        }
    }

   
}
