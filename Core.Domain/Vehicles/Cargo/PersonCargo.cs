using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Vehicles.Cargo
{
    internal class PersonCargo : Cargo
    {
        public int People { get; private set; }

        public PersonCargo(int people)
        {
            People = people;

            CargoType = CargoType.PersonCargo;
        }
    }
}
