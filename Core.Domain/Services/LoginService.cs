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
    public class LoginService
    {
        public bool TryLogin(Login login) 
        {
            LoginRepository loginRepository = new LoginRepository();
            if (loginRepository.TryLogin(login.Map()) == true)
            {
                return true;
            }
            return false; //Login failed
        }

    }
}
