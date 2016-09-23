using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web
{
    public class mysql
    {
        public MySql.Data.MySqlClient.MySqlConnection mysql_Connection()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            // myConnectionString = "server=127.0.0.1;uid=root;" +
            // "pwd=matthew98;database=test;";
            myConnectionString = "Server=localhost; database=league; UID=root; password=matthew98";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                return conn;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}