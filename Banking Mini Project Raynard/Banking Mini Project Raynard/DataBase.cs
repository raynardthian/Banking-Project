﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Banking_Mini_Project_Raynard
{
    class DataBase
    {
        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OOPG\Banking Mini Project Raynard\Banking Mini Project Raynard\Database1.mdf;Integrated Security = True";
        SqlConnection connObj;
        SqlCommand comdObj;
        SqlDataReader dR;
               
        public DataBase()
        {
            connObj = new SqlConnection(connStr);
            connObj.Open();
        }
        public SqlDataReader ExecuteReader(string selStr)
        {
            comdObj = new SqlCommand(selStr, connObj);
            dR = comdObj.ExecuteReader();
            return dR;
        }
        public int ExecuteNonQuery(string sqlStr)
        {
            comdObj = new SqlCommand(sqlStr, connObj);
            return comdObj.ExecuteNonQuery();
        }
    }
}
