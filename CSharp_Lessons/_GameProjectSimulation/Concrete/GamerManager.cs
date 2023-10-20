using _GameProjectSimulation.Abstract;
using _GameProjectSimulation.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GameProjectSimulation.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Create(Gamer gamer)
        {
            if (_gamerCheckService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Created.");
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Deleted.");
        }

        public void Read(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Readed.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Updated.");
        }
    }
}
