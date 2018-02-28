/********************************************************
* Jason Thatcher                                        *
* Class - BankAccount.cs                            *
*                                                       *
* Class to represent a Bank Account.  Very basic to     *
* work with custom execptions.                          *
*                                                       *
* February 2018                                         *
*********************************************************/

using System;

namespace BankingException
{
    class BankAccount
    {
        private decimal balance;    
        public enum ActivityType {Deposit, Withdraw};
        ActivityType activity = ActivityType.Deposit;   
         
        //constructor for new account
        public BankAccount()
        {
            //set balance to 0.00 since this is an original account 
            Balance = 0.00m;     
        }

        //constructor for existing account
        public BankAccount(decimal balance)
        {
            Balance = balance; 
        }
        
        public decimal Balance { get => balance; set => balance = value; }
        public ActivityType Activity { get => activity; set => activity = value; }

        //withdraws amount from account
        public decimal Withdraw(decimal amount)
        {
            decimal result = Balance - amount;

            if (result.CompareTo(0.00m) == -1)
            {
                NegativeBalanceException negativeBalanceException = new NegativeBalanceException("Withdraw exceeds account balance.  Transaction cancelled.");
                throw negativeBalanceException;
            }

            return result;
        }

        //deposits amount to account
        public decimal Deposit(decimal amount)
        {
            if (amount.CompareTo(0.00m) == -1)
            {
                NegativeDepositException negativeDepositException = new NegativeDepositException("Deposit cannot be negative. Transaction cancelled.");
                throw negativeDepositException;
            }

            decimal result = Balance + amount;
            return result;
        }

        //records a debit or credit to account based upon Activity.
        public decimal RecordCreditDebit(decimal amount)
        {
            if (amount.CompareTo(1000.00m) == 1)
            {
                TooLargeException tooLargeException = new TooLargeException("Amount cannot exceed $1,000.00 per transaction.  Transaction cancelled.");
                throw tooLargeException;
            }
            switch (activity)
            {
                case ActivityType.Deposit:
                    Balance = Deposit(amount);
                    break;
                case ActivityType.Withdraw:
                    Balance = Withdraw(amount);
                    break;
            }
            return Balance;
        }
    }
}
