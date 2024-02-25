using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_Mini_Project_Raynard
{
    public partial class PaymentOfLoanActivity : Form
    {
        Customer cusObj = new Customer();
        string username = CustomerLogin.SetValueForUsername;
        float balance;
        public PaymentOfLoanActivity()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            UserInterfaceOfCustomer uiObj = new UserInterfaceOfCustomer();
            uiObj.Show();
            this.Hide();
        }

        private void PaymentOfLoanActivity_Load(object sender, EventArgs e)
        {
            if (cusObj.getCustomerLoan(username) == "Yes")
            {
                balance = cusObj.getCustomerDueBalance(username);
                string strBalance = balance.ToString();
                loanAmountLabel.Text = "$" + strBalance;
            }
            else
            {
                MessageBox.Show("You got no loan!");
                btOk.Enabled = false;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (paymentTextBox.Text == "")
            {
                MessageBox.Show("Please input your Payment Amount!");
            }
            else
            {
                float payment = float.Parse(paymentTextBox.Text);
                if (payment > balance)
                {
                    MessageBox.Show("You are paying extra! Please input the correct amount");
                }
                else
                {
                    float totalPayment = balance - payment;
                    if (totalPayment == 0)
                    {
                        int updatePayment = cusObj.updateLoanAmount(username, totalPayment);
                        int updateInDebt = cusObj.updateLoanInDebt(username, "No");
                        float fltBal = cusObj.getCustomerDueBalance(username);//Get his due balance
                        string str = fltBal.ToString();
                        loanAmountLabel.Text = "$" + str;

                        MessageBox.Show("You have paid your loan finished!");
                        UserInterfaceOfCustomer uiObj = new UserInterfaceOfCustomer();
                        uiObj.Show();
                        this.Hide();
                    }
                    else
                    {
                        int updatePayment = cusObj.updateLoanAmount(username, totalPayment);
                        float i = cusObj.getCustomerDueBalance(username);//Get his due balance
                        string s = i.ToString();
                        loanAmountLabel.Text = "$" + s;
                        float f = cusObj.getCustomerDueBalance(username);
                        string strBalance = f.ToString();
                        loanAmountLabel.Text = "$" + strBalance;
                        MessageBox.Show("You have paid $"+ paymentTextBox.Text +"\n You left $" + strBalance +" to pay!");
                        UserInterfaceOfCustomer uiObj = new UserInterfaceOfCustomer();
                        uiObj.Show();
                        this.Hide();
                    }
                    
                }
            }
        }
    }
}
