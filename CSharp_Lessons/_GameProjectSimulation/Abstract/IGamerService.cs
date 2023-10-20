using _GameProjectSimulation.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GameProjectSimulation.Abstract
{
    public interface IGamerService
    {
        void Create(Gamer gamer);
        void Read(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
