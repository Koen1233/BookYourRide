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
        public (string, int) TryLogin(LoginDTO loginDTO)
        {
            if (loginDTO.IsEmployee == true)
            {
                try
                {
                    MySqlConnection mysqlConnection = new MySqlConnection("server=localhost.;User ID=KoenV; Password=DBhost013!?; database=bookyourride");
                    mysqlConnection.Open();

                    MySqlCommand mysqlCommand = new MySqlCommand("Select employee.email, employee.password, employee.EmployeeID from employee", mysqlConnection);

                    MySqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
                    while (mysqlDataReader.Read())
                    {
                        if (mysqlDataReader.GetString("email") == loginDTO.Email)
                        {
                            if (mysqlDataReader.GetString("password") != loginDTO.Password)
                            {
                                mysqlConnection.Close();
                                return ("Password is incorrect", -1);
                            }
                            int id = mysqlDataReader.GetInt32("EmployeeID");
                            mysqlConnection.Close();
                            return ("", id);//Login successfull
                        }
                    }
                    mysqlConnection.Close();
                    return ("There is no employee account with this email", -1);
                }
                catch
                {
                    throw new Exception("Something went wrong when connecting to the database, try again later");
                }
            }
            else //Customer login
            {
                try
                {
                    MySqlConnection mysqlConnection = new MySqlConnection("server=localhost.;User ID=KoenV; Password=DBhost013!?; database=bookyourride");
                    mysqlConnection.Open();

                    MySqlCommand mysqlCommand = new MySqlCommand("Select customer.email, customer.password, customer.CustomerID from customer", mysqlConnection);

                    MySqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
                    while (mysqlDataReader.Read())
                    {
                        if (mysqlDataReader.GetString("email") == loginDTO.Email)
                        {
                            if (mysqlDataReader.GetString("password") != loginDTO.Password)
                            {
                                mysqlConnection.Close();
                                return ("Password is incorrect", -1);
                            }
                            int id = mysqlDataReader.GetInt32("CustomerID");
                            mysqlConnection.Close();
                            return ("", id); //Login successfull
                        }
                    }
                    mysqlConnection.Close();
                    return ("There is no account with this email, try registering first!", -1);
                }
                catch
                {
                    throw new Exception("Something went wrong when connecting to the database, try again later");
                }
            }
        }
    }
}
