using Microsoft.EntityFrameworkCore;

namespace ParksAPI.Models
{
    public class ParksAPIContext : DbContext
    {
        public ParksAPIContext(DbContextOptions<ParksAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }
        public DbSet<Campground> Campgrounds { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Park>()
            .HasData(
              new Park { ParkId = 1, Name = "Crater Lake National Park", State = "Oregon", Type = "national", Website = "https://www.nps.gov/crla/index.htm" },
              new Park { ParkId = 2, Name = "Mount Rainier National Park", State = "Washington", Type = "national", Website = "https://www.nps.gov/mora/index.htm" },
              new Park { ParkId = 3, Name = "North Cascades National Park", State = "Washington", Type = "national", Website = "https://www.nps.gov/noca/index.htm" },
              new Park { ParkId = 4, Name = "Olymic National Park", State = "Washington", Type = "national", Website = "https://www.nps.gov/olym/index.htm" },
              new Park { ParkId = 5, Name = "Yellowstone National Park", State = "Wyoming", Type = "national", Website = "https://www.nps.gov/yell/index.htm" },
              new Park { ParkId = 6, Name = "Grand Teton National Park", State = "Wyoming", Type = "national", Website = "https://www.nps.gov/grte/index.htm" },
              new Park { ParkId = 7, Name = "Glacier National Park", State = "Montana", Type = "national", Website = "https://www.nps.gov/glac/index.htm" },
              new Park { ParkId = 8, Name = "Channel Islands National Park", State = "California", Type = "national", Website = "https://www.nps.gov/glac/index.htm" },
              new Park { ParkId = 9, Name = "Death Valley National Park", State = "California", Type = "national", Website = "https://www.nps.gov/deva/index.htm" },
              new Park { ParkId = 10, Name = "Joshua Tree National Park", State = "California", Type = "national", Website = "https://www.nps.gov/jotr/index.htm" },
              new Park { ParkId = 11, Name = "Lassen Volcanic National Park", State = "California", Type = "national", Website = "https://www.nps.gov/lavo/index.htm" },
              new Park { ParkId = 12, Name = "Pinnacles National Park", State = "California", Type = "national", Website = "https://www.nps.gov/pinn/index.htm" },
              new Park { ParkId = 13, Name = "Redwood National Park", State = "California", Type = "national", Website = "https://www.nps.gov/redw/index.htm" },
              new Park { ParkId = 14, Name = "Sequoia and King's Canyon National Park", State = "California", Type = "national", Website = "https://www.nps.gov/seki/index.htm" },
              new Park { ParkId = 15, Name = "Yosemite National Park", State = "California", Type = "national", Website = "https://www.nps.gov/yose/index.htm" },
              new Park { ParkId = 16, Name = "Great Basin National Park", State = "Nevada", Type = "national", Website = "https://www.nps.gov/grba/index.htm" },
              new Park { ParkId = 17, Name = "Arches National Park", State = "Utah", Type = "national", Website = "https://www.nps.gov/arch/index.htm" },
              new Park { ParkId = 18, Name = "Bryce Canyon National Park", State = "Utah", Type = "national", Website = "https://www.nps.gov/brca/index.htm" },
              new Park { ParkId = 19, Name = "Canyonlands National Park", State = "Utah", Type = "national", Website = "https://www.nps.gov/cany/index.htm" },
              new Park { ParkId = 20, Name = "Capiton Reef National Park", State = "Nevada", Type = "national", Website = "https://www.nps.gov/care/index.htm" },
              new Park { ParkId = 21, Name = "Zion National Park", State = "Nevada", Type = "national", Website = "https://www.nps.gov/zion/index.htm" },
              new Park { ParkId = 22, Name = "Grand Canton National Park", State = "Arizona", Type = "national", Website = "https://www.nps.gov/grca/index.htm" },
              new Park { ParkId = 23, Name = "Saguaro National Park", State = "Arizona", Type = "national", Website = "https://www.nps.gov/sagu/index.htm" },
              new Park { ParkId = 24, Name = "Black Canyon of the Gunnison National Park", State = "Colorado", Type = "national", Website = "https://www.nps.gov/blca/index.htm" },
              new Park { ParkId = 25, Name = "Great Sand Dunes National Park", State = "Colorado", Type = "national", Website = "https://www.nps.gov/grsa/index.htm" },
              new Park { ParkId = 26, Name = "Mesa Verde National Park", State = "Colorado", Type = "national", Website = "https://www.nps.gov/meve/index.htm" },
              new Park { ParkId = 27, Name = "Rocky Mountain National Park", State = "Colorado", Type = "national", Website = "https://www.nps.gov/romo/index.htm" },
              new Park { ParkId = 28, Name = "Carlsbad Caverns National Park", State = "New Mexico", Type = "national", Website = "https://www.nps.gov/cave/index.htm" },
              new Park { ParkId = 29, Name = "Theodore Roosevelt National Park", State = "North Dakota", Type = "national", Website = "https://www.nps.gov/thro/index.htm" },
              new Park { ParkId = 30, Name = "Badlands National Park", State = "South Dakota", Type = "national", Website = "https://www.nps.gov/badl/index.htm" },
              new Park { ParkId = 31, Name = "Wind Cave National Park", State = "South Dakota", Type = "national", Website = "https://www.nps.gov/wica/index.htm" },
              new Park { ParkId = 32, Name = "Valley of the Rogue River State Park", State = "Oregon", Type = "state", Website = "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=76" },
              new Park { ParkId = 33, Name = "Ecola State Park", State = "Oregon", Type = "state", Website = "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=136" },
              new Park { ParkId = 34, Name = "Smith Rock State Park", State = "Oregon", Type = "state", Website = "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=36" },
              new Park { ParkId = 35, Name = "Cape Disappointment River State Park", State = "Washington", Type = "state", Website = "https://www.parks.wa.gov/486/Cape-Disappointment" },
              new Park { ParkId = 36, Name = "Flaming Geyser State Park", State = "Washington", Type = "state", Website = "https://www.parks.wa.gov/504/Flaming-Geyser" },
              new Park { ParkId = 37, Name = "Sun Lakes Dry Falls State Park", State = "Washington", Type = "state", Website = "https://www.parks.wa.gov/298/Sun-Lakes-Dry-Falls" },
              new Park { ParkId = 38, Name = "Crystal Cove State Park", State = "California", Type = "state", Website = "http://www.parks.ca.gov/?page_id=644" },
              new Park { ParkId = 39, Name = "Julia Pfeiffer Burns State Park", State = "California", Type = "state", Website = "https://www.parks.ca.gov/?page_id=578" },
              new Park { ParkId = 40, Name = "Priest Lake State Park", State = "Idaho", Type = "state", Website = "https://parksandrecreation.idaho.gov/parks/priest-lake" },
              new Park { ParkId = 41, Name = "Harriman State Park", State = "Idaho", Type = "state", Website = "https://parksandrecreation.idaho.gov/parks/harriman" },
              new Park { ParkId = 42, Name = "Painted Rocks State Park", State = "Montana", Type = "state", Website = "http://stateparks.mt.gov/painted-rocks/" },
              new Park { ParkId = 43, Name = "Thompson Falls State Park", State = "Montana", Type = "state", Website = "http://stateparks.mt.gov/thompson-falls/" },
              new Park { ParkId = 44, Name = "Eleven Mile State Park", State = "Colorado", Type = "state", Website = "https://cpw.state.co.us/placestogo/parks/ElevenMile" },
              new Park { ParkId = 45, Name = "Eldorado Canyon State Park", State = "Colorado", Type = "state", Website = "https://cpw.state.co.us/placestogo/parks/EldoradoCanyon" },
              new Park { ParkId = 46, Name = "Arkansas Headwaters State Park", State = "Colorado", Type = "state", Website = "https://cpw.state.co.us/placestogo/parks/ArkansasHeadwatersRecreationArea" },
              new Park { ParkId = 47, Name = "Snow Canyon State Park", State = "Utah", Type = "state", Website = "https://stateparks.utah.gov/parks/snow-canyon/" },
              new Park { ParkId = 48, Name = "Kodachrome Basin State Park", State = "Utah", Type = "state", Website = "https://stateparks.utah.gov/parks/kodachrome-basin/" },
              new Park { ParkId = 49, Name = "Coral Pink Sand Dunes State Park", State = "Utah", Type = "state", Website = "https://stateparks.utah.gov/parks/coral-pink/" },
              new Park { ParkId = 50, Name = "Dead Horse Point State Park", State = "Utah", Type = "state", Website = "https://stateparks.utah.gov/parks/dead-horse/" }
            );

            builder.Entity<Campground>().HasData(
              new Campground { CampgroundId = 1, Name = "Cougar Rock Campground", ParkId = 2, State = "Washington" },
              new Campground { CampgroundId = 2, Name = "Mowich Lake", ParkId = 2, State = "Washington" },
              new Campground { CampgroundId = 3, Name = "La Wis Wis", ParkId = 2, State = "Washington" }
            );
        }
    }
}