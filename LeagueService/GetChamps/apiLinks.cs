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
        public const string api_key = "";

        //stats links
        public const string rankedURL = "/v1.3/stats/by-summoner/{0}/ranked";

        //recent link
        public const string recentURL = "/v1.3/game/by-summoner/{0}/recent";
        //Summoner links
        public const string summaryURL = "/v1.3/stats/by-summoner/{0}/summary";

        public const string summonerNameURL = "/v1.4/summoner/by-name/{0}";

        public const string summonerMasteryURL = "/v1.4/summoner/{0}/masteries";

        public const string summonerRunesURL = "/v1.4/summoner/{0}/runes";

        //may need fixing
        //champion master links
        //0 -> playerID
        //1 -> championID
        public const string championMasteryURL = "/championmastery/location/NA1/player/{0}/champion/{1}"; 

        public const string totalMasteryScoreURL = "/championmastery/location/NA1/player{0}/score";

        public const string championMasteriesURL = "/championmaster/location/NA1/player/{0}/champions";

        public const string topChampionsURL = "/championmaster/location/NA1/player/{0}/topchampions";  // /{count} gives optional # of entries to retrieve(default = 3)
    }
}