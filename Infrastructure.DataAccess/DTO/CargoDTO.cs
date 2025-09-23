using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.DTO
{
    public class CargoDTO
    {
        public int People { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        //public CargoDTO(int people)
        //{
        //    People = people;
        //}
        //public CargoDTO(int length, int width, int height, int weight)
        //{
        //    Length = length;
        //    Width = width;
        //    Height = height;
        //    Weight = weight;
        //}
    }
}
