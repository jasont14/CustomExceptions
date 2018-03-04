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

            //set default activity type to deposit.
            myAccount.Activity = BankAccount.ActivityType.Deposit; 
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
            decimal value;
            try
            {
                txtErrorMessage.Text = "";
                if(!decimal.TryParse(txtDeposit.Text, out value) || value != decimal.Round(value,2))
                {
                    MessageBox.Show("Please enter valid " + myAccount.Activity.ToString() + " amount.", myAccount.Activity.ToString());
                }
                else
                {
                    txtAccountBalance.Text = myAccount.RecordCreditDebit(value).ToString();
                    txtDeposit.Text = "0.00"; //Set text box back to 0.00 to avoid duplicate deposit / withdraws.
                }
            }
            catch (NegativeDepositException ex)
            {
                txtErrorMessage.Text = ex.Message;               
            }
            catch (NegativeBalanceException ex)
            {
                txtErrorMessage.Text = ex.Message;  
            }
            catch (TooLargeException ex)
            {
                txtErrorMessage.Text = ex.Message;
            }
           
        }
        
        private void txtDeposit_Enter(object sender, EventArgs e) 
        {
            txtDeposit.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetAccountActivityType();  
        }
    }
}
