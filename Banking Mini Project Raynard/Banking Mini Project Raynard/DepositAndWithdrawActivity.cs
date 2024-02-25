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
using System.Runtime.CompilerServices;

namespace Banking_Mini_Project_Raynard
{
    public partial class DepositAndWithdrawActivity : Form
    {
        UserInterfaceOfCustomer uiObj;
        string choices;
        DataBase dbObj = new DataBase();
        SqlDataReader dR;
        Customer cusObj = new Customer();
        public static string selectedAmount = "";
        public static string transferee = "";
        public static string selectedChoice = "";
        public DepositAndWithdrawActivity()
        {
            InitializeComponent();
        }

        private void DepositAndWithdrawActivity_Load(object sender, EventArgs e)
        {
            // This is just to ensure that the first display of the comboBox will be Withdrawal
            choiceComboBox.Text = "Withdrawal";
            // This sets the comboBox to be read only
            choiceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            inputTextBox.Focus();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = choiceComboBox.SelectedItem.ToString();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            uiObj = new UserInterfaceOfCustomer();
            uiObj.Show();
            this.Hide();
        }

        private void messageBox(DialogResult result) 
        {
            if (result == DialogResult.Yes)
            {
                // If yes button is pressed, it prints out
                Console.WriteLine("Success!");

            }
            else
            {
                // if no button it does not print out reciept
                Console.WriteLine("Fail!");
            }
        }
        private void choiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = choiceComboBox.Text;
            //label1.Text = choiceComboBox.SelectedItem.ToString();
            if (choice == "Withdrawal")
            {
                questionLabel.Text = "Withdrawal Amount:";
                choices = "Withdrawal";
                transferTextBox.Visible = false;
                label2.Visible = false;
                selectedChoice = choices;
            }
            else if (choice == "Deposit")
            {
                questionLabel.Text = "Deposit Amount:";
                choices = "Deposit";
                transferTextBox.Visible = false;
                label2.Visible = false;
                selectedChoice = choices;
            }
            else if (choice == "Transfer") 
            {
                questionLabel.Text = "Transfer Amount:";
                choices = "Transfer";
                transferTextBox.Visible = true;
                label2.Visible = true;
                selectedChoice = choices;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            string amount = "";
            if (inputTextBox.Text == "")
            {
                MessageBox.Show("Please input your amount");
                inputTextBox.Focus();
            }
            else
            {
                amount = inputTextBox.Text;
                if (choices == "Transfer")
                {
                    float customerBalance = 0.0f;
                    float transferBalance = 0.0f;
                    float totalBalanceOfCustomer = 0.0f;
                    float totalBalanceOfTransfer = 0.0f;
                    string nameTransfer = transferTextBox.Text;
                    string compareName="";
                    if (transferTextBox.Text == "")
                    {
                        MessageBox.Show("Please input your transferee name!");
                    }
                    else
                    {
                        string selectString = "Select customer_name From AccountTbl";
                        dR = dbObj.ExecuteReader(selectString);
                        while (dR.Read()) 
                        {
                            string name = dR["customer_name"].ToString();
                            if (nameTransfer == name) 
                            {
                                compareName = name;
                            }
                        }
                        dR.Close();                   
                        if (compareName == nameTransfer)
                        {
                            // Need to check whether the transfer name is in the database
                            float fltAmount = float.Parse(amount);
                            
                            dR.Close();
                            // I need to get out the transferName balance and the customerBalance.
                            customerBalance = cusObj.getBalance(CustomerLogin.SetValueForUsername);
                            transferBalance = cusObj.getBalance(nameTransfer);

                            totalBalanceOfCustomer = customerBalance - fltAmount;
                            totalBalanceOfTransfer = transferBalance + fltAmount;

                            string selStr = "Update AccountTbl Set customer_balance =" + totalBalanceOfCustomer
                                + " Where customer_name = '" + CustomerLogin.SetValueForUsername + "'";
                            int i = dbObj.ExecuteNonQuery(selStr);
                            string sel = "Update AccountTbl Set customer_balance =" + totalBalanceOfTransfer
                                + " Where customer_name = '" + nameTransfer + "'";
                            int c = dbObj.ExecuteNonQuery(sel);
                            MessageBox.Show("You have transfered $" + amount + " to " + nameTransfer);

                            var result = MessageBox.Show("Do you want a reciept?", "Transfer Successful",
                       MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                // If yes button is pressed, it prints out
                                Console.WriteLine("Success!");
                                transferee = nameTransfer;
                                selectedAmount = amount;
                                ReceiptActivity recieptObj = new ReceiptActivity();
                                recieptObj.Show();
                            }
                            else
                            {
                                // if no button it does not print out reciept
                                Console.WriteLine("Fail!");
                            }
                        }
                        else 
                        {
                            MessageBox.Show("Transfer Username not valid");
                            transferTextBox.Focus();
                        }
                    }
                }
                else if (choices == "Deposit")
                {
                    float totalbalance = 0.0f;
                    float balance = cusObj.getBalance(CustomerLogin.SetValueForUsername);
                    float fltAmount = float.Parse(amount);
                    totalbalance = fltAmount + balance;
                    string selStr = "Update AccountTbl Set customer_balance =" + "'" + totalbalance + "'"
                        + " Where customer_name ='" + CustomerLogin.SetValueForUsername + "'";

                    int i = dbObj.ExecuteNonQuery(selStr);
                    MessageBox.Show("Successful Deposit of $" + amount);

                    var result = MessageBox.Show("Do you want a reciept?", "Deposit Successful",
                        MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // If yes button is pressed, it prints out
                        Console.WriteLine("Success!");
                        selectedAmount = amount;
                        ReceiptActivity recieptObj = new ReceiptActivity();
                        recieptObj.Show();
                        
                       
                    }
                    else
                    {
                        // if no button it does not print out reciept
                        Console.WriteLine("Fail!");
                    }
                }
                else
                {
                    float balance = cusObj.getBalance(CustomerLogin.SetValueForUsername);
                    float totalbalance = 0.0f;                   
                    float fltAmount = float.Parse(amount);
                    totalbalance = balance - fltAmount;
                    string selStr = "Update AccountTbl Set customer_balance =" + "'" + totalbalance + "'"
                       + " Where customer_name ='" + CustomerLogin.SetValueForUsername + "'";

                    int i = dbObj.ExecuteNonQuery(selStr);
                    MessageBox.Show("Successful Withdrawal of $" + amount);
                    
                    var result = MessageBox.Show("Do you want a reciept?", "Withdrawal Successful",
                        MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // If yes button is pressed, it prints out
                        Console.WriteLine("Success!");
                        selectedAmount = amount;
                        ReceiptActivity recieptObj = new ReceiptActivity();
                        recieptObj.Show();
                    }
                    else
                    {
                        // if no button it does not print out reciept
                        Console.WriteLine("Fail!");
                    }

                }
            }
        }
    }
}
