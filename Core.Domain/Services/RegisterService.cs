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
    public static class RegisterService
    {        
        public static RegisterResult TryRegister(Register register)
        {
            RegisterRepository registerRepository = new RegisterRepository();
            string errorMessage = registerRepository.TryRegister(register.Map());
            if (errorMessage == "")
            {
                return new RegisterResult();
            }
            else
            {
                return new RegisterResult(errorMessage); 
            }
        }
    }
}
