using GameCampaign.Abstract;
using GameCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign.Consrete
{


    class SaleManager : ISaleService
    {


        public void Order(Game game, Gamer gamer)
        {
            Console.WriteLine(" dear " + gamer.FirstName + " you can buy " + game.GameName + " for " + game.GamePrice);
        }

        public void OrderWithCampaign(Game game, Campaign campaign)
        {
            if (game.GamePrice > 400)
            {
                float finalprice = game.GamePrice - (game.GamePrice * campaign.DiscountRate / 100);
                Console.WriteLine("dear user you can buy " + " " + game.GameName + " game " + finalprice + " TL with " + campaign.CampaignName);

            }
            else
            {
                Console.WriteLine("Kampanya dışı");
            }
        }

        public void OrderWithCampaign(List<Game> games, Campaign campaign)
        {
            foreach (var i in games)
            {
                if (i.GamePrice > 400)
                {
                    float finalprice = i.GamePrice - (i.GamePrice * campaign.DiscountRate / 100);
                    Console.WriteLine("dear user you can buy " + " " + i.GameName + " game " + finalprice + " TL with " + campaign.CampaignName);
                    Console.WriteLine(".............................................");
                }
                else
                {
                    Console.WriteLine("Kampanya dışı");
                }
            }
            


        }
    }
}