using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webs
{
    public partial class summoner : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //creating new route
            RouteCollection routes = new RouteCollection();
            URLroutes(routes);
            string userName = Request.CurrentExecutionFilePath.ToString().Substring(9);
            
            //if valid path exists
            if(!String.IsNullOrWhiteSpace(userName))
            {
                string concatUsername = userName.Substring(1);
                updateDB db = new updateDB();
                //db.mainHandler(concatUsername);
            }
        }
        void URLroutes(RouteCollection routes)
        {
           routes.MapRoute("summoner", "summoner/{controller}",
                new { controller = "summoner" });
        }
    }
}