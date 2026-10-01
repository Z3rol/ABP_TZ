using ABP_TZ.DTOs.Room;
using ABP_TZ.Models;

namespace ABP_TZ.Mappers
{
    public static class RoomMappers
    {
        public static Room ToRoomFromCreate(this CreateRoomRequestDto createRoomDto, List<Service> services)
        {
            return new Room
            {
                Name = createRoomDto.Name,
                Capacity = createRoomDto.Capacity,
                PricePerHour = createRoomDto.PricePerHour,
                Services = services
            };
        }
    }
}