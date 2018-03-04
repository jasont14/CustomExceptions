/********************************************************
* Jason Thatcher                                        *
* Exception Class - NegativeBalanceException.cs         *
*                                                       *
* Exception Class to handle negative balance application*
* error.  Account cannot be less than zero.             *
*                                                       *
* February 2018                                         *
*********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingException
{
    public class NegativeBalanceException : Exception
    {
        public NegativeBalanceException() : base()
        {

        }

        public NegativeBalanceException(string message) : base(message)
        {

        }

        public NegativeBalanceException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
