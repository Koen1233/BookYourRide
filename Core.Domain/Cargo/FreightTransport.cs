using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Cargo
{
    internal class FreightTransport : Cargo
    {
        public int Length { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Weight { get; private set; }

        public FreightTransport(int length, int width, int height, int weight)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;

            CargoType = CargoType.FreightCargo;
        }
    }
}
