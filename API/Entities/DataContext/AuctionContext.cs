using API.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities.DataContext
{
    public class AuctionContext : DbContext
    {
        public AuctionContext(DbContextOptions<AuctionContext> options) : base(options)
        {

        }

        public DbSet<AuctionItem> AuctionItems { get; set; }

        public DbSet<Bid> Bids { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
