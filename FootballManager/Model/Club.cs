using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Model
{
      public class Club
    {
        public int ClubsID { get; set; }
        public string Name { get; set; }
        public string Owner{ get; set; }
        public DateTime Founded { get; set; }
    }
}
