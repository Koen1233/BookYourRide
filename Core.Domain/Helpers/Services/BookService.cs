using Core.Domain.Helpers.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Helpers.Services
{
    public class BookService
    {
        public BookResult BookRide()
        {
            return new BookResult();
            //return new BookResult("Message");
            
        }
    }
}
