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
    public partial class ProfileActivity : Form
    {
        DataBase dbObj = new DataBase();
        SqlDataReader dR;
        Customer cusObj = new Customer();
        string username = CustomerLogin.SetValueForUsername;
        UserInterfaceOfCustomer uiObj;
        public ProfileActivity()
        {
            InitializeComponent();
        }

        private void ProfileActivity_Load(object sender, EventArgs e)
        {
            
            string addr = cusObj.getCustomerAddress(CustomerLogin.SetValueForUsername);
            string strAge = cusObj.getCustomerAge(CustomerLogin.SetValueForUsername);
            string name = cusObj.getCustomerName(CustomerLogin.SetValueForUsername);
            string password = cusObj.getCustomerPassword(CustomerLogin.SetValueForUsername);
            string security_question = cusObj.getCustomerQuestion(CustomerLogin.SetValueForUsername);
            string security_answer = cusObj.getCustomerQuestionAnswer(CustomerLogin.SetValueForUsername);
            

            int age = int.Parse(strAge);
            cusObj = new Customer(age, username, name, addr, password, security_question, security_answer);
            usernameLabel.Text = cusObj.Username;
            nameTextBox.Text = cusObj.Name;
            addressTextBox.Text = cusObj.Address;
            ageTextBox.Text = cusObj.Age.ToString();
            questionLabel.Text = cusObj.Question;
            answerTextBox.Text = cusObj.Answer;
            passwordTextBox.Text = cusObj.Password;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            cusObj.Name = nameTextBox.Text;
            cusObj.Address = addressTextBox.Text;
            cusObj.Age = int.Parse(ageTextBox.Text);
            cusObj.Password = passwordTextBox.Text;
            cusObj.Answer = answerTextBox.Text;

            int updatePassword = cusObj.updateCustomerPassword(username, cusObj.Password);
            int updateAddress = cusObj.updateCustomerAddress(username, cusObj.Address);
            int updateName = cusObj.updateCustomerName(username, cusObj.Name);
            int updateAge = cusObj.updateCustomerAge(username, cusObj.Age);
            int updateQuestionAnswer = cusObj.updateCustomerAnswer(username, cusObj.Answer);
            MessageBox.Show("Successfully Updated!");
            uiObj = new UserInterfaceOfCustomer();
            uiObj.Show();
            this.Hide();
        }
    }
}
