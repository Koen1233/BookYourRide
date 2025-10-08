using Infrastructure.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Infrastructure.DataAccess
{
    public class LoginRepository
    {
        public bool TryLogin(LoginDTO loginDTO)
        {
            if (loginDTO.IsEmployee == true)
            {
                MySqlConnection mysqlConnection = new MySqlConnection("server=localhost.;User ID=KoenV; Password=DBhost013!?; database=bookyourride");
                mysqlConnection.Open();

                MySqlCommand mysqlCommand = new MySqlCommand("Select employee.email, employee.password from employee", mysqlConnection);

                MySqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
                while (mysqlDataReader.Read())
                {
                    if (mysqlDataReader.GetString("email") == loginDTO.Email && mysqlDataReader.GetString("password") == loginDTO.Password)
                    {
                        mysqlConnection.Close();
                        return true;
                    }
                }
                mysqlConnection.Close();
                return false; //login failed
            }
            else //Customer login
            {
                MySqlConnection mysqlConnection = new MySqlConnection("server=localhost.;User ID=KoenV; Password=DBhost013!?; database=bookyourride");
                mysqlConnection.Open();

                MySqlCommand mysqlCommand = new MySqlCommand("Select customer.email, customer.password from customer", mysqlConnection);

                MySqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
                while (mysqlDataReader.Read())
                {
                    if (mysqlDataReader.GetString("email") == loginDTO.Email &&
                        mysqlDataReader.GetString("password") == loginDTO.Password)
                    {
                        mysqlConnection.Close();
                        return true;//Login succesfull
                    }
                }
                mysqlConnection.Close();
                return false; //Login failed
            }
        }
    }
}
