using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.BusinessLayer.Coaches
{
    class CoachValidator
    {
        public CoachValidationResponse ValidateCoach(string FirstName, string LastName, string Type, DateTime BirthDate,
            int TeamID)
        {
            if (FirstName == string.Empty)
            {
                return new CoachValidationResponse(false, "Enter coach name");
            }
            if (LastName == string.Empty)
            {
                return new CoachValidationResponse(false, "Enter coach last name");
            }
            if (Type == string.Empty)
            {
                return new CoachValidationResponse(false,"Enter coach type");
            }
            if (BirthDate == null)
            {
                return new CoachValidationResponse(false, "Enter birthdate");
            }
            if (TeamID == 0)
            {
                return new CoachValidationResponse(false, "Enter TeamID");
            }
            return new CoachValidationResponse();
        }

        public CoachValidationResponse DeleteCoach(int CoachID)
        {
            if (CoachID == 0)
            {
                return new CoachValidationResponse(false, "Select coach ID");
            }
            return new CoachValidationResponse();
        }
    }
}
