using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Helpers
{
    internal static class PriceHelper
    {
        internal static double CalcPrice(this Ride ride)
        {
            //0,75 euro voor elke kilometer + 10 euro arbeidskosten

            return 0.75 * ride.Distance + 10;
        }
    }
}
