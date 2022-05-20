using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.BusinessLayer
{
    class PlayerValidationResponse : Model.Response.Response
    {
        public PlayerValidationResponse(bool OK, string ErrorMessage) : base(OK, ErrorMessage)
        {

        }

        public PlayerValidationResponse() : this(true, null)
        {

        }
    }
}
