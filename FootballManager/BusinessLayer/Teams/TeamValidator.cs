using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.BusinessLayer
{
    public class TeamValidator
    {
        public TeamValidationResponse ValidateTeam(string Name)
        {
            if (Name == string.Empty)
            {
                return new TeamValidationResponse(false, "Please enter team name");
            }
            return new TeamValidationResponse();
        }

        public TeamValidationResponse DeleteTeam(int TeamsID)
        {
            if (TeamsID == 0)
            {
                return new TeamValidationResponse(false, "select team id");
            }
            return new TeamValidationResponse();
        }
    }
}
