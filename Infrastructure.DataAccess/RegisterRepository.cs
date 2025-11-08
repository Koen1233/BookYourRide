using Infrastructure.DataAccess.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess
{
    public class RegisterRepository
    {
        public string TryRegister(RegisterDTO registerDTO)
        {
            try
            {
                MySqlConnection mysqlConnection = new MySqlConnection("server=localhost.;User ID=KoenV; Password=DBhost013!?; database=bookyourride");
                mysqlConnection.Open();

                MySqlCommand emailCommand = new MySqlCommand("Select customer.email from customer", mysqlConnection);
                MySqlDataReader mysqlDataReader = emailCommand.ExecuteReader();

                while (mysqlDataReader.Read())
                {
                    if (mysqlDataReader.GetString("email") == registerDTO.Email)
                    {
                        mysqlConnection.Close();
                        return "This email already has an account, continue to the Login page";
                    }
                }
                mysqlConnection.Close();
                mysqlConnection.Open();

                MySqlCommand insertCommand = new MySqlCommand("INSERT INTO bookyourride.customer (email, firstName, lastName, password) VALUES (@email, @firstName, @lastName, @password);", mysqlConnection);
                insertCommand.Parameters.AddWithValue("@email", registerDTO.Email);
                insertCommand.Parameters.AddWithValue("@firstName", registerDTO.FirstName);
                insertCommand.Parameters.AddWithValue("@lastName", registerDTO.LastName);
                insertCommand.Parameters.AddWithValue("@password", registerDTO.Password);
                insertCommand.ExecuteNonQuery();

                mysqlConnection.Close();
                return string.Empty;
            }
            catch
            {
                throw new Exception("Something went wrong when connecting to the database, try again later");
            }
        }
    }
}
