using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.BusinessLayer
{
    public class TeamValidationResponse : Model.Response.Response
    {
        public TeamValidationResponse(bool OK, string ErrorMessage) : base(OK, ErrorMessage)
        {

        }

        public TeamValidationResponse() : this(true, null)
        {

        }
    }
}
