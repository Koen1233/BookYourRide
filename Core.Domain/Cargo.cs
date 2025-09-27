using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Cargo
    {
        public int People { get; private set; }
        public int Length { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Weight { get; private set; }

        //Or PersonTransport
        public Cargo(int people)
        {
            People = people;
        }

        //Or CargoTransport
        public Cargo(int length, int width, int height, int weight)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }
    }
}
