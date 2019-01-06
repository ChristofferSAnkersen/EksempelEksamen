using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities.Models
{
    public class Bid
    {
        public int ItemNumber { get; set; }

        public int Price { get; set; }

        public string CustomName { get; set; }

        public string Phone { get; set; }
    }
}
