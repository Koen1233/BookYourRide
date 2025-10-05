using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess
{
    public class CustomerRepository
    {
        public List<CustomerDTO> GetCustomers()
        {
            List<CustomerDTO> customers = new List<CustomerDTO>();

            return customers;
        }
    }
}
