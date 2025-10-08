using Infrastructure.DataAccess;
using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Services
{
    public class LoginService()
    {
        //2 methodes: TryLoginCustomer, TryLoginEmployee met checkbox controleren in de UI?
        //In een mapper beslissen of CustomerDTO of EmployeeDTO adhv bool property in LoginModel?
        public bool TryLogin(Login login)
        {
            CustomerDTO customer = new CustomerDTO();
            customer.Email = login.Email;
            customer.Password = login.Password;

            CustomerRepository customerRepository = new CustomerRepository();
            if (customerRepository.TryLogin(customer) == true)
            {
                return true; //Het volledige customer object teruggeven of niet nodig?
            }
            return false;
        }

    }
}
