using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.DTO
{
    public class RideDTO
    {
        public int Price { get;  set; }
        public string Beginning { get;  set; } = string.Empty;
        public string End { get;  set; } = string.Empty;
        public int Distance { get;  set; }
        public DateOnly Date { get;  set; }
    }
}
