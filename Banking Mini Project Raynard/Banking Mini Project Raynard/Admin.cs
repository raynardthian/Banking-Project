using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace Banking_Mini_Project_Raynard
{
    class Admin : DataBase
    {
        private string password;
        private string username;
        private string name;
        SqlDataReader dR;
        DataBase dbObj = new DataBase();
        public Admin(string pass, string user, string Name) : base()
        {
            password = pass;
            username = user;
            name = Name;
        }
        public Admin() : base() 
        {
            
        }

        public int deleteUserFromCustomerTbl(string choice)
        {
            string sel = "Delete From CustomerTbl Where customer_username ='" + choice + "'";
            int i = dbObj.ExecuteNonQuery(sel);
            return i;
        }
        public int deleteUserFromAccountTbl(string choice)
        {
            string sel = "Delete From AccountTbl where customer_name ='" + choice + "'";
            int i = dbObj.ExecuteNonQuery(sel);
            return i;
        }
    }
}
