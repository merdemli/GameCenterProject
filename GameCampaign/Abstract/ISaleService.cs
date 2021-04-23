using GameCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign.Abstract
{
     interface ISaleService
    {
        void Order(Game game, Gamer gamer);
        void OrderWithCampaign(Game game, Campaign campaign);
        void OrderWithCampaign(List<Game> game, Campaign campaign);
    }

}
