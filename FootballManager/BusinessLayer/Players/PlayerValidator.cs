using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.BusinessLayer
{
    class PlayerValidator
    {
        public PlayerValidationResponse ValidatePlayer(string FirstName, string LastName, string Posistion,
            int Age, int Weight, int Height, int TeamID)
        {
            if (FirstName == string.Empty)
            {
                return new PlayerValidationResponse(false,"Please enter first name");
            }

            if (LastName == string.Empty)
            {
                return new PlayerValidationResponse(false, "Please enter last name");
            }

            if (Posistion == string.Empty)
            {
                return new PlayerValidationResponse(false, "Please enter position");
            }

            if (Age == 0)
            {
                return new PlayerValidationResponse(false, "Please enter age");
            }

            if (Weight == 0)
            {
                return new PlayerValidationResponse(false, "Please enter weight");
            }

            if (Height == 0)
            {
                return new PlayerValidationResponse(false, "Please enter height");
            }

            if (TeamID == 0)
            {
                return new PlayerValidationResponse(false, "Please enter teamid");
            }

            return new PlayerValidationResponse();
        }

        public PlayerValidationResponse DeletePlayer(int PlayersID)
        {
            if (PlayersID == 0)
            {
                return new PlayerValidationResponse(false, "ID not found");
            }
            return new PlayerValidationResponse();
        }
    }
}
