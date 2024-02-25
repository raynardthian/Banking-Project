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
using System.Collections;

namespace Banking_Mini_Project_Raynard
{
    public partial class CustomerRegister : Form
    {
        Form1 frmObj;
        DataBase dbObj = new DataBase();
        SqlDataReader dR;
        CustomerLogin cusObj;
        
        public CustomerRegister()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            frmObj = new Form1();
            frmObj.Show();
            this.Hide(); 
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            numAgeUpDown.Increment = 0; // This is so that when username is taken, it does not auto increase the numAgeUpDown
            
            string strAge = numAgeUpDown.Value.ToString();
            int age = int.Parse(strAge);
            //int age = numAgeUpDown.Value.ToString();
            
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please input your name");
            }
            else if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Please input your username");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Please input your password");
            }
            else if (addressTextBox.Text == "")
            {
                MessageBox.Show("Please input your address");
            }
            else if (questionComboBox.Text == "")
            {
                MessageBox.Show("Please choose a question");
            }
            else if (answerTextBox.Text == "")
            {
                MessageBox.Show("Please input your security question answer");
            }
            else
            {
                string username = usernameTextBox.Text;
                string name = nameTextBox.Text;

                string address = addressTextBox.Text;
                string password = passwordTextBox.Text;
                string question = questionComboBox.Text;
                string answer = answerTextBox.Text;
                string compareUsername = "";
                string str = "Select customer_username From CustomerTbl";
                string nameFromDataBase = "";
                dR = dbObj.ExecuteReader(str);
                while (dR.Read())
                {
                    nameFromDataBase = dR["customer_username"].ToString();
                    if (username == nameFromDataBase)
                    {
                        compareUsername = nameFromDataBase;                      
                    }
                }
                dR.Close();
                if (compareUsername == username) 
                {
                    MessageBox.Show("Username Taken! Try another username");                    
                }
                else
                {
                    float cost = 0.0f;
                    // This is to add one customer details into the CustomerTbl
                    string selStr = "Insert Into CustomerTbl(customer_username,customer_name,customer_age,customer_address,customer_password,customer_security_question,customer_security_answer)"
                        + "Values('" + usernameTextBox.Text + "'" + "," + "'" + nameTextBox.Text + "'" + "," + "'" + age + "'" + "," + "'" + addressTextBox.Text + "'" + ","
                        + "'" + passwordTextBox.Text + "'" + "," + "'" + questionComboBox.Text + "'" + "," + "'" + answerTextBox.Text + "')";
                    string sel = "Insert Into AccountTbl(customer_name,customer_balance)"
                        + "Values('" + usernameTextBox.Text + "'" +","+ cost +")";
                    int i = dbObj.ExecuteNonQuery(selStr);
                    int c = dbObj.ExecuteNonQuery(sel);
                    MessageBox.Show("Successfully Registered!");
                    cusObj = new CustomerLogin();
                    cusObj.Show();
                    this.Hide();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string compareName = "";
            string str = "Select customer_username From CustomerTbl";
            string usernameOutput = usernameTextBox.Text;
            dR = dbObj.ExecuteReader(str);
            while (dR.Read())
            {
                string name = dR["customer_username"].ToString();
                if (usernameOutput == name) 
                {
                    compareName = name;
                    break;
                }
            
                
            }
            dR.Close();
            if (compareName == usernameOutput) 
            {
                // to check the name along with the database to see if it is taken
                MessageBox.Show("Username Taken! Try another username");
            }
            else 
            {
                MessageBox.Show("Hi");
            }
            
            //for (int i = 0; i < nameArray.Length; i++) 
            //{
            //    if (nameArray.ToString() == usernameTextBox.Text)
            //    {
            //        MessageBox.Show("Hi");
            //    }
            //}
           
            
        }

        private void CustomerRegister_Load(object sender, EventArgs e)
        {
            questionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            questionComboBox.Text = "What is your pet name?";
        }
    }
}
