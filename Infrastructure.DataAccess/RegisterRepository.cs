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
        public void CheckDuplicateEmail(string email)
        {
            //MySqlConnection mysqlConnection = new MySqlConnection("Data Source=.;Initial Catalog=bookyourride;Persist Security Info=True;User ID=KoenV;Password=DBhost013!?");
            MySqlConnection mysqlConnection = new MySqlConnection("server=localhost.;User ID=KoenV; Password=DBhost013!?; database=bookyourride");
            mysqlConnection.Open();

            //Nieuwe SQL command uitvoeren naar de database
            MySqlCommand mysqlCommand = new MySqlCommand("Select customer.email from customer", mysqlConnection);
            MySqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();

            while (mysqlDataReader.Read())
            {
                if (mysqlDataReader.GetString("email") == email)
                {
                    throw new ArgumentException("This email allready has an account,continue to the Login page");
                }
            }
        }




        public bool TryRegister(RegisterDTO registerDTO)
        {
            MySqlConnection mysqlConnection = new MySqlConnection("server=localhost.;User ID=KoenV; Password=DBhost013!?; database=bookyourride");
            mysqlConnection.Open();


            MySqlCommand mysqlCommand = new MySqlCommand("INSERT INTO bookyourride.customer (email, firstName, lastName, password) VALUES (@email, @firstName, @lastName, @password);", mysqlConnection);
            mysqlCommand.Parameters.AddWithValue("@email", registerDTO.Email);
            mysqlCommand.Parameters.AddWithValue("@firstName", registerDTO.FirstName);
            mysqlCommand.Parameters.AddWithValue("@lastName", registerDTO.LastName);
            mysqlCommand.Parameters.AddWithValue("@password", registerDTO.Password);
            mysqlCommand.ExecuteNonQuery();


            mysqlConnection.Close();
            return true;
        }
    }
}
