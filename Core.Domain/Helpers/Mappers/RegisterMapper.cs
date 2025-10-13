using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Helpers.Mappers
{
    internal static class RegisterMapper
    {
        internal static RegisterDTO Map(this Register register)
        {
            return new RegisterDTO
            {
                Email = register.Email,
                FirstName = register.FirstName,
                LastName = register.LastName,
                Password = register.Password
            };
        }
    }
}
