using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Banking_Mini_Project_Raynard
{
    class Customer:DataBase
    {
        private int age;
        private string username;
        private string customerName;
        private string address;
        private string password;
        private string security_question;
        private string security_question_answer;
        SqlDataReader dR;
        DataBase dbObj = new DataBase();
        public Customer(int age, string username, string customerName, string address, string password, string security_question, string security_question_answer)
        {
            this.age = age;
            this.username = username;
            this.customerName = customerName;
            this.address = address;
            this.password = password;
            this.security_question = security_question;
            this.security_question_answer = security_question_answer;
        }
        public Customer() : base() 
        {
            
        }
        public string Question 
        {
            get { return security_question; }
            set { security_question = value; }
        }
        public string Answer
        {
            get { return security_question_answer; }
            set { security_question_answer = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Name
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public int updateLoanInDebt(string strUsername, string debt)
        {
            string sel = "UPDATE AccountTbl Set customer_loan = " + "'" + debt + "'" + " Where customer_name = " + "'" + strUsername + "'";
            int i = dbObj.ExecuteNonQuery(sel);
            return i;
        }
        public int updateLoanAmount(string strUsername, float amount)
        {
            string sel = "UPDATE AccountTbl Set customer_due_loan_amount = " + amount + " Where customer_name = " + "'" + strUsername + "'";
            int i = dbObj.ExecuteNonQuery(sel);
            return i;
        }
        public int updateLoanDateYear(string strUsername, string year)
        {
            string sel = "UPDATE AccountTbl Set customer_year = " + "'" + year + "'" + " Where customer_name = " + "'" + strUsername + "'";
            int i = dbObj.ExecuteNonQuery(sel);
            return i;
        }
        public int updateLoanDateMonth (string strUsername, string month)
        {
            string sel = "UPDATE AccountTbl Set customer_month = " + "'" + month + "'" + " Where customer_name = " + "'" + strUsername + "'";
            int i = dbObj.ExecuteNonQuery(sel);
            return i;
        }
        
        public int updateLoanDate(string strUsername, string date)
        {
            string sel = "UPDATE AccountTbl Set customer_loan_date = " + "'" + date + "'" + " Where customer_name = " + "'" + strUsername + "'";
            int i = dbObj.ExecuteNonQuery(sel);
            return i;
        }
        public int updateLoanDateDay(string strUsername, string day)
        {
            string sel = "UPDATE AccountTbl Set customer_day = " + "'" + day + "'" + " Where customer_name = " + "'" + strUsername + "'";
            int i = dbObj.ExecuteNonQuery(sel);
            return i;
        }
        public int updateCustomerPassword(string strUsername,string strPassword) 
        {
            string sel = "UPDATE CustomerTbl Set customer_password = " + "'" + strPassword + "'" + " Where customer_username = " + "'" + strUsername + "'";
            int i = dbObj.ExecuteNonQuery(sel);
            return i;
        }
        public int updateCustomerAddress(string strUsername,string strAddress)
        {
            string sel = "UPDATE CustomerTbl Set customer_address = " + "'" + strAddress + "'" + " Where customer_username = " + "'" + strUsername + "'";
            int i = dbObj.ExecuteNonQuery(sel);
            return i;
        }
        public int updateCustomerName(string strUsername, string strName) 
        {
            string sel = "UPDATE CustomerTbl Set customer_name = " + "'" + strName + "'" + " Where customer_username = " + "'" + strUsername + "'";
            int i = dbObj.ExecuteNonQuery(sel);
            return i;
        }
        public int updateCustomerAge(string strUsername,int intAge) 
        {
            string sel = "UPDATE CustomerTbl Set customer_age = " + intAge + " Where customer_username = " + "'" + strUsername + "'";
            int i = dbObj.ExecuteNonQuery(sel);
            return i;
        }
        public int updateCustomerAnswer(string strUsername, string strAnswer)
        {
            string sel = "UPDATE CustomerTbl Set customer_security_answer = " + "'" + strAnswer + "'" + " Where customer_username = " + "'" + strUsername + "'";
            int i = dbObj.ExecuteNonQuery(sel);
            return i;
        }
        public string getCustomerAddress(string username) 
        {
            string str = "SELECT customer_address FROM CustomerTbl WHERE customer_username ='" + username + "'";
            string addr = "";
            dR = dbObj.ExecuteReader(str);
            if (dR.Read()) 
            {
                addr = dR["customer_address"].ToString();
            }
            dR.Close();
            return addr;
        }

        public float getBalance(string username)
        {
            string str = "Select customer_balance,customer_name From AccountTbl";
            float balance = 0.0f;
            dR = dbObj.ExecuteReader(str);
            while (dR.Read())
            {
                string getBalance = dR["customer_balance"].ToString();
                string getName = dR["customer_name"].ToString();
                if (username == getName)
                {
                    // This is so that it gets the balance out of the database comparing with the user logged in
                    balance = float.Parse(getBalance);
                }
            }
            dR.Close();
            return balance;
        }
        
        public string getCustomerAge(string username) 
        {
            string sel = "SELECT customer_age FROM CustomerTbl WHERE customer_username ='"
               + username + "'";
            string strAge = "";
            dR = dbObj.ExecuteReader(sel);
            while (dR.Read())
            {
                strAge = dR["customer_age"].ToString();
            }
            dR.Close();
            return strAge;
        }
        public string getCustomerName(string username) 
        {
            string sel = "SELECT customer_name FROM CustomerTbl WHERE customer_username ='"
               + username + "'";
            string strName = "";
            dR = dbObj.ExecuteReader(sel);
            while (dR.Read())
            {
                strName = dR["customer_name"].ToString();
            }
            dR.Close();
            return strName;
        }
        public string getCustomerPassword(string username) 
        {
            string sel = "SELECT customer_password FROM CustomerTbl WHERE customer_username ='"
               + username + "'";
            string strPassword = "";
            dR = dbObj.ExecuteReader(sel);
            while (dR.Read())
            {
                strPassword = dR["customer_password"].ToString();
            }
            dR.Close();
            return strPassword;
        }
        public string getCustomerQuestion(string username) 
        {
            string sel = "SELECT customer_security_question FROM CustomerTbl WHERE customer_username ='"
                   + username + "'";
            string strQuestion = "";
            dR = dbObj.ExecuteReader(sel);
            while (dR.Read())
            {
                strQuestion = dR["customer_security_question"].ToString();
            }
            dR.Close();
            return strQuestion;
        }

        public string getCustomerQuestionAnswer(string username) 
        {
            string sel = "SELECT customer_security_answer FROM CustomerTbl WHERE customer_username ='"
                  + username + "'";
            string strAnswer = "";
            dR = dbObj.ExecuteReader(sel);
            while (dR.Read())
            {
                strAnswer = dR["customer_security_answer"].ToString();
            }
            dR.Close();
            return strAnswer;
        }
        public string getCustomerLoan(string username)
        {
            string sel = "SELECT customer_loan FROM AccountTbl WHERE customer_name ='"
                  + username + "'";
            string strAnswer = "";
            dR = dbObj.ExecuteReader(sel);
            while (dR.Read())
            {
                strAnswer = dR["customer_loan"].ToString();
            }
            dR.Close();
            return strAnswer;
        }
        public float getCustomerDueBalance(string username)
        {
            string sel = "SELECT customer_due_loan_amount FROM AccountTbl WHERE customer_name ='"
                  + username + "'";
            float balance = 0.0f;
            dR = dbObj.ExecuteReader(sel);
            while (dR.Read())
            {
                balance = float.Parse(dR["customer_due_loan_amount"].ToString());
            }
            dR.Close();
            return balance;
        }
       

    }
}
