using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Model
{
    class Stadiums
    {
        public int StadiumID { get; set; }
        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Seats { get; set; }

        public int ClubID { get; set; }
    }
}
