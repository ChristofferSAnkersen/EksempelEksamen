﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities.Models
{
    public class AuctionItem
    {
        [Key]
        public int ItemNumber { get; set; }

        public string ItemDescription { get; set; }

        public int RatingPrice { get; set; }

        public int BidPrice { get; set; }

        public string BidCustomName { get; set; }

        public string BidCustomPhone { get; set; }

        public DateTime BidTimestamp { get; set; }

    }
}
