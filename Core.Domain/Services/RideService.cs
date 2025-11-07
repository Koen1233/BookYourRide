using Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.DataAccess.DTO;
using Core.Domain.Helpers.Mappers;

namespace Core.Domain.Services
{
    public static class RideService
    {
        //Via de ID van de ingelogde customer alle ritten ophalen
        
        public static List<Ride> GetRides(int id)
        {
            List<RideDTO> rideDTOs = CustomerRepository.GetRides(id);
            List<Ride> rides = rideDTOs.Map();

            return rides;
        }
    }
}
