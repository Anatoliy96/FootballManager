using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.BusinessLayer.Coaches
{
   public class CoachValidationResponse : Model.Response.Response
    {
        public CoachValidationResponse(bool OK, string ErrorMessage) : base(OK, ErrorMessage)
        {

        }

        public CoachValidationResponse() : this(true, null)
        {

        }
    }
}
