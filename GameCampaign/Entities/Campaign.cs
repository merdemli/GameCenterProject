using GameCampaign.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign.Entities
{
    class Campaign:IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public float DiscountRate { get; set; }
    }
}
