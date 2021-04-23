using GameCampaign.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign.Entities
{
    class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public float GamePrice { get; set; }
        public List<Campaign> Campaigns { get; set; }

    }
}
