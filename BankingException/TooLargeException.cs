/********************************************************
* Jason Thatcher                                        *
* Exception Class - TooLargeException.cs                *
*                                                       *
* Exception Class to handle debit/credit greater than   *
* 1000.00 error.  Transaction cannot be greater than    *
* 1000.00.                                              *                                            
*                                                       *
* February 2018                                         *
*********************************************************/

using System;

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
