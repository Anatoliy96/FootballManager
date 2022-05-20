using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.BusinessLayer.Staff
{
    class StaffValidator
    {
        public StaffValidationResponse ValidateStaff(string Firstname, string LastName, string Position,
            int Age, DateTime Birthdate, int ClubID)
        {
            if (Firstname == string.Empty)
            {
                return new StaffValidationResponse(false, "Enter first name");
            }
            if (LastName == string.Empty)
            {
                return new StaffValidationResponse(false, "Enter last name");
            }
            if (Position == string.Empty)
            {
                return new StaffValidationResponse(false, "Enter position");
            }
            if (Age == 0)
            {
                return new StaffValidationResponse(false, "Enter age");
            }
            if (Birthdate == null)
            {
                return new StaffValidationResponse(false, "Enter birthdate");
            }
            if (ClubID == 0)
            {
                return new StaffValidationResponse(false, "Enter clubid");
            }
            return new StaffValidationResponse();
        }
    }
}
