using Infrastructure.DataAccess;
using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Services
{
    public class RegisterService
    {
        public bool CheckDuplicateEmail(string email)
        {
            CustomerDTO customer = new CustomerDTO();
            customer.Email = email;
            CustomerRepository customerRepository = new CustomerRepository();
            if (customerRepository.CheckDuplicateEmail(customer) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TryRegister(string email, string firstName, string lastName, string password)
        {
            CustomerDTO newCustomer = new CustomerDTO();
            newCustomer.Email = email;
            newCustomer.FirstName = firstName;
            newCustomer.LastName = lastName;
            newCustomer.Password = password;


            CustomerRepository customerRepository = new CustomerRepository();
            if (customerRepository.TryRegister(newCustomer) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
