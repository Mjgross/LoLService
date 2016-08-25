using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetChamps
{
    public class apiLinks
    {

        //root
        public const string root = "https://na.api.pvp.net/api/lol/na";

        //Access Links for all of the APIs
        public const string api_key ="?api_key=RGAPI-F8054BA6-CF6D-4C86-990E-ED29A8836C37";

        //stats links
        public const string rankedURL = "/v1.3/stats/by-summoner/{0}/ranked";
 
        //Summoner links
        public const string summaryURL = "/v1.3/stats/by-summoner/{0}/summary";

        public const string summonerNameURL = "/v1.4/summoner/by-name/{0}";

        public const string summonerMasteryURL = "/v1.4/summoner/by-name/{0}";

        public const string summonerRunesURL = "/v1.4/summoner/{0}/runes";

        //may need fixing
        //champion master links
        public const string championMasteryURL = "/championmastery/location/na/player/{playerId}/champion/{championId}";

        public const string scoreURL = "/championmastery/location/na/player{playerId}/score";

        public const string totalChampionMasteryURL = "/championmaster/location/na/player/{playerId}/champions";
    }
}