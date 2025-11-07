using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Results
{
    public class BookResult
    {
        public bool Success { get; private set; }

        public string ErrorMessage { get; private set; }


        /// <summary>
        /// Succesfully booked a ride
        /// </summary>
        public BookResult()
        {
            Success = true;
            ErrorMessage = string.Empty;
        }

        /// <summary>
        /// Unsuccessfully booked a ride
        /// </summary>
        /// <param name="errorMessage"></param>
        public BookResult(string errorMessage)
        {
            Success = false;
            ErrorMessage = errorMessage;
        }
    }
}
