namespace ABP_TZ.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Capacity { get; set; }
        public decimal PricePerHour { get; set; }
        
        public List<Service> Services { get; set; } = new();
        public List<Booking> Bookings { get; set; } = new();
    }
}