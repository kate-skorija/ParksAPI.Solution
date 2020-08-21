﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksAPI.Models;

namespace ParksAPI.Migrations
{
    [DbContext(typeof(ParksAPIContext))]
    [Migration("20200821225104_TryAgain")]
    partial class TryAgain
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParksAPI.Models.Campground", b =>
                {
                    b.Property<int>("CampgroundId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("ParkId");

                    b.Property<string>("State");

                    b.HasKey("CampgroundId");

                    b.HasIndex("ParkId");

                    b.ToTable("Campgrounds");

                    b.HasData(
                        new
                        {
                            CampgroundId = 1,
                            Name = "Cougar Rock Campground",
                            ParkId = 2,
                            State = "Washington"
                        },
                        new
                        {
                            CampgroundId = 2,
                            Name = "Mowich Lake",
                            ParkId = 2,
                            State = "Washington"
                        },
                        new
                        {
                            CampgroundId = 3,
                            Name = "La Wis Wis",
                            ParkId = 2,
                            State = "Washington"
                        });
                });

            modelBuilder.Entity("ParksAPI.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.Property<string>("Type");

                    b.Property<string>("Website");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Name = "Crater Lake National Park",
                            State = "Oregon",
                            Type = "national",
                            Website = "https://www.nps.gov/crla/index.htm"
                        },
                        new
                        {
                            ParkId = 2,
                            Name = "Mount Rainier National Park",
                            State = "Washington",
                            Type = "national",
                            Website = "https://www.nps.gov/mora/index.htm"
                        },
                        new
                        {
                            ParkId = 3,
                            Name = "North Cascades National Park",
                            State = "Washington",
                            Type = "national",
                            Website = "https://www.nps.gov/noca/index.htm"
                        },
                        new
                        {
                            ParkId = 4,
                            Name = "Olymic National Park",
                            State = "Washington",
                            Type = "national",
                            Website = "https://www.nps.gov/olym/index.htm"
                        },
                        new
                        {
                            ParkId = 5,
                            Name = "Yellowstone National Park",
                            State = "Wyoming",
                            Type = "national",
                            Website = "https://www.nps.gov/yell/index.htm"
                        },
                        new
                        {
                            ParkId = 6,
                            Name = "Grand Teton National Park",
                            State = "Wyoming",
                            Type = "national",
                            Website = "https://www.nps.gov/grte/index.htm"
                        },
                        new
                        {
                            ParkId = 7,
                            Name = "Glacier National Park",
                            State = "Montana",
                            Type = "national",
                            Website = "https://www.nps.gov/glac/index.htm"
                        },
                        new
                        {
                            ParkId = 8,
                            Name = "Channel Islands National Park",
                            State = "California",
                            Type = "national",
                            Website = "https://www.nps.gov/glac/index.htm"
                        },
                        new
                        {
                            ParkId = 9,
                            Name = "Death Valley National Park",
                            State = "California",
                            Type = "national",
                            Website = "https://www.nps.gov/deva/index.htm"
                        },
                        new
                        {
                            ParkId = 10,
                            Name = "Joshua Tree National Park",
                            State = "California",
                            Type = "national",
                            Website = "https://www.nps.gov/jotr/index.htm"
                        },
                        new
                        {
                            ParkId = 11,
                            Name = "Lassen Volcanic National Park",
                            State = "California",
                            Type = "national",
                            Website = "https://www.nps.gov/lavo/index.htm"
                        },
                        new
                        {
                            ParkId = 12,
                            Name = "Pinnacles National Park",
                            State = "California",
                            Type = "national",
                            Website = "https://www.nps.gov/pinn/index.htm"
                        },
                        new
                        {
                            ParkId = 13,
                            Name = "Redwood National Park",
                            State = "California",
                            Type = "national",
                            Website = "https://www.nps.gov/redw/index.htm"
                        },
                        new
                        {
                            ParkId = 14,
                            Name = "Sequoia and King's Canyon National Park",
                            State = "California",
                            Type = "national",
                            Website = "https://www.nps.gov/seki/index.htm"
                        },
                        new
                        {
                            ParkId = 15,
                            Name = "Yosemite National Park",
                            State = "California",
                            Type = "national",
                            Website = "https://www.nps.gov/yose/index.htm"
                        },
                        new
                        {
                            ParkId = 16,
                            Name = "Great Basin National Park",
                            State = "Nevada",
                            Type = "national",
                            Website = "https://www.nps.gov/grba/index.htm"
                        },
                        new
                        {
                            ParkId = 17,
                            Name = "Arches National Park",
                            State = "Utah",
                            Type = "national",
                            Website = "https://www.nps.gov/arch/index.htm"
                        },
                        new
                        {
                            ParkId = 18,
                            Name = "Bryce Canyon National Park",
                            State = "Utah",
                            Type = "national",
                            Website = "https://www.nps.gov/brca/index.htm"
                        },
                        new
                        {
                            ParkId = 19,
                            Name = "Canyonlands National Park",
                            State = "Utah",
                            Type = "national",
                            Website = "https://www.nps.gov/cany/index.htm"
                        },
                        new
                        {
                            ParkId = 20,
                            Name = "Capiton Reef National Park",
                            State = "Nevada",
                            Type = "national",
                            Website = "https://www.nps.gov/care/index.htm"
                        },
                        new
                        {
                            ParkId = 21,
                            Name = "Zion National Park",
                            State = "Nevada",
                            Type = "national",
                            Website = "https://www.nps.gov/zion/index.htm"
                        },
                        new
                        {
                            ParkId = 22,
                            Name = "Grand Canton National Park",
                            State = "Arizona",
                            Type = "national",
                            Website = "https://www.nps.gov/grca/index.htm"
                        },
                        new
                        {
                            ParkId = 23,
                            Name = "Saguaro National Park",
                            State = "Arizona",
                            Type = "national",
                            Website = "https://www.nps.gov/sagu/index.htm"
                        },
                        new
                        {
                            ParkId = 24,
                            Name = "Black Canyon of the Gunnison National Park",
                            State = "Colorado",
                            Type = "national",
                            Website = "https://www.nps.gov/blca/index.htm"
                        },
                        new
                        {
                            ParkId = 25,
                            Name = "Great Sand Dunes National Park",
                            State = "Colorado",
                            Type = "national",
                            Website = "https://www.nps.gov/grsa/index.htm"
                        },
                        new
                        {
                            ParkId = 26,
                            Name = "Mesa Verde National Park",
                            State = "Colorado",
                            Type = "national",
                            Website = "https://www.nps.gov/meve/index.htm"
                        },
                        new
                        {
                            ParkId = 27,
                            Name = "Rocky Mountain National Park",
                            State = "Colorado",
                            Type = "national",
                            Website = "https://www.nps.gov/romo/index.htm"
                        },
                        new
                        {
                            ParkId = 28,
                            Name = "Carlsbad Caverns National Park",
                            State = "New Mexico",
                            Type = "national",
                            Website = "https://www.nps.gov/cave/index.htm"
                        },
                        new
                        {
                            ParkId = 29,
                            Name = "Theodore Roosevelt National Park",
                            State = "North Dakota",
                            Type = "national",
                            Website = "https://www.nps.gov/thro/index.htm"
                        },
                        new
                        {
                            ParkId = 30,
                            Name = "Badlands National Park",
                            State = "South Dakota",
                            Type = "national",
                            Website = "https://www.nps.gov/badl/index.htm"
                        },
                        new
                        {
                            ParkId = 31,
                            Name = "Wind Cave National Park",
                            State = "South Dakota",
                            Type = "national",
                            Website = "https://www.nps.gov/wica/index.htm"
                        },
                        new
                        {
                            ParkId = 32,
                            Name = "Valley of the Rogue River State Park",
                            State = "Oregon",
                            Type = "state",
                            Website = "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=76"
                        },
                        new
                        {
                            ParkId = 33,
                            Name = "Ecola State Park",
                            State = "Oregon",
                            Type = "state",
                            Website = "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=136"
                        },
                        new
                        {
                            ParkId = 34,
                            Name = "Smith Rock State Park",
                            State = "Oregon",
                            Type = "state",
                            Website = "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=36"
                        },
                        new
                        {
                            ParkId = 35,
                            Name = "Cape Disappointment River State Park",
                            State = "Washington",
                            Type = "state",
                            Website = "https://www.parks.wa.gov/486/Cape-Disappointment"
                        },
                        new
                        {
                            ParkId = 36,
                            Name = "Flaming Geyser State Park",
                            State = "Washington",
                            Type = "state",
                            Website = "https://www.parks.wa.gov/504/Flaming-Geyser"
                        },
                        new
                        {
                            ParkId = 37,
                            Name = "Sun Lakes Dry Falls State Park",
                            State = "Washington",
                            Type = "state",
                            Website = "https://www.parks.wa.gov/298/Sun-Lakes-Dry-Falls"
                        },
                        new
                        {
                            ParkId = 38,
                            Name = "Crystal Cove State Park",
                            State = "California",
                            Type = "state",
                            Website = "http://www.parks.ca.gov/?page_id=644"
                        },
                        new
                        {
                            ParkId = 39,
                            Name = "Julia Pfeiffer Burns State Park",
                            State = "California",
                            Type = "state",
                            Website = "https://www.parks.ca.gov/?page_id=578"
                        },
                        new
                        {
                            ParkId = 40,
                            Name = "Priest Lake State Park",
                            State = "Idaho",
                            Type = "state",
                            Website = "https://parksandrecreation.idaho.gov/parks/priest-lake"
                        },
                        new
                        {
                            ParkId = 41,
                            Name = "Harriman State Park",
                            State = "Idaho",
                            Type = "state",
                            Website = "https://parksandrecreation.idaho.gov/parks/harriman"
                        },
                        new
                        {
                            ParkId = 42,
                            Name = "Painted Rocks State Park",
                            State = "Montana",
                            Type = "state",
                            Website = "http://stateparks.mt.gov/painted-rocks/"
                        },
                        new
                        {
                            ParkId = 43,
                            Name = "Thompson Falls State Park",
                            State = "Montana",
                            Type = "state",
                            Website = "http://stateparks.mt.gov/thompson-falls/"
                        },
                        new
                        {
                            ParkId = 44,
                            Name = "Eleven Mile State Park",
                            State = "Colorado",
                            Type = "state",
                            Website = "https://cpw.state.co.us/placestogo/parks/ElevenMile"
                        },
                        new
                        {
                            ParkId = 45,
                            Name = "Eldorado Canyon State Park",
                            State = "Colorado",
                            Type = "state",
                            Website = "https://cpw.state.co.us/placestogo/parks/EldoradoCanyon"
                        },
                        new
                        {
                            ParkId = 46,
                            Name = "Arkansas Headwaters State Park",
                            State = "Colorado",
                            Type = "state",
                            Website = "https://cpw.state.co.us/placestogo/parks/ArkansasHeadwatersRecreationArea"
                        },
                        new
                        {
                            ParkId = 47,
                            Name = "Snow Canyon State Park",
                            State = "Utah",
                            Type = "state",
                            Website = "https://stateparks.utah.gov/parks/snow-canyon/"
                        },
                        new
                        {
                            ParkId = 48,
                            Name = "Kodachrome Basin State Park",
                            State = "Utah",
                            Type = "state",
                            Website = "https://stateparks.utah.gov/parks/kodachrome-basin/"
                        },
                        new
                        {
                            ParkId = 49,
                            Name = "Coral Pink Sand Dunes State Park",
                            State = "Utah",
                            Type = "state",
                            Website = "https://stateparks.utah.gov/parks/coral-pink/"
                        },
                        new
                        {
                            ParkId = 50,
                            Name = "Dead Horse Point State Park",
                            State = "Utah",
                            Type = "state",
                            Website = "https://stateparks.utah.gov/parks/dead-horse/"
                        });
                });

            modelBuilder.Entity("ParksAPI.Models.Campground", b =>
                {
                    b.HasOne("ParksAPI.Models.Park", "Park")
                        .WithMany("Campgrounds")
                        .HasForeignKey("ParkId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
