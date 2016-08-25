using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace GetChamps
{
    public class Champ
    {
            [JsonProperty()]
            public int id { get; set; }

            public int totalDeaths { get; set; }

            public int totalDamageTaken { get; set; }

            public Int32 shit { get; set; }

        }
    }