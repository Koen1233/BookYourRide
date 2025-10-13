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
        public void CheckDuplicateEmail(string email)
        {
            RegisterRepository registerRepository = new RegisterRepository();
            registerRepository.CheckDuplicateEmail(email);
        }

        public void TryRegister(Register register)
        {
            RegisterRepository registerRepository = new RegisterRepository();
            registerRepository.TryRegister(register.Map());
        }
    }
}
