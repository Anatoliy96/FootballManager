using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.DataAccess
{
    public class DataAccessResponse : Model.Response.Response
    {
        public DataAccessResponse(bool OK, string ErrorMessage) : base (OK, ErrorMessage)
        {
            
        }
    }
}
