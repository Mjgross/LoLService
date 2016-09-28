using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Webs
{
    public class Ranked
    {
        [JsonProperty("champions")]
        public List<ChampionStats> ChampionStats{ get; set;}
        [JsonProperty("modifyDate")]
        public long modifyDate { get; set; }
        [JsonProperty("summonerId")]
        public long summonerId { get; set; }
    }

    public class ChampionStats
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("stats")]
        public AggregatedStats aggregatedStats { get; set; }
    }

    public class Champs
    {
        [JsonProperty("maxNumDeaths")]
        public int MaxNumDeaths { get; set; }

        [JsonProperty("totalDeathsPerSession")]
        public int TotalDeathsPerSession { get; set; }
    }
}
