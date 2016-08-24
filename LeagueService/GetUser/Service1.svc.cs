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

namespace GetUser
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        private const string api_key = "";

        public UserData getData(string name)
        {
            //vars
            StreamReader reader;
            string res;
            string sumName =  "\"" + name + "\"";
            Console.WriteLine(sumName);
            UserData data = new UserData();
            //URL for Summoner Name
            string url = @"https://na.api.pvp.net/api/lol/na/v1.4/summoner/by-name/" + name
                            + "?api_key=" + api_key;

            //creating the request
      
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "Get";
            request.Accept = "*/*";
            WebResponse response = (WebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            //stream reader
            reader = new StreamReader(responseStream);
            res = reader.ReadToEnd();
            responseStream.Close();

            JavaScriptSerializer ser = new JavaScriptSerializer();
            var summonerData = ser.Deserialize<Dictionary<string, UserData>>(res);
            var sum = summonerData.First().Value;

            //store information
            data.id = sum.id;
            data.name = sum.name;
            data.profileIcon = sum.profileIcon;
            data.revisionDate = sum.revisionDate;
            data.summonerIcon = sum.summonerIcon;

            //return
            return data;
        }


    }
}
