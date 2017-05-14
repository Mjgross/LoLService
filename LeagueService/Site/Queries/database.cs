using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Site.Queries
{
    public class database
    {

        public MySqlConnection Client()
        {
            MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();
            string myConnectionString;

            // myConnectionString = "server=127.0.0.1;uid=root;" +
            // "pwd='';database=test;";
            myConnectionString = "Server=localhost; database=league; UID=root; password=''";
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();
                return conn;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("ERROR CODE:" + ex.ErrorCode + ". Connection not established.");
                conn.Close();
            }
            return null;
        }
    }
}