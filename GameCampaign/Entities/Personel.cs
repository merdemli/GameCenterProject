using GameCampaign.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign.Entities
{
    class Personel: User,IEntity
    {
        public string Department { get; set; }
    }
}
