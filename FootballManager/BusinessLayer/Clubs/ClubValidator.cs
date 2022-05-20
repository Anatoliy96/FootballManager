using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.BusinessLayer.Clubs
{
    public class ClubValidator
    {
        public ClubValidationResponse ValidateNewClub(string Name, string Owner)
        {

            if (Name == string.Empty)
            {
                return new ClubValidationResponse(false, "Please enter club name.");
            }
            if (Owner == string.Empty)
            {
                return new ClubValidationResponse(false, "Pease enter club owner.");
            }
            return new ClubValidationResponse();
        }

        public ClubValidationResponse UpdateCurrentClub(string Name, string Owner, DateTime Founded)
        {
            if (Name == string.Empty)
            {
                return new ClubValidationResponse(false, "Please enter club name.");
            }

            else if (Owner == string.Empty)
            {
                return new ClubValidationResponse(false, "Please enter club owner");
            }

            else if (Founded == null)
            {
                return new ClubValidationResponse(false, "Please enter club Date");
            }
            return new ClubValidationResponse();
        }

        public ClubValidationResponse DeleteClub(int ClubsID)
        {
            if (ClubsID == 0)
            {
                return new ClubValidationResponse(false, "Select club id");
            }

            return new ClubValidationResponse();
        }
    }
}
