using _GameProjectSimulation.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GameProjectSimulation.Abstract
{
    public interface IGamerCheckService
    {
        bool Validate(Gamer gamer);
    }
}
