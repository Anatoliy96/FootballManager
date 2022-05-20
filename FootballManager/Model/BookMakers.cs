using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Model
{
    class BookMakers
    {
        public int BookMakerID { get; set; }
        public string Name { get; set; }

        public decimal Coefficient { get; set; }

        public int TeamID { get; set; }
    }
}
