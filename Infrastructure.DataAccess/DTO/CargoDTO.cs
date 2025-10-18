using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.DTO
{
    public class CargoDTO
    {
        // =0; to set non used properties to 0
        public int People { get; set; } = 0;
        public int Length { get; set; } = 0;
        public int Width { get; set; } = 0;
        public int Height { get; set; } = 0;
        public int Weight { get; set; } = 0;
    }
}
