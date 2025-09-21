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
            List<CustomerDTO> customers = new List<CustomerDTO>()
            {
                new CustomerDTO()
                {
                    Email = "alice.customer@example.com",
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Password = "alicePass123"
                },
                new CustomerDTO()
                {
                    Email = "bob.customer@example.com",
                    FirstName = "Bob",
                    LastName = "Smith",
                    Password = "bobPass456"
                },
                new CustomerDTO()
                {
                    Email = "carol.customer@example.com",
                    FirstName = "Carol",
                    LastName = "Williams",
                    Password = "carolPass789"
                }
            };
            return customers;
        }
    }
}
