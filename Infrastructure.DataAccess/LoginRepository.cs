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
        public string TryLogin(LoginDTO loginDTO)
        {
            if (loginDTO.IsEmployee == true)
            {
                MySqlConnection mysqlConnection = new MySqlConnection("server=localhost.;User ID=KoenV; Password=DBhost013!?; database=bookyourride");
                mysqlConnection.Open();

                MySqlCommand mysqlCommand = new MySqlCommand("Select employee.email, employee.password from employee", mysqlConnection);

                MySqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
                while (mysqlDataReader.Read())
                {
                    if (mysqlDataReader.GetString("email") == loginDTO.Email)
                    {
                        if(mysqlDataReader.GetString("password") != loginDTO.Password)
                        {
                            mysqlConnection.Close();
                            return "Password is incorrect";
                        }
                        mysqlConnection.Close();
                        return string.Empty;//Login successfull
                    }
                }
                mysqlConnection.Close();
                return "An employee account with this email does not exist";
            }
            else //Customer login
            {
                MySqlConnection mysqlConnection = new MySqlConnection("server=localhost.;User ID=KoenV; Password=DBhost013!?; database=bookyourride");
                mysqlConnection.Open();

                MySqlCommand mysqlCommand = new MySqlCommand("Select customer.email, customer.password from customer", mysqlConnection);

                MySqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
                while (mysqlDataReader.Read())
                {
                    if (mysqlDataReader.GetString("email") == loginDTO.Email)
                    {
                        if (mysqlDataReader.GetString("password") != loginDTO.Password)
                        {
                            mysqlConnection.Close();
                            return "Password is incorrect";
                        }
                        mysqlConnection.Close();
                        return string.Empty;//Login successfull
                    }
                }
                mysqlConnection.Close();
                return "There is no account with this email, try registering first!";
            }
        }
    }
}
