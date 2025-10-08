using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.DataAccess.DTO;

namespace Core.Domain.Helpers.Mappers
{
    internal static class LoginMapper
    {
        internal static LoginDTO Map(this Login login)
        {
            return new LoginDTO
            {
                Email = login.Email,
                Password = login.Password
            };
        }
    }
}
