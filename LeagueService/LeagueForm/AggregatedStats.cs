using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace LeagueForm
{
    public class AggregatedStats
    {
        //skipped some of the stats
        //only taking into effect the ones i need
        internal AggregatedStats() { }
        [JsonProperty("killingSpree")]
        public int killingSpree { get; set; }

        [JsonProperty("totalChampionKills")]
        public int totalChampionKills { get; set; }

        [JsonProperty("maxLargestKillingSpree")]
        public int maxLargestKillingSpree { get; set; }

        [JsonProperty("maxTimePlayed")]
        public int maxTimePlayed { get; set; }

        [JsonProperty("maxTimeSpentLiving")]
        public int maxTimeSpentLiving { get; set; }

        [JsonProperty("mostChampionKillsPerSession")]
        public int mostChampionKillsPerSession { get; set; }

        [JsonProperty("normalGamesPlayed")]
        public int normalGamesPlayed { get; set; }

        [JsonProperty("rankedPremadeGamesPlayed")]
        public int rankedPremadeGamesPlayed { get; set; }


        [JsonProperty("rankedSoloGamesPlayed")]
        public int rankedSoloGamesPlayed { get; set; }

        [JsonProperty("totalAssists")]
        public int totalAssists { get; set; }

        [JsonProperty("totalDamageDealt")]
        public int totalDamageDealt { get; set; }

        [JsonProperty("totalDamageTaken")]
        public int totalDamageTaken { get; set; }

        [JsonProperty("totalDeathsPerSession")]
        public int totalDeathsPerSession { get; set; }

        [JsonProperty("totalDoubleKills")]
        public int totalDoubleKills { get; set; }

        [JsonProperty("totalFirstBlood")]
        public int totalFirstBlood { get; set; }

        [JsonProperty("totalGoldEarned")]
        public int totalGoldEarned { get; set; }

        [JsonProperty("totalHeal")]
        public int totalHeal { get; set; }

        [JsonProperty("totalMagicDamageDealt")]
        public int totalMagicDamageDealth { get; set; }

        [JsonProperty("totalMinionKills")]
        public int totalMinionKills { get; set; }

        [JsonProperty("totalNeutralMinionsKilled")]
        public int totalNeutralMinionsKilled { get; set; }

        [JsonProperty("totalPentaKills")]
        public int totalPentaKills { get; set; }

        [JsonProperty("totalPhysicalDamageDealt")]
        public int totalPhysicalDamageDealth { get; set; }

        [JsonProperty("totalQuadraKills")]
        public int totalQuadraKills { get; set; }

        [JsonProperty("totalSessionsPlayed")]
        public int totalSessionsPlayed { get; set; }

        [JsonProperty("totalSessionsWon")]
        public int totalSessionsWon { get; set; }

        [JsonProperty("totalSessionsLost")]
        public int totalSessionsLost { get; set; }

        [JsonProperty("totalTripleKills")]
        public int totalTripleKills { get; set; }

        [JsonProperty("totalTurretsKilled")]
        public int totalTurretsKilled { get; set; }

        [JsonProperty("totalUnrealKills")]
        public int totalUnrealKills { get; set; }

        [JsonProperty("maxNumDeaths")]
        public int maxNumDeaths { get; set; }
    }
}