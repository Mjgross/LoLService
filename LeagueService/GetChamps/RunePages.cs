using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace GetChamps
{
    public class RunePages
    {
        [JsonProperty("pages")]
        public List<Runes> Pages { get; set; }

        [JsonProperty("summonerId")]
        public long summonerId { get; set; }
    }
    
    public class Runes
    {
        [JsonProperty("current")]
        public Boolean current { get; set; }
        [JsonProperty("id")]
        public long id { get; set; }
        [JsonProperty("slots")]
        public List<RuneSlots> slots;
        [JsonProperty(PropertyName = "name")]
        public string nameR { get; set; }
    }

    public class RuneSlots
    {
        [JsonProperty("runeId")]
        public int runeId { get; set; }
        [JsonProperty("runeSlotId")]
        public int runeSlotId { get; set; }
    }
}