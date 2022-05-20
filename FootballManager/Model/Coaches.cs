using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Model
{
    class Coaches
    {
        public int CoachID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Type { get; set; }

        public DateTime BirthDate { get; set; }

        public int TeamID { get; set; }
    }
}
