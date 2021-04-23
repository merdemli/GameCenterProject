using GameCampaign.Adapters;
using GameCampaign.Consrete;
using GameCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new MernisServiceAdapter());

            User gamer2 = new Gamer();

            userManager.Add(new Gamer
            {
                DateOfBirth = new DateTime(1988, 10, 18),
                FirstName = "MERVE",
                LastName = "ERDEMLİ",
                IDNumber = 1111111111,
                NickName = "Chichiro"


            });
            Console.ReadLine();


            Game game1 = new Game();
            game1.GameName = "MineCraft";
            game1.GamePrice = 500;
            game1.Id = 1;


            Game game2 = new Game { Id = 2, GamePrice = 600, GameName = "CS" };
            Game game3 = new Game() { GameName = "Mario", GamePrice = 100, Id = 3 };

          

            List<Game> games = new List<Game> { game1, game2, game3 };

            SaleManager saleManager = new SaleManager();


            //saleManager.OrderWithCampaign(game1, new Campaign()
            //{
            //    CampaignId = 1,
            //    CampaignName = "BlackFriday",
            //    DiscountRate = 40

            //});

            saleManager.OrderWithCampaign(games, new Campaign()
            {
                CampaignId = 2,
                CampaignName = "BlackFriday",
                DiscountRate = 20
            });

            Console.ReadLine();

            
        }
    }
}


