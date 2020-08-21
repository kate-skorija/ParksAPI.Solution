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
              new Park { ParkId = 22, Name = "Great Basin National Park", State = "Nevada", Type = "national", Website = "https://www.nps.gov/grba/index.htm" },
              new Park { ParkId = 23, Name = "Great Basin National Park", State = "Nevada", Type = "national", Website = "https://www.nps.gov/grba/index.htm" }
            );
        }
    }
}