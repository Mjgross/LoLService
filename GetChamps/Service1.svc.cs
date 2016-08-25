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
using RestSharp;
namespace GetChamps
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private string reqData;
        public string update(string username)
        {
            //path for request
            //string url = string.Format("{0}{1}{2}{3}", apiLinks.root, apiLinks.summonerNameURL,username, apiLinks.api_key);
            //summoner request
            //reqData =requester(url);

            //TO DO HERE::::::::::
            //request.AddUrlSegment("summonerNames", String.Join(",", summonerNames));
            //Get summoner mastery
            //url = string.Format("{0}{1}{2}{3}", apiLinks.root, apiLinks.summonerMasteryURL, sumList.id, apiLinks.api_key);
            // reqData = requester(url);

            var sum = getSummoner(username);
            SummonerList sumList = JsonConvert.DeserializeObject<SummonerList>(sum);
            sumList.userName = username;
            var mastery = getMastery(sumList.Summoner.id);
            return reqData;
        }

        private string requester(string url)
        {
     
            var request = new Request();
            
            string data = request.getRequest(url);
            return data;
        }

        public string getSummoner(string username)
        {
            string url = apiLinks.root + apiLinks.summonerNameURL + apiLinks.api_key;
            url = String.Format(url, username);
            string returner = requester(url);
            return returner;
        }

        public long getMastery(long id)
        {
           
            return id;
        }

        public string getRunes(string id)
        {
            return id;
        }

        public lists getChamp(string id)
        {
            lists ChampList = new lists();
            return ChampList;
        }
    }
}
