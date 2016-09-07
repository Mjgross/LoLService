using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace GetChamps
{
    public class Main
    {
        private string username;

        public List<string> Controller(string username)
        {
            List<string> list = new List<string>();
            //sets class username for data gathering
            this.username = username.Replace(" ", "");
            //Grab all Summoner Information
            list = GrabSummonerInfo(list);
            return list;
        }
        
        private List<string> GrabSummonerInfo(List<string> list)
        {
            //Summoner ID for adding to list
            string summon = getSummoner(username);
            var summonData = JsonConvert.DeserializeObject<Dictionary<string, Summoner>>(summon);

            list.Add(summon);                                   //0
            list.Add(getMastery(summonData.First().Value.id));  //1
            list.Add(getRunes(summonData.First().Value.id));    //2
            list.Add(getChampRanked(summonData.First().Value.id));    //3
            list.Add(getRecent(summonData.First().Value.id)); //4


            return list;
        }
        

        //Grabs Summoner API URL
        public string getSummoner(string username)
        {
            Request req = new Request();
            string url = apiLinks.root + apiLinks.summonerNameURL + apiLinks.api_key;
            url = String.Format(url, username);
            string returner = req.requester(url);
            return returner;
        }

        public string getMastery(long id)
        {
            Request req = new Request();
            string url = apiLinks.root + apiLinks.summonerMasteryURL + apiLinks.api_key;
            string idString = id.ToString();
            url = String.Format(url, idString);
            string returner = req.requester(url);
            return returner;
        }

        public string getRunes(long id)
        {
            Request req = new Request();
            string url = apiLinks.root + apiLinks.summonerRunesURL + apiLinks.api_key;
            string idString = id.ToString();
            url = String.Format(url, idString);
            string returner = req.requester(url);
            return returner;
        }

        public string getChampRanked(long id)
        {
            Request req = new Request();
            string url = apiLinks.root + apiLinks.rankedURL + apiLinks.api_key;
            string idString = id.ToString();
            url = String.Format(url, idString);
            string returner = req.requester(url);
            return returner;
        }

        public string getRecent(long id)
        {
            Request req = new Request();
            string url = apiLinks.root + apiLinks.recentURL + apiLinks.api_key;
            string idString = id.ToString();
            url = String.Format(url, idString);
            string returner = req.requester(url);
            return returner;
        }

    }
}
