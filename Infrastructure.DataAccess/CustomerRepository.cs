using Infrastructure.DataAccess.DTO;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess
{
    public class CustomerRepository
    {
        //nog nodig?
        public List<CustomerDTO> GetCustomers()
        {
            List<CustomerDTO> customers = new List<CustomerDTO>();

            return customers;
        }


        //When registering a new customer, check if the email already exists in the database
        //(to implement but method is made)
        public bool CheckDuplicateEmail(CustomerDTO customer)
        {
            //MySqlConnection mysqlConnection = new MySqlConnection("Data Source=.;Initial Catalog=bookyourride;Persist Security Info=True;User ID=KoenV;Password=DBhost013!?");
            MySqlConnection mysqlConnection = new MySqlConnection("server=localhost.;User ID=KoenV; Password=DBhost013!?; database=bookyourride");
            mysqlConnection.Open();

            //Nieuwe SQL command uitvoeren naar de database
            MySqlCommand mysqlCommand = new MySqlCommand(
                "Select customer.email " +
                "from customer"
                , mysqlConnection);
            MySqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
            while (mysqlDataReader.Read())
            {
                if(mysqlDataReader.GetString("email") == customer.Email)
                {
                    return true;
                }
            }
            return false;
        }

        public bool TryRegister(CustomerDTO customer)
        {
            MySqlConnection mysqlConnection = new MySqlConnection("server=localhost.;User ID=KoenV; Password=DBhost013!?; database=bookyourride");
            mysqlConnection.Open();


            MySqlCommand mysqlCommand = new MySqlCommand("INSERT INTO bookyourride.customer (email, firstName, lastName, password) VALUES (@email, @firstName, @lastName, @password);", mysqlConnection);
            mysqlCommand.Parameters.AddWithValue("@email", customer.Email);
            mysqlCommand.Parameters.AddWithValue("@firstName", customer.FirstName);
            mysqlCommand.Parameters.AddWithValue("@lastName", customer.LastName);
            mysqlCommand.Parameters.AddWithValue("@password", customer.Password);
            mysqlCommand.ExecuteNonQuery();
                

            mysqlConnection.Close();
            return true;
        }
        

        public bool TryLogin(CustomerDTO customer)
        {
            //MySqlConnection mysqlConnection = new MySqlConnection("Data Source=.;Initial Catalog=bookyourride;Persist Security Info=True;User ID=KoenV;Password=DBhost013!?");
            MySqlConnection mysqlConnection = new MySqlConnection("server=localhost.;User ID=KoenV; Password=DBhost013!?; database=bookyourride");
            mysqlConnection.Open();

            //Nieuwe SQL command uitvoeren naar de database
            MySqlCommand mysqlCommand = new MySqlCommand(
                "Select customer.email, customer.password  " +
                "from customer"
                , mysqlConnection);
            MySqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
            while (mysqlDataReader.Read())
            {
                if (mysqlDataReader.GetString("email") == customer.Email && 
                    mysqlDataReader.GetString("password") == customer.Password)
                {
                    mysqlConnection.Close();
                    return true;
                }
            }
            mysqlConnection.Close();
            return false;
        }

        
    }
}
