using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace LeagueForm
{
    public class Summoner
    {   
        internal Summoner() { }

        [JsonProperty(PropertyName = "id")]
        public long id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }
        [JsonProperty(PropertyName = "profileIconId")]
        public int profileIconId { get; set; }
        [JsonProperty(PropertyName = "revisionDate")]
        public long revisionDate { get; set; }
        [JsonProperty(PropertyName = "summonerLevel")]
        public long summonerLevel { get; set; }

        public string iconURL = "http://avatar.leagueoflegends.com/na/{0}.png";
    }

    public class SummonerList
    {

        public Summoner Summoner { get; set; }

    }
}