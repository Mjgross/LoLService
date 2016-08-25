using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace GetChamps
{
    public class MasteryPages
    {
        [JsonProperty("pages")]
        public List<Mastery> Pages { get; set; }
        [JsonProperty("summonerId")]
        public long summonerId { get; set; }
    }

    public class Mastery
    {
        [JsonProperty("current")]
        public Boolean current { get; set; }
        [JsonProperty("id")]
        public long id { get; set; }
        [JsonProperty("masteries")]
        public List<Mastery> mastery;
        [JsonProperty(PropertyName = "name")]
        public string nameM { get; set; }
    }
}