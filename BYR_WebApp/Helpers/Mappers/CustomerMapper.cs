using BYR_WebApp.Models;
using Core.Domain;

namespace BYR_WebApp.Helpers.Mappers
{
    internal static class CustomerMapper
    {
        //extenstion method van de les
        //Map methode is een uitbreiding van de CustomerModel
        //this verwijst daarom ook op CustomerModel
        public static Customer Map(this CustomerModel customerModel)
        {
            return new Customer(
                customerModel.Email,
                customerModel.FirstName,
                customerModel.LastName,
                customerModel.Password);
        }
    }
}
