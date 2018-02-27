using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingException
{
    public class NegativeDepositException : Exception
    {
        public NegativeDepositException()
        {

        }

        public NegativeDepositException(string message) : base(message)
        {

        }

        public NegativeDepositException(string message, Exception inner) : base(message, inner)
        {

        }
       
    }
}
