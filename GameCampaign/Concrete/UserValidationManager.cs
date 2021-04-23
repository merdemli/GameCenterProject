using GameCampaign.Abstract;
using GameCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign.Consrete
{
    class UserValidationManager : IUserValidationService //test environment
    {
        public bool Validate(User user)
        {
            return true;
           
        }
    }
}
