using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public abstract class Cargo
    {
       //Parent klasse wel nodig? 
       public CargoType CargoType { get; protected set; }
    }
}
