using Site.Queries;
using Site.Summoner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site
{
    public partial class Site1 : System.Web.UI.MasterPage
    {

        [WebMethod]
        public static string User(string Name)
        {
                return Name;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void searchUser(object sender, EventArgs e)
        {
            database db;
            Site.Summoner.SummonerData summoner = new Site.Summoner.SummonerData();
            try
            {
                ServiceReference1.IService1 summonerReference = new ServiceReference1.Service1Client();

                string name = String.Format("{0}", Request.Form["summoner"]);
                summoner.id = summonerReference.update(name).id;
                summoner.name = summonerReference.update(name).name;
                summoner.profileIconId = summonerReference.update(name).profileIconId;
                summoner.summonerLevel = summonerReference.update(name).summonerLevel;
                summoner.revisionDate = summonerReference.update(name).revisionDate;

                // db = new Queries.database();
                // db.Client();
            }
            catch
            {

            }
        }
    }
}