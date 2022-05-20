using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Model
{
    class Players
    {
        public int PlayersID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Position { get; set; }

        public int Age { get; set; }

        public int Weight { get; set; }

        public int Height { get; set; }

        public int TeamID { get; set; }
    }
}
