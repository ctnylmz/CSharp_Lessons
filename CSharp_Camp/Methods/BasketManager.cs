using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class BasketManager
    {
        public void Add(Products products)
        {
            Console.WriteLine(products.Name  + " "+ "Sepete Eklendi");
        }
    }
}
