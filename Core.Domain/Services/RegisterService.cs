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
    public class RegisterService
    {
        public RegisterResult CheckDuplicateEmail(string email)
        {
            RegisterRepository registerRepository = new RegisterRepository();
            string errorMessage = registerRepository.CheckDuplicateEmail(email);
            if (errorMessage == "")
            {
                return new RegisterResult();
            }
            else
            {
                return new RegisterResult(errorMessage);
            }
        }

        
        public RegisterResult TryRegister(Register register)
        {
            RegisterRepository registerRepository = new RegisterRepository();
            string errorMessage = registerRepository.TryRegister(register.Map());
            if (errorMessage == "")
            {
                return new RegisterResult();
            }
            else
            {
                return new RegisterResult(errorMessage); //tenzij de connectie fout gaat, kan er niks anders fout gaan..
            }
        }

    }
}
