using BYR_WebApp.Models;
using Core.Domain;

namespace BYR_WebApp.Helpers.Mappers
{
    internal static class LoginMapper
    {
        //Map to Domain object
        internal static Login Map(this LoginModel loginModel)
        {
            return new Login(
                loginModel.Email,
                loginModel.Password,
                loginModel.IsEmployee
            );
        }
    }
}
