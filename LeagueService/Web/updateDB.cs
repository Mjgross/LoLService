using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Web
{
    public class updateDB
    {

        public void updateSummoner(List<string> summoner)
        {
            //VARIABLES USED
            string summonerName;
            string summonerId;
            string profileIcon;
            string summonerLevel;
            string revisionData;


            mysql sql = new mysql();
            MySql.Data.MySqlClient.MySqlConnection conn = sql.mysql_Connection();
            var summonData = JsonConvert.DeserializeObject<Dictionary<string, Summoner>>(summoner[0]);
            /*********************************
            **********************************
            **      INITIALZING VARIALBES   **
            *********************************/
            summonerName    = "'" +summonData.First().Value.name + "'";
            summonerId      = "'" +summonData.First().Value.id.ToString() + "'";
            profileIcon     =      summonData.First().Value.profileIconId.ToString();
            summonerLevel   = summonData.First().Value.summonerLevel.ToString();
            revisionData    = summonData.First().Value.revisionDate.ToString();


            //summon Icon

            string query = "INSERT INTO summoner(summonerName, summonerId, profileIcon, summonerLevel, revisionData) " +
                            "VALUE ("
                            + summonerName + ","
                            + summonerId + ","
                            + profileIcon + ","
                            + summonerLevel + ","
                            + revisionData + ");";

            DataTable results = new DataTable();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteScalar();
            //string query = "SELECT summonerName,summonerId FROM summoner";
            //var cmd = new MySqlCommand(query, conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //string summonerName;
            //string summonerId;
        }
    }
}