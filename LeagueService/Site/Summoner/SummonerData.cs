using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.Summoner
{
    public class SummonerData
    {
        internal SummonerData() { }

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

        public SummonerData Summoner { get; set; }

    }
}