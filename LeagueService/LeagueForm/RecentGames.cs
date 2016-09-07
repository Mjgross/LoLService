using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace LeagueForm
{
    public class RecentGames
    {
        [JsonProperty("games")]
        List <Game> Game {get;set;}

        [JsonProperty("summonerId")]
        public long summonerId { get; set; }

    }

   public class Game
    {
        [JsonProperty("championId")]
        public int championId { get; set; }

        [JsonProperty("createDate")]
        public long createDate { get; set; }

        [JsonProperty("fellowPlayers")]
        public List<Player> fellowPlayers { get; set; }

        [JsonProperty("gameId")]
        public long gameId{ get; set; }

        [JsonProperty("gameMode")]
        public string gameMode { get; set; }

        [JsonProperty("gameType")]
        public int gameType { get; set; }

        [JsonProperty("invalid")]
        public Boolean invalid { get; set; }

        [JsonProperty("level")]
        public int level { get; set; }

        [JsonProperty("ipEarned")]
        public int ipEarned { get; set; }

        [JsonProperty("mapId")]
        public int mapId { get; set; }

        [JsonProperty("spell1")]
        public int spell1 { get; set; }

        [JsonProperty("spell2")]
        public int spell2 { get; set; }

        [JsonProperty("stats")]
        public List<RawStats> Rawstats { get; set; }

        [JsonProperty("subType")]
        public string subType { get; set; }

        [JsonProperty("teamId")]
        public int teamId { get; set; }

    }

    public class Player
    {
        [JsonProperty("championId")]
        public int championId { get; set; }

        [JsonProperty("summonerId")]
        public long summonerId { get; set; }

        [JsonProperty("teamId")]
        public int teamId { get; set; }
    }

    public class RawStats
    {
        [JsonProperty("assists")]
        public int assists { get; set; }
    }
}
