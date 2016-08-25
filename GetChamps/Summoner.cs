using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace GetChamps
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

    }

    public class SummonerList
    {
        public string userName ="";


        [JsonProperty(PropertyName = userName)]
        public Summoner Summoner { get; set; }

    }
}