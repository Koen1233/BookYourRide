using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Results
{
    public class RegisterResult
    {
        public bool Success { get; private set; }

        public string ErrorMessage { get; private set; }


        /// <summary>
        /// Succesfull registration
        /// </summary>
        public RegisterResult()
        {
            Success = true;
            ErrorMessage = string.Empty;
        }

        /// <summary>
        /// Unsuccessfull registration
        /// </summary>
        /// <param name="errorMessage"></param>
        public RegisterResult(string errorMessage)
        {
            Success = false;
            ErrorMessage = errorMessage;
        }
    }
}
