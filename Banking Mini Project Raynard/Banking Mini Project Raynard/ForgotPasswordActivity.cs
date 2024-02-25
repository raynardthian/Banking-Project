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
    public partial class ForgotPasswordActivity : Form
    {
        DataBase dbObj = new DataBase();
        SqlDataReader dR;
        string answer = "";
        CustomerLogin cusObj;
        public ForgotPasswordActivity()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string question = "";
            
            string str = "Select customer_security_question,customer_security_answer From CustomerTbl Where customer_username = " + "'" + username + "'";
            dR = dbObj.ExecuteReader(str);
            while (dR.Read())
            {
                question = dR["customer_security_question"].ToString();
                answer = dR["customer_security_answer"].ToString();
                
            }
            dR.Close();
            questionLabel.Text = question;
            btOk.Enabled = false;

        }

        private void ForgotPasswordActivity_Load(object sender, EventArgs e)
        {

        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            string getAnswer = answerTextBox.Text;
            if (answer == getAnswer) 
            {
                // It enables the textbox and button to change password
                passwordTextBox.Enabled = true;
                btChange.Enabled = true;
                btSubmit.Enabled = false;
            }
            else 
            {
                // It does not allow changing of password
                MessageBox.Show("Wrong answer please try again!");
            }

        }

        private void btChange_Click(object sender, EventArgs e)
        {
            // this is to update the table to change the password of the customer
            string sel = "Update CustomerTbl" + " Set customer_password = " + "'" + passwordTextBox.Text + "'" + " Where customer_username = " + "'" + usernameTextBox.Text + "'";
            int i = dbObj.ExecuteNonQuery(sel);
            MessageBox.Show("Password Successfully updated!");
            cusObj = new CustomerLogin();
            cusObj.Show();
            this.Hide();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            cusObj = new CustomerLogin();
            cusObj.Show();
            this.Hide();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
