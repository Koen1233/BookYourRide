using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.DTO.Cargo
{
    public class FreightCargoDTO : CargoDTO
    {
        public int Length { get; set; }
        public int Width { get; set; } 
        public int Height { get; set; } 
        public int Weight { get; set; } 
    }
}
