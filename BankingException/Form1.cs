/********************************************************
* Jason Thatcher                                        *
* Class - Form1.cs                                      *
*                                                       *
* Class derives from Form. Entry point into application *
* called from Main() Single form app                    *
*                                                       *
* February 2018                                         *
*********************************************************/

using System;
using System.Windows.Forms;

namespace BankingException
{
    public partial class Form1 : Form
    {
        BankAccount myAccount;

        public Form1()
        {
            InitializeComponent();
            InitializeBankAccount();
        }

        private void InitializeBankAccount()
        {
            myAccount = new BankAccount();
            myAccount.Activity = BankAccount.ActivityType.Deposit; //set default activity type to deposit.
        }

        //Evaluates ActivityType sets appropirate checked value;
        private void SetAccountActivityType()  
        {
            if (myAccount.Activity == BankAccount.ActivityType.Deposit) 
            {
                rdoDeposit.Checked = true;
                btnDeposit.Text = "Deposit";
            }       
            else if (myAccount.Activity == BankAccount.ActivityType.Withdraw)  
            {
                rdoWithdraw.Checked = true;
                btnDeposit.Text = "Withdraw";
            }
            
        }

        //responds to check changed event 
        private void rdoDeposit_CheckedChanged(object sender, EventArgs e)  
        {
            btnDeposit.Text = "Deposit";
            myAccount.Activity = BankAccount.ActivityType.Deposit;
        }

        //responds to check changed event
        private void rdoWithdraw_CheckedChanged(object sender, EventArgs e) 
        {
            btnDeposit.Text = "Withdraw";
            myAccount.Activity = BankAccount.ActivityType.Withdraw;
        }

        //responds to button click event
        private void btnDeposit_Click(object sender, EventArgs e)  
        {
            //validate entry can be parsed to decimal and value not neg or zero

            if (!decimal.TryParse(txtDeposit.Text, out decimal value) || value <= 0) 
            {
                MessageBox.Show("Please enter valid " + myAccount.Activity.ToString() + " amount.", myAccount.Activity.ToString());
            }
            else
            {
            //withdrawORdeposit and return Balance.
            txtAccountBalance.Text = myAccount.RecordCreditDebit(value).ToString(); 
            txtDeposit.Text = "0.00"; //Set text box back to 0.00 to avoid duplicate deposit / withdraws.
            }
        }

        //Reponsds to enter event and clears text box
        private void txtDeposit_Enter(object sender, EventArgs e) 
        {
            txtDeposit.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetAccountActivityType();  //once loaded set initial activity type.  
        }
    }
}
