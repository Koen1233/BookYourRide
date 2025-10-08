using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Helpers.Mappers
{
    internal static class CustomerMapper
    {
        internal static CustomerDTO Map(this Customer customer)
        {
            return new CustomerDTO
            {
                Email = customer.Email,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Password = customer.Password
            };
        }
    }
}
