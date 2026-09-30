namespace ABP_TZ.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        
        public List<Room> Rooms { get; set; } = new();
    }
}