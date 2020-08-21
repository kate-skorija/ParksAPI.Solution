namespace ParksAPI.Models
{
    public class Campground
    {
        public int CampgroundId { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public virtual Park Park { get; set; }
        public int ParkId { get; set; }

    }
}