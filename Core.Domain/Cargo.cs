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

        //Inheritance voor type cargo toepassen of gewoon Cargo en PersonTransport klasse maken?

        public Cargo(int people, int length, int width, int height, int weight)
        {
            People = people;
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }
    }
}
