using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_Mini_Project_Raynard
{
    public partial class ReceiptActivity : Form
    {
        Bitmap bmp;
        Customer cusObj = new Customer();
        string username = CustomerLogin.SetValueForUsername;
        public ReceiptActivity()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0); // This sets to show the whole document
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            btPrint.Visible = false;
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);// This is to get the image of the activity
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size); // This is to get the whole page
            printPreviewDialog1.ShowDialog();

        }

        private void ReceiptActivity_Load(object sender, EventArgs e)
        {
            string choices = DepositAndWithdrawActivity.selectedChoice;
            if(choices == "Transfer")
            {
                label1.Visible = true;
                transferNameLabel.Visible = true;
                transferNameLabel.Text = DepositAndWithdrawActivity.transferee;
            }
            
            custUsernameLabel.Text = username;
            customerBankBalanceLabel.Text = cusObj.getBalance(username).ToString();
            transferAmountLabel.Text = DepositAndWithdrawActivity.selectedAmount.ToString();
            
        }
    }
}
