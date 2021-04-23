using GameCampaign.Abstract;
using GameCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign.Adapters
{
    class MernisServiceAdapter : IUserValidationService
    {
        public bool Validate(User user)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();

            return client.TCKimlikNoDogrula(user.IDNumber, user.FirstName.ToUpper(), user.LastName.ToUpper(), user.DateOfBirth.Year); //bool döner

           
        }
       
    }
}

