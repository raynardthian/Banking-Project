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
    public partial class CustomerLogin : Form
    {
        Form1 frmObj;
        CustomerRegister cusObj;
        ForgotPasswordActivity forgotObj;
        Customer cus = new Customer();
        DataBase dbObj = new DataBase();
        SqlDataReader dR;
        UserInterfaceOfCustomer uiObj;
        public static string SetValueForUsername = "";
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void CustomerLogin_Load(object sender, EventArgs e)
        {
            usernameTextBox.Focus();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            frmObj = new Form1();
            frmObj.Show();
            this.Hide();
        }

        private void btCustomerRegister_Click(object sender, EventArgs e)
        {
            cusObj = new CustomerRegister();
            cusObj.Show();
            this.Hide();
        }

        private void btForgot_Click(object sender, EventArgs e)
        {
            forgotObj = new ForgotPasswordActivity();
            forgotObj.Show();
            this.Hide();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {

            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Please input your username");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Please input your password");
            }
            else
            {
                string getPassword = "";
                string getUsername = "";
                string comparePassword = "";
                string compareUsername = "";
                string password = passwordTextBox.Text;
                string username = usernameTextBox.Text;
                string getAge = "";
                string compareAge = "";
                string str = "Select customer_password,customer_username,customer_age From CustomerTbl"; //Where customer_name = " + "'" + username + "'";
                dR = dbObj.ExecuteReader(str);
                while (dR.Read()) 
                {
                    // if i didnt use this, it takes the password of the next row
                    getUsername = dR["customer_username"].ToString();
                    getPassword = dR["customer_password"].ToString();
                    getAge = dR["customer_age"].ToString();
                    if (username == getUsername) 
                    {
                        compareUsername = getUsername;
                        comparePassword = getPassword;
                        compareAge = getAge;
                    }
                }
                dR.Close();
               
                //string strage = cus.getCustomerAge(compareUsername);
                //Console.WriteLine("Second Age :" + strage);
                if (comparePassword == password )
                {
                    SetValueForUsername = username;
                    MessageBox.Show("Successful Login!");
                    
                    uiObj = new UserInterfaceOfCustomer();
                    uiObj.Show();
                    this.Hide();                   
                }
                else
                {
                    MessageBox.Show("Wrong password!");
                }               
            }
        }
    }
}
