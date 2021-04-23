using GameCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign.Abstract
{
    interface IUserValidationService
    {
        bool Validate(User user);
    }
}
