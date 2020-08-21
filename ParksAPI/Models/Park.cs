using System.Collections.Generic;

namespace ParksAPI.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Type { get; set; }
        public string Website { get; set; }

        public virtual ICollection<Campground> Campgrounds { get; set; }
        public Park()
        {
            this.Campgrounds = new HashSet<Campground>();
        }
    }
}