using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banking_Mini_Project_Raynard
{
    public partial class UserInterfaceOfCustomer : Form
    {
        DepositAndWithdrawActivity depoObj;
        DataBase dbObj = new DataBase();
        SqlDataReader dR;
        Customer cusObj = new Customer();
        public UserInterfaceOfCustomer()
        {
            InitializeComponent();
        }

        private void UserInterfaceOfCustomer_Load(object sender, EventArgs e)
        {
            //label1.Text = CustomerLogin.SetValueForUsername;
            //string name = "";
            //string username = "";
            //string password = "";
            //string address = "";
            //string strAge = "";
            //string security_question = "";
            //string security_answer = "";
            //string sel = "Select * From CustomerTbl Where customer_name ='" 
            //    + CustomerLogin.SetValueForUsername + "'";

            //dR = dbObj.ExecuteReader(sel);
            //while (dR.Read()) 
            //{
            //    name = dR["customer_name"].ToString();
            //    username = dR["customer_username"].ToString();
            //    password = dR["customer_password"].ToString();
            //    strAge = dR["customer_age"].ToString();
            //    address = dR["customer_address"].ToString();
            //    security_question = dR["customer_security_question"].ToString();
            //    security_answer = dR["customer_security_answer"].ToString();
            //}
            //dR.Close();
            //Console.WriteLine(name);
            //Console.WriteLine(username);
            //Console.WriteLine(password);
            //Console.WriteLine(strAge);
            //Console.WriteLine(address);
            //Console.WriteLine(security_question);
            //Console.WriteLine(security_answer);

            //int age = int.Parse(strAge);
            //cusObj = new Customer(age, username, name, address, password, security_question, security_answer);
            string age = cusObj.getCustomerAge(CustomerLogin.SetValueForUsername);
            Console.WriteLine(age);

        }

        private void depositAndWithdrawButton_Click(object sender, EventArgs e)
        {
            depoObj = new DepositAndWithdrawActivity();
            depoObj.Show();
            this.Hide();
        }

        private void btProfile_Click(object sender, EventArgs e)
        {
            ProfileActivity prof = new ProfileActivity();
            prof.Show();
            this.Hide();
        }

        private void btLoan_Click(object sender, EventArgs e)
        {
            LoanActivity loanObj = new LoanActivity();
            loanObj.Show();
            this.Hide();
        }

        private void btPayment_Click(object sender, EventArgs e)
        {
            PaymentOfLoanActivity paymentObj = new PaymentOfLoanActivity();
            paymentObj.Show();
            this.Hide();
        }
    }
}
