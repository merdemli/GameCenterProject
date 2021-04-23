using GameCampaign.Abstract;
using GameCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign.Concrete
{
    class GameManager : IGameService
    {
        public void Add(List<Game>games)
        {
            foreach (var game in games)
            {
                Console.WriteLine(game.GameName + " is added the bag! ");
            }
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " deleted the bag!" );
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " updated the bag!");
        }
    }
}
