using GameCampaign.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign.Entities
{
    class Gamer : User, IEntity
    {
        public string CardNumber { get; set; }
        public string NickName { get; set; }
    }
}
