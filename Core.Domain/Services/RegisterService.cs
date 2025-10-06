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
                //if true, then there is allready this email adress, throw exeption?
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TryRegister(Customer newCustomer)
        {
            CustomerRepository customerRepository = new CustomerRepository();
            if (customerRepository.TryRegister(new CustomerDTO()
            {
                Email = newCustomer.Email,
                FirstName = newCustomer.FirstName,
                LastName = newCustomer.LastName,
                Password = newCustomer.Password }) == true) //Stil the IF statement
            { 
                return true; //If succesfull
            }
            else
            {
                return false;//Else i not succesfull (Still needed, because all the checks should have been done at this point
            }
        }
    }
}
