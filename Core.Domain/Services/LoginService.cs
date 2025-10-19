using Core.Domain.Helpers.Mappers;
using Core.Domain.Results;
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
        public static LoginResult TryLogin(Login login) 
        {
            LoginRepository loginRepository = new LoginRepository();
            (string errorMessage, int id) = loginRepository.TryLogin(login.Map());

            if (errorMessage == "")
            {
                return new LoginResult(id);
            }
            else
            {
                return new LoginResult(errorMessage, id);
            }
        }
    }
}
