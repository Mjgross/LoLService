using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace GetChamps
{
    public class ChampList
    {
        [JsonProperty("champions")]
        public List<Champ> Champs { get; set; }
    }
}