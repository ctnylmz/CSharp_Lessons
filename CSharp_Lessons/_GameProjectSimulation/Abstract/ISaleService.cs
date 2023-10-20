using _GameProjectSimulation.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GameProjectSimulation.Abstract
{
    public interface ISaleService
    {
         void Sale(Gamer gamer , Sale sale,Campaign campaign);
    }
}
