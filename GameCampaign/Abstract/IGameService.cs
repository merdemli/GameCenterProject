using GameCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign.Abstract
{
    interface IGameService
    {
        void Add(List<Game> game);
        void Delete(Game game);
        void Update(Game game);

    }
}
