using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingException
{    
    public class TooLargeException : Exception
    {
        public TooLargeException()
        {

        }

        public TooLargeException(string message) : base(message)
        {

        }

        public TooLargeException(string message, Exception inner) : base(message, inner)
        {

        }
        
    }
}
