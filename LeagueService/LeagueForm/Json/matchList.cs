using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace LeagueForm
{
    public class matchList
    {

        [JsonProperty("endIndex")]
        public int endIndex { get; set; }

        [JsonProperty("matches")]
        public List<MatchReference> MatchReference {get;set;}

        [JsonProperty("startIndex")]
        public int startIndex { get; set; }

        [JsonProperty("totalGames")]
        public int totalGames { get; set; }
}

    public class MatchReference
    {
        [JsonProperty("champion")]
        public long champion { get; set; }

        [JsonProperty("lane")]
        public string lane { get; set; }

        [JsonProperty("matchId")]
        public string matchId { get; set; }

        [JsonProperty("platformId")]
        public string platformId { get; set; }

        [JsonProperty("queue")]
        public string queue {get;set; } // teambuilder, ranked5v5, rankedsolo5v5
 

        [JsonProperty("region")]
         public string region { get; set; }

        [JsonProperty("role")]
        public string role { get; set; }

        [JsonProperty("season")]
        public string season { get; set; }

        [JsonProperty("timestamp")]
        public long timestamp { get; set; }
}
}
