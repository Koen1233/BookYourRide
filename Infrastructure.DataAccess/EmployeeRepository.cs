using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess
{
    public class EmployeeRepository
    {
        public List<EmployeeDTO> GetEmployees()
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>()
            {
                new EmployeeDTO()
                {
                    Email = "Koenverhalle@gmail.com",
                    FirstName = "Koen",
                    LastName = "Verhalle",
                    Password = "Ridetest"
                },
                new EmployeeDTO()
                {
                    Email = "JandeMan@gmail.com",
                    FirstName = "Jan",
                    LastName = "Man",
                    Password = "1234"
                },
                new EmployeeDTO()
                {
                    Email = "PietvdVelden@gmail.com",
                    FirstName = "Piet",
                    LastName = "van de Velden",
                    Password = "54321"
                }
            };


            /// There is no constructor so initializing a new object and giving paramaters does not work
            /// EmployeeDTO employee = new EmployeeDTO(
            /// employee.Email = "Koenverhalle@gmail.com",
            /// employee.FirstName = "Koen",
            /// employee.LastName = "Verhalle",
            /// employee.Password = "Ridetest"
            /// employees.Add(employee);
           
            return employees;
        }
    }
}
