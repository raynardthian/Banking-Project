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
    public partial class AdminRegister : Form
    {
        DataBase dbObj = new DataBase();
        SqlDataReader dR;
        public AdminRegister()
        {
            InitializeComponent();
        }

        private void AdminRegister_Load(object sender, EventArgs e)
        {
            btRegister.Enabled = false;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if(securityCodeTextBox.Text == "")
            {
                MessageBox.Show("Please enter the security code!");
            }
            else
            {
                string code = securityCodeTextBox.Text;
                string compareCode = "raynard";
                if(code == compareCode)
                {
                    btRegister.Enabled = true;
                    btOk.Enabled = false;
                }
               
            }
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            if(username == "")
            {
                MessageBox.Show("Please enter your username");
            }
            else if (password == "")
            {
                MessageBox.Show("Please enter your password");
            }
            else if(name == "")
            {
                MessageBox.Show("Please enter your name");
            }
            else
            {
                string nameFromDataBase = "";
                string compareUsername = "";
                string str = "Select admin_username From AdminTbl";
                dR = dbObj.ExecuteReader(str);
                while (dR.Read())
                {
                    // Check for the name in the database whether it is taken
                    nameFromDataBase = dR["admin_username"].ToString();
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
                    
                    // This is to add one customer details into the CustomerTbl
                    string selStr = "Insert Into AdminTbl(admin_username,admin_name,admin_password)"
                        + "Values('" + username + "'" + "," + "'" + name + "'" + "," + "'" + password + "')";
                   
                    int i = dbObj.ExecuteNonQuery(selStr);
                   
                    MessageBox.Show("Successfully Registered!");
                    AdminLogin adminObj = new AdminLogin();
                    adminObj.Show();
                    this.Hide();
                }

            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Form1 frmObj = new Form1();
            frmObj.Show();
            this.Hide();
        }
    }
}
