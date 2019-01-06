﻿// <auto-generated />
using System;
using API.Entities.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(AuctionContext))]
    [Migration("20190106160750_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Entities.Models.AuctionItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BidCustomName");

                    b.Property<string>("BidCustomPhone");

                    b.Property<int>("BidPrice");

                    b.Property<DateTime>("BidTimestamp");

                    b.Property<string>("ItemDescription");

                    b.Property<int>("ItemNumber");

                    b.Property<int>("RatingPrice");

                    b.HasKey("Id");

                    b.ToTable("AuctionItems");
                });

            modelBuilder.Entity("API.Entities.Models.Bid", b =>
                {
                    b.Property<int>("ItemNumber")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomName");

                    b.Property<string>("Phone");

                    b.Property<int>("Price");

                    b.HasKey("ItemNumber");

                    b.ToTable("Bids");
                });
#pragma warning restore 612, 618
        }
    }
}
