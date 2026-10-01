using System.ComponentModel.DataAnnotations;

namespace ABP_TZ.DTOs.Room
{
    public class CreateRoomRequestDto
    {
        [Required]
        [Length(2, 100, ErrorMessage = "Name must be between 2 and 100 characters")]
        public string Name { get; set; } = "";
        [Required]
        [Range(1, 2000, ErrorMessage = "Capacity must be in range from 1 to 2000")]
        public int Capacity { get; set; }
        [Required]
        [Range(0.01, 100000.00, ErrorMessage = "Price per hour must be in range from 0.01 to 100000.00")]
        public decimal PricePerHour { get; set; }

        public List<int> ServiceIds { get; set; } = new();
    }
}