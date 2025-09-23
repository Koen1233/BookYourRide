using Infrastructure.DataAccess.DTO;

namespace Infrastructure.DataAccess
{
    public class RideRepository
    {
        public List<RideDTO> GetRides(List<VehicleDTO> vehicles)
        {
            List<RideDTO> rides = new List<RideDTO>()
            {
                new RideDTO(vehicles[0])
                {
                    Price = 50,
                    Beginning = "Venlo",
                    End = "Tilburg",
                    Distance = 100,
                    Date = new DateOnly(2025, 09, 21)
                },
                new RideDTO(vehicles[1])
                {
                    Price = 100,
                    Beginning = "Amsterdam",
                    End = "Groningen",
                    Distance = 200,
                    Date = new DateOnly(2025, 10, 25)
                },
                new RideDTO(vehicles[2])
                {
                    Price = 600,
                    Beginning = "Maastricht",
                    End = "Friesland",
                    Distance = 300,
                    Date = new DateOnly(2025, 12, 09)
                } 
            };

            return rides;
        }
    }
}
