using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception
    {
        public FraudException()
            : base() { }// Inherits from the base Exception class
        public FraudException(string message)
            : base(message) { } // Calls the base constructor with a message


    }
}
