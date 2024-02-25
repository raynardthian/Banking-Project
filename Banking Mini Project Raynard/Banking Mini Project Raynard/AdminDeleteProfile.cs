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
    public partial class AdminDeleteProfile : Form
    {
        SqlDataReader dR;
        DataBase dbObj = new DataBase();
        Admin adminObj = new Admin();
        public AdminDeleteProfile()
        {
            InitializeComponent();
        }

        private void AdminDeleteProfile_Load(object sender, EventArgs e)
        {
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

        private void btBack_Click(object sender, EventArgs e)
        {
            UserInterfaceOfAdmin adminUI = new UserInterfaceOfAdmin();
            adminUI.Show();
            this.Hide();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string choice = customerComboBox.Text;
            var result = MessageBox.Show("Are you sure you want to delete " + choice + "?", "Delete Customer",
                      MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // If yes button is pressed, it prints out
                Console.WriteLine("Success!");
                int i = adminObj.deleteUserFromAccountTbl(choice);
                int a = adminObj.deleteUserFromCustomerTbl(choice);
                MessageBox.Show("Delete Successful!");
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
            else
            {
                // if no button it does not print out reciept
                Console.WriteLine("Fail!");
                MessageBox.Show("Delete Failed!");

            }
            
        }
    }
}
