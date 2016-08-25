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

        public void Controller(string username)
        {
            //sets class username for data gathering
            this.username = username;
            //Grab all Summoner Information
            GrabSummonerInfo();
        }
        private void GrabSummonerInfo()
        {
            //Grabs essential summoner data
            string summon = getSummoner(username);
            var summonData = JsonConvert.DeserializeObject<Dictionary<string, Summoner>>(summon);
            //grabs masteries
            string summonM = getMastery(summonData.First().Value.id);
            var summonMastery = JsonConvert.DeserializeObject<Dictionary<string,MasteryPages>>(summonM);

            //grabs runes
            string summonR = getRunes(summonData.First().Value.id);
            var summonRunes = JsonConvert.DeserializeObject<Dictionary<string, RunePages>>(summonR);
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

        public lists getChamp(string id)
        {
            lists ChampList = new lists();
            return ChampList;
        }
    }
}
