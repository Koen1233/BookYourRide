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
        public bool TryLogin(string email, string password)//string email, string password? of het in de customer/ employee?
        {
            CustomerDTO customer = new CustomerDTO();
            customer.Email = email; 
            customer.Password = password;

            CustomerRepository customerRepository = new CustomerRepository();
            if (customerRepository.TryLogin(customer) == true)
            {
                return true; //Het volledige customer object teruggeven of niet nodig?
            }
            return false;
        }

    }
}
