/********************************************************
* Jason Thatcher                                        *
* Exception Class - NegativeDepositException.cs         *
*                                                       *
* Exception Class to handle negative deposit application*
* error.  Deposit cannot be less than zero.             *
*                                                       *
* February 2018                                         *
*********************************************************/

using System;

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
