using GameCampaign.Abstract;
using GameCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign.Consrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign,Game game)
        {
            Console.WriteLine( "Added % " + campaign.DiscountRate+ " discount for" +game.GameName);
        }
        

        public void Add(List<Campaign> campaigns)
        {
            Console.WriteLine("Campaigns are added to the system");
        }

        //public bool CheckIfOk(List<Game> games)
        //{
        //    return true;
        //}
        


        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign" +campaign.CampaignName+" is deleted" ); ;
        }

        
        public void Update(Campaign campaign)
        {
            
            Console.WriteLine("Updated!");
        }

        
    }
}
