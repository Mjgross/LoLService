using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace GetChamps
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private const string api_key = "";

        public championList getChamps(long sumId)
        {
            string url = @"https://na.api.pvp.net/api/lol/na/v1.3/stats/by-summoner/" + sumId + "/ranked?api_key=" + api_key;

            championList champions = new championList();
        //creating the request

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "Get";
            request.Accept = "*/*";
            WebResponse response = (WebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            //stream reader
            StreamReader reader = new StreamReader(responseStream);
            var res = reader.ReadToEnd();
            responseStream.Close();

            JavaScriptSerializer ser = new JavaScriptSerializer();

            
            
            
            
            // work in progress ( 8/23 )
            championInfo champdata = ser.Deserialize<championInfo>(res);
            //foreach(var child in champdata.Children())
           // {
              //  championInfo champ = new championInfo();
                //champ.id = champdata[]
          //  }
            //var champs = champdata.First().Value;
            return champions;
    }


    }
}
