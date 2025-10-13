using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Results
{
    public class LoginResult
    {
        public bool Success { get; private set; }

        public string ErrorMessage { get; private set; }


        /// <summary>
        /// Succesfull login attempt
        /// </summary>
        public LoginResult()
        {
            Success = true;
            ErrorMessage = string.Empty;
        }

        /// <summary>
        /// Unsuccessfull login attempt
        /// </summary>
        /// <param name="errorMessage"></param>
        public LoginResult(string errorMessage)
        {
            Success = false;
            ErrorMessage = errorMessage;
        }
    }
}
