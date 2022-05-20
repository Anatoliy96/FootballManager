using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Model.Response
{
    public abstract class Response
    {
        public bool OK { get; set; }
        public String ErroMessage { get; set; }
        
        public Response(bool OK, string ErrorMessage)
        {
            this.OK = OK;
            this.ErroMessage = ErroMessage;
        }
        public Response() : this(true, null)
        {

        }
    }
}
