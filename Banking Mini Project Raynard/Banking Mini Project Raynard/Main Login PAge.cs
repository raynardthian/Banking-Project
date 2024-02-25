using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_Mini_Project_Raynard
{
    public partial class Form1 : Form
    {
        Form1 frmObj;
        CustomerLogin cusLogin;
        AdminLogin adminLogin;
        CustomerRegister cusObj;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCustomer_Click(object sender, EventArgs e)
        {
            cusLogin = new CustomerLogin();
            cusLogin.Show();
            this.Hide();
        }

        private void btAdmin_Click(object sender, EventArgs e)
        {
            adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void btCustomerRegister_Click(object sender, EventArgs e)
        {
            cusObj = new CustomerRegister();
            cusObj.Show();
            this.Hide();
        }

        private void btAdminRegister_Click(object sender, EventArgs e)
        {
            AdminRegister adminObj = new AdminRegister();
            adminObj.Show();
            this.Hide();

        }
    }
}
