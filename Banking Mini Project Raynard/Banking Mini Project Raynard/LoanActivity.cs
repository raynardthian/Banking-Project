using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; // To check valid datetime

namespace Banking_Mini_Project_Raynard
{
    public partial class LoanActivity : Form
    {
        float interest;
        string choice;
        int duration;
        Customer cusObj = new Customer();
        string username = CustomerLogin.SetValueForUsername;
        public LoanActivity()
        {
            InitializeComponent();
        }

        private void LoanActivity_Load(object sender, EventArgs e)
        {
            //interestComboBox.Items.Add("6 Months Loan (Simple Interest 6%)");
            //interestComboBox.Items.Add("9 Months Loan (Simple Interest 5%");
            //interestComboBox.Items.Add("12 Months Loan (Simple Interest 3%");

            // This sets the comboBox to be read only
            interestComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            monthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dayComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            string ans = cusObj.getCustomerLoan(username);
            if (ans == "Yes")
            {
                MessageBox.Show("You cannot loan as you have a existing loan!");
                btOk.Enabled = false;
            }
            else
            {
                btOk.Enabled = true;
            }
                //DateTime thisDay = DateTime.Today;

                //Console.WriteLine("1: " + thisDay.ToString());
                //Console.WriteLine();
                //// Display the date in a variety of formats.
                //Console.WriteLine("2: " + thisDay.ToString("d")); // This is to display 02-Feb-21
                //Console.WriteLine("3: " + thisDay.ToString("D")); // This is to display February 2 , 2021
                //Console.WriteLine("4: " + thisDay.ToString("g")); // This is to display 02-Feb-21 12:00AM

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            UserInterfaceOfCustomer uiObj = new UserInterfaceOfCustomer();
            uiObj.Show();
            this.Hide();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            //This is to check whether the date is valid
            DateTime d;
            //bool chValidity = DateTime.TryParseExact(loanTotalYear, "dd-MMM-yyyy",
            //                      CultureInfo.InvariantCulture,
            //                      DateTimeStyles.None,
            //                      out d);
            //if (chValidity == true)
            //{
            //    Console.WriteLine("Success!");
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}

            // If customer_loan yes that means they cannot loan
            // if customer_loan no means they can loan

           
                DateTime thisDay = DateTime.Today;
                if (loanTextBox.Text == "")
                {
                    MessageBox.Show("Please input your Loan Amount");
                }
                else
                {
                    string day = dayComboBox.Text;
                    string month = monthComboBox.Text;
                    string year = yearComboBox.Text;
                    string str = "";
                    string s = "";
                    string totalDay = day + "-" + month + "-" + year; // Needs to be saved in AccountTbl
                    string today = thisDay.ToString("dd-MMM-yyyy");

                //Remove This if need to show that dates work From Here To
                //if (today != totalDay)
                //{
                //    MessageBox.Show("Please input the correct today's date!");
                //}
                //else
                //{
                    // To Here
                    int monthCount = 0;
                        int addingYear = 0;
                        int finalDay = 0;
                        int addingMonth = 0;
                        int totalMonth = 0;

                        // Main Bulk of the code
                        float loanAmount = float.Parse(loanTextBox.Text); // Principle Amount
                                                                          // Interest Rate by calling interest rate
                        float divisionOfInterest = interest / 12;
                        float totalInterestRate = 1 + divisionOfInterest;
                        // Nth power is the duration
                        float gpForumla = (float)Math.Pow(totalInterestRate, duration);
                        float totalAmount = loanAmount * (float)gpForumla;
                        float totalAmountInTwoDecimal = (float)Math.Round(totalAmount * 100f) / 100f; // This is the final amount that we gonna get
                        int customerMonthOfLoan = monthToMonthNumber(month);
                        int sumOfCustomerMonthOfLoan = customerMonthOfLoan + duration;
                        // This adds the duration of the customer loan ^
                        // So that this would be the final month/year that the customer have to pay the loan
                        monthCount = sumOfCustomerMonthOfLoan;
                        if (sumOfCustomerMonthOfLoan >= 13) // calculate if the month is more than 13, it calculates to the next year
                        {
                            monthCount = sumOfCustomerMonthOfLoan - 12;
                            addingYear = 1;
                        }
                        int totalYear = int.Parse(year) + addingYear;
                        string totalYearToString = totalYear.ToString();
                        string monthCountToString = MonthNumberToMonth(monthCount);
                        s = MonthNumberToMonth(monthCount);
                        string loanTotalYear = day + "-" + monthCountToString + "-" + totalYearToString;
                        bool chValidity = chValidity = DateTime.TryParseExact(loanTotalYear, "dd-MMM-yyyy", // Check if the date is valid
                                      CultureInfo.InvariantCulture,
                                      DateTimeStyles.None,
                                      out d);
                        finalDay = int.Parse(day);
                        totalMonth = monthCount;
                        while (!chValidity) // If not valid it will loop in this
                        {
                            finalDay++;
                            if (finalDay >= 32)
                            {
                                finalDay = 0;
                                addingMonth = 1;
                                totalMonth = addingMonth + totalMonth;
                            }
                            else
                            {
                                s = MonthNumberToMonth(totalMonth);
                                str = finalDay.ToString("D2") + "-" + s + "-" + totalYearToString; // D2 is to display 01 instead of 01
                                chValidity = DateTime.TryParseExact(str, "dd-MMM-yyyy",
                                      CultureInfo.InvariantCulture,
                                      DateTimeStyles.None, out d);

                                if (chValidity == true)
                                {
                                    Console.WriteLine("Success!");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Failed");
                                }
                            }
                        }
                        str = finalDay.ToString("D2") + "-" + s + "-" + totalYearToString; // Need to save these variables into the AccountTbl
                        int updateLoanDate = cusObj.updateLoanDate(username, str);
                        int updateLoanDateDay = cusObj.updateLoanDateDay(username, finalDay.ToString("D2"));
                        int updateLoanDateMonth = cusObj.updateLoanDateMonth(username, s);
                        int updateLoanDateYear = cusObj.updateLoanDateYear(username, totalYearToString);
                        int updateLoanAmount = cusObj.updateLoanAmount(username, totalAmountInTwoDecimal);
                        string customer_loan = "Yes";
                        int updateLoanInDebt = cusObj.updateLoanInDebt(username, customer_loan);
                        string wee = cusObj.getCustomerLoan(username);
                        MessageBox.Show("Loan Successful!\n" + "Your due payment loan date is : " + str 
                                    + "\nYou need to pay $" + totalAmountInTwoDecimal.ToString()) ;
                //}
                //Remove This if need to show that dates work 
            }
            
        }

