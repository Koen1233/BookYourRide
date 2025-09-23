using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess
{
    public class CargoRepository
    {
        public List<CargoDTO> GetCargo()
        {
            List<CargoDTO> cargo = new List<CargoDTO>
            {
                new CargoDTO
                {
                    //People = 0,
                    Length = 50,
                    Width = 4,
                    Height = 2,
                    Weight = 10000
                },
                new CargoDTO
                {
                    People = 4,
                    //Length = 0,
                    //Width = 0,
                    //Height = 0,
                    //Weight = 0
                },
                new CargoDTO
                {
                    //People = 0,
                    Length = 30,
                    Width = 1,
                    Height = 2,
                    Weight = 5000
                }
            };
            return cargo;
        }

    }
}