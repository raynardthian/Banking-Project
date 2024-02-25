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
    public partial class AdminCustomerProfileActivity : Form
    {
        string choice;
        Customer cusObj = new Customer();
        SqlDataReader dR;
        DataBase dbObj = new DataBase();
        public AdminCustomerProfileActivity()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            UserInterfaceOfAdmin adminUI = new UserInterfaceOfAdmin();
            adminUI.Show();
            this.Hide();

        }

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AdminCustomerProfileActivity_Load(object sender, EventArgs e)
        {
            //string addr = cusObj.getCustomerAddress(choice);
            //string strAge = cusObj.getCustomerAge(choice);
            //string name = cusObj.getCustomerName(choice);
            //string password = cusObj.getCustomerPassword(choice);
            //string security_question = cusObj.getCustomerQuestion(choice);
            //string security_answer = cusObj.getCustomerQuestionAnswer(choice);
            //int age = int.Parse(strAge);
            //cusObj = new Customer(age, choice, name, addr, password, security_question, security_answer);
            //usernameLabel.Text = cusObj.Username;
            //nameTextBox.Text = cusObj.Name;
            //addressTextBox.Text = cusObj.Address;
            //ageTextBox.Text = cusObj.Age.ToString();
            //questionLabel.Text = cusObj.Question;
            //answerTextBox.Text = cusObj.Answer;
            //passwordTextBox.Text = cusObj.Password;
            customerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            string sel = "SELECT customer_username FROM CustomerTbl";

            string strAnswer = "";
            dR = dbObj.ExecuteReader(sel);
            while (dR.Read())
            {
                strAnswer = dR["customer_username"].ToString();
                customerComboBox.Items.Add(strAnswer);
            }
            dR.Close();
            
            
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            choice = customerComboBox.Text;
            string addr = cusObj.getCustomerAddress(choice);
            string strAge = cusObj.getCustomerAge(choice);
            string name = cusObj.getCustomerName(choice);
            string password = cusObj.getCustomerPassword(choice);
            string security_question = cusObj.getCustomerQuestion(choice);
            string security_answer = cusObj.getCustomerQuestionAnswer(choice);
            int age = int.Parse(strAge);
            cusObj = new Customer(age, choice, name, addr, password, security_question, security_answer);
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

            int updatePassword = cusObj.updateCustomerPassword(choice, cusObj.Password);
            int updateAddress = cusObj.updateCustomerAddress(choice, cusObj.Address);
            int updateName = cusObj.updateCustomerName(choice, cusObj.Name);
            int updateAge = cusObj.updateCustomerAge(choice, cusObj.Age);
            int updateQuestionAnswer = cusObj.updateCustomerAnswer(choice, cusObj.Answer);
            MessageBox.Show("Successfully Updated!");
            UserInterfaceOfAdmin adminUi = new UserInterfaceOfAdmin();
            adminUi.Show();
            this.Hide();
        }
    }
}