        private void interestComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = interestComboBox.Text;
            if (str == "6 Months Loan (Compound Interest Monthly 6%)")
            {
                choice = "6 Months Loan (Compound Interest Monthly 6%)";
                interest = 0.06f;
                duration = 6;
              
            }
            else if (str == "9 Months Loan (Compound Interest Monthly 5.5%)")
            {
                choice = "9 Months Loan(Compound Interest Monthly 5.5%)";
                interest = 0.055f;
                duration = 9;
            }
            else
            {
                choice = "12 Months Loan (Compound Interest Monthly 5.3%)";
                interest = 0.053f;
                duration = 12;
            }                       
        }

        private int monthToMonthNumber(string month) 
        {
            int monthToNumber;
            if(month == "Jan") 
            {
                monthToNumber = 1;
            }
            else if(month == "Feb") 
            {
                monthToNumber = 2;
            }
            else if(month == "Mar") 
            {
                monthToNumber = 3;
            }
            else if (month == "Apr")
            {
                monthToNumber = 4;
            }
            else if (month == "May")
            {
                monthToNumber = 5;
            }
            else if (month == "Jun")
            {
                monthToNumber = 6;
            }
            else if (month == "Jul")
            {
                monthToNumber = 7;
            }
            else if (month == "Aug")
            {
                monthToNumber = 8;
            }
            else if (month == "Sep")
            {
                monthToNumber = 9;
            }
            else if (month == "Oct")
            {
                monthToNumber = 10;
            }
            else if (month == "Nov")
            {
                monthToNumber = 11;
            }
            else 
            {
                monthToNumber = 12;
            }
            return monthToNumber;
        }
        public string MonthNumberToMonth (int intMonth) 
        {
            string numberToMonth;
            if(intMonth == 1)
            {
                numberToMonth = "Jan";
            }
            else if(intMonth == 2)
            {
                numberToMonth = "Feb";
            }
            else if (intMonth == 3)
            {
                numberToMonth = "Mar";
            }
            else if (intMonth == 4)
            {
                numberToMonth = "Apr";
            }
            else if (intMonth == 5)
            {
                numberToMonth = "May";
            }
            else if (intMonth == 6)
            {
                numberToMonth = "Jun";
            }
            else if (intMonth == 7)
            {
                numberToMonth = "Jul";
            }
            else if (intMonth == 8)
            {
                numberToMonth = "Aug";
            }
            else if (intMonth == 9)
            {
                numberToMonth = "Sep";
            }
            else if (intMonth == 10)
            {
                numberToMonth = "Oct";
            }
            else if (intMonth == 11)
            {
                numberToMonth = "Nov";
            }
            else
            {
                numberToMonth = "Dec";
            }
            return numberToMonth;
        }
    }
}
