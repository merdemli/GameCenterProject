using GameCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign,Game mage);
        void Add(List<Campaign> campaigns);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);

        //bool CheckIfOk(List<Game> games);

        
    }
}
