using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Helpers.Results
{
    public class LoginResult
    {
        public bool Success { get; private set; }

        public string ErrorMessage { get; private set; }

        public int ID { get; set; }//For returning the ID


        /// <summary>
        /// Succesfull login attempt
        /// </summary>
        public LoginResult(int id)
        {
            Success = true;
            ErrorMessage = string.Empty;
            ID = id;
        }

        /// <summary>
        /// Unsuccessfull login attempt
        /// </summary>
        /// <param name="errorMessage"></param>
        public LoginResult(string errorMessage, int id)
        {
            Success = false;
            ErrorMessage = errorMessage;
            ID = id;
        }
    }
}
