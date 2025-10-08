using Core.Domain.Helpers.Mappers;
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
            CustomerRepository customerRepository = new CustomerRepository();
            if (customerRepository.CheckDuplicateEmail(email) == true)
            {
                return true;//Email allready exists
            }
            else
            {
                return false;//Email does not exist
            }
        }

        public bool TryRegister(Customer newCustomer)
        {
            CustomerRepository customerRepository = new CustomerRepository();
            if (customerRepository.TryRegister(newCustomer.Map()) == true)
            {
                return true; //If succesfull
            }
            else
            {
                return false;//Else if not succesfull
            }
        }
    }
}
