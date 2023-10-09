using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP1
{
    class ProductManager
    {
        public void Create(Product product) 
        {
            Console.WriteLine(product.Name + " Eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.Name + " Düzenlendi.");
        }

       
    }
}
