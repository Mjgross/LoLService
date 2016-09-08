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
        List<Game> Games {get;set;}

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

        //[JsonProperty("gameType")]
        //public int gameType { get; set; }

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
        public RawStats Rawstats { get; set; }

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

        [JsonProperty("barracksKilled")]
        public int barracksKilled { get; set; }

        [JsonProperty("bountyLevel")]
        public int bountylevel { get; set; }

        [JsonProperty("championsKilled")]
        public int championsKilled { get; set; }

        [JsonProperty("combatPlayerScore")]
        public int combatPlayerscore { get; set; }

        [JsonProperty("consumablesPurchased")]
        public int consumablesPurchased { get; set; }

        [JsonProperty("damageDealtPlayer")]
        public int damageDealtPlayer { get; set; }

        [JsonProperty("doubleKills")]
        public int doubleKills { get; set; }

        [JsonProperty("firstBlood")]
        public int firstBlood { get; set; }

        [JsonProperty("gold")]
        public int gold { get; set; }

        [JsonProperty("goldEarned")]
        public int goldEarned { get; set; }

        [JsonProperty("goldSpent")]
        public int goldSpent { get; set; }

        [JsonProperty("item0")]
        public int item0 { get; set; }

        [JsonProperty("item1")]
        public int item1 { get; set; }

        [JsonProperty("item2")]
        public int item2 { get; set; }

        [JsonProperty("item3")]
        public int item3 { get; set; }

        [JsonProperty("item4")]
        public int item4 { get; set; }

        [JsonProperty("item5")]
        public int item5 { get; set; }

        [JsonProperty("item6")]
        public int item6 { get; set; }

        [JsonProperty("itemsPurchased")]
        public int itemsPurchased{ get; set; }

        [JsonProperty("killingSprees")]
        public int killingSprees { get; set; }

        [JsonProperty("largestCriticalStrike")]
        public int largestCriticalStrike { get; set; }

        [JsonProperty("largestMultiKill")]
        public int largestMultiKill { get; set; }

        [JsonProperty("legendaryItemsCreated")]
        public int legendaryItemsCreated { get; set; }

        [JsonProperty("level")]
        public int level { get; set; }

        [JsonProperty("magicDamageDealtPlayer")]
        public int magicDamageDealtPlayer { get; set; }

        [JsonProperty("magicDamageDealtToChampions")]
        public int magicDamageDealtToChampions { get; set; }

        [JsonProperty("magicDamageTaken")]
        public int magicDamageTaken { get; set; }

        [JsonProperty("minionsDenied")]
        public int minionsDenied { get; set; }

        [JsonProperty("minionsKilled")]
        public int minionsKilled { get; set; }

        [JsonProperty("neutralMinionsKilled")]
        public int neutralMinionsKilled { get; set; }

        [JsonProperty("neutralMinionsKilledEnemyJungle")]
        public int neutralMinionsKilledEnemyJungle { get; set; }

        [JsonProperty("neutralMinionsKilledYourJungle")]
        public int neutralMinionsKilledYourJungle { get; set; }


    }
}
