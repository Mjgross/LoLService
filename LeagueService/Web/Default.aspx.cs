using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //update database
        protected void btnUser1(object Source, EventArgs e)
        {
            List<string> summonerData;
            bool update_database = false;

            if (!string.IsNullOrWhiteSpace(user1Info.ToString()))
            {
                string userName = user1Info.Value.ToString().ToLower();
                //If checked then UPDATE the database
                //DATABASE UPDATE
                //**********************************//
                if (toggle_update1.Checked == true)
                {   
                    //reference to grab summoner info
                    ServiceReference1.IService1 serv = new ServiceReference1.Service1Client();
                    summonerData= new List<string>();
                    summonerData = serv.update(userName).ToList();
                    update_database = true;

                    //reference to updateDB
                    updateDB database = new updateDB();
                    database.updateSummoner(summonerData);
                }
                //LOAD from DB
                //DATABASE LOAD
                else
                {

                }
                //userName
           
                //LOAD FROM DATABASE

            }
        }
    }
}