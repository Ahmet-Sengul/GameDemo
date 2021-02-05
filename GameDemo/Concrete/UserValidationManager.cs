using GameDemo.Abstract;
using GameDemo.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.DogumYılı == 2000 && gamer.FirstName ==
                "Ahmet" && gamer.LastName == "Şengül" && gamer.TcNo == "12587456398")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
