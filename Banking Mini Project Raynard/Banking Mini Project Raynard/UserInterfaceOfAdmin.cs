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
    public partial class UserInterfaceOfAdmin : Form
    {
        public UserInterfaceOfAdmin()
        {
            InitializeComponent();
        }

        private void btProfile_Click(object sender, EventArgs e)
        {
            AdminCustomerProfileActivity profObj = new AdminCustomerProfileActivity();
            profObj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDeleteProfile deleteObj = new AdminDeleteProfile();
            deleteObj.Show();
            this.Hide();
        }
    }
}
