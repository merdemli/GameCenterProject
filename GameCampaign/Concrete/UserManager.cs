using GameCampaign.Abstract;
using GameCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCampaign.Consrete
{
    class UserManager : IUserService
    {
        IUserValidationService _userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(User user)
        {
            if (_userValidationService.Validate(user)==true)
            {
                
                Console.WriteLine("The user named "  +user.FirstName+" "+user.LastName + " has been registered to the system.");
                
            }
            else
            {
                Console.WriteLine("Not a valid person");
            }

        }

        public void Delete(User user)
        {
            Console.WriteLine("The user named" + user.FirstName + " " + user.LastName + "has been deleted to the system.");
        }

        public void Update(User user)
        {
            Console.WriteLine("The user named" + user.FirstName + " " + user.LastName + "has been updated to the system."); ;
        }
    }
}
