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
    public partial class AdminLogin : Form
    {
        Form1 frmObj;
        SqlDataReader dR;
        DataBase dbObj = new DataBase();
        public AdminLogin()
        {
            InitializeComponent();
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

                string str = "Select admin_password,admin_username From AdminTbl"; 
                dR = dbObj.ExecuteReader(str);
                while (dR.Read())
                {
                    // if i didnt use this, it takes the password of the next row
                    getUsername = dR["admin_username"].ToString();
                    getPassword = dR["admin_password"].ToString();
                   
                    if (username == getUsername)
                    {
                        compareUsername = getUsername;
                        comparePassword = getPassword;
                       
                    }
                }
                dR.Close();
                if (comparePassword == password)
                {                   
                    MessageBox.Show("Successful Login!");
                    UserInterfaceOfAdmin uiAdmin = new UserInterfaceOfAdmin();
                    uiAdmin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong password!");
                }
                
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            frmObj = new Form1();
            frmObj.Show();
            this.Hide();
        }

        private void btAdminRegister_Click(object sender, EventArgs e)
        {
            AdminRegister adminRegObj = new AdminRegister();
            adminRegObj.Show();
            this.Hide();
        }
    }
}
