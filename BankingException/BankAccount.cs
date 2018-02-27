using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingException
{
    class BankAccount
    {
        private decimal balance;    //Maintains account balance
        public enum ActivityType {Deposit, Withdraw};
        ActivityType activity = ActivityType.Deposit;   //Sets default activity to deposit.
         
        //constructor for new account
        public BankAccount()
        {            
            Balance = 0.00m;     //set balance to 0.00 since this is an original account 
        }

        //constructor for existing account
        public BankAccount(decimal balance)
        {
            Balance = balance; 
        }
                
        //Property Balance to provide read/write to balance
        public decimal Balance { get => balance; set => balance = value; }
        //Property Activity to provide read/wrte to activity.
        public ActivityType Activity { get => activity; set => activity = value; }

        //withdraws amount from account
        public void Withdraw(decimal amount)
        {
            Balance = Balance - amount;
        }

        //deposits amount to account
        public void Deposit(decimal amount)
        {
            Balance = Balance + amount;
        }

        //records a debit or credit to account based upon Activity.
        public decimal RecordCreditDebit(decimal amount)
        {
            switch (activity)
            {
                case ActivityType.Deposit:
                    Deposit(amount);
                    break;
                case ActivityType.Withdraw:
                    Withdraw(amount);
                    break;
            }
            return Balance;
        }
    }
}
