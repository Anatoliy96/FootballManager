using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.BusinessLayer.Clubs
{
    public class ClubValidationResponse : Model.Response.Response
    {
        public ClubValidationResponse(bool OK, string ErrorMessage) : base(OK, ErrorMessage)
        {

        }

        public ClubValidationResponse() : this (true, null)
        {

        }
    }
}
