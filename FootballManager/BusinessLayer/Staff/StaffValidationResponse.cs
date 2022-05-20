using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.BusinessLayer.Staff
{
    class StaffValidationResponse : Model.Response.Response
    {
            public StaffValidationResponse(bool OK, string ErrorMessage) : base(OK, ErrorMessage)
            {

            }

            public StaffValidationResponse() : this(true, null)
            {

            }
        }
    }

