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

        public ActivityType Activity { get => activity; set => activity = value; }
        
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                //Property is public. Throws exception with general message if value is less than 0.00 because it could be from withdraw, negative deposit, etc. 
                if(value.CompareTo(0.00m) == -1)
                {
                    throw new NegativeBalanceException("Error setting balance. The balance cannot be less than $0.00.");
                }
                else
                {
                    balance = value;
                }
                
            }
        }

        //withdraws amount from account
        public decimal Withdraw(decimal amount)
        {
            decimal result = Balance - amount;

            //Throws exception if value to set is less than $0.00.
            if (result.CompareTo(0.00m) == -1)
            {
                throw new NegativeBalanceException("Withdraw exceeds account balance.  Transaction cancelled.");                
            }

            return result;
        }

        //deposits amount to account
        public decimal Deposit(decimal amount)
        {
            if (amount.CompareTo(0.00m) == -1)
            {
                throw new NegativeDepositException("Deposit cannot be negative. Transaction cancelled.");
            }

            decimal result = Balance + amount;
            return result;
        }

        //records a debit or credit to account based upon Activity.
        public decimal RecordCreditDebit(decimal amount)
        {
            if (amount.CompareTo(1000.00m) == 1)
            {
                throw new TooLargeException("Amount cannot exceed $1,000.00 per transaction.  Transaction cancelled.");
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
