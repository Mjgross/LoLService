using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Webs
{
    public class updateDB
    {

        public bool updateSummoner(List<string> summoner)
        {
            //VARIABLES USED
            string summonerName;
            string summonerId;
            string profileIcon;
            string summonerLevel;
            string revisionData;
            string query;
            bool found_in_database = false;
            bool update_failed = false;

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

            query = "INSERT INTO summoner(summonerName, summonerId, profileIcon, summonerLevel, revisionData) " +
                            "VALUE ("
                            + summonerName + ","
                            + summonerId + ","
                            + profileIcon + ","
                            + summonerLevel + ","
                            + revisionData + ");";

            //Attempt to update the Database
            //if the update fails (duplicate or invalid entry)
            //then pulling the summoner information from the
            //database should occur
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteScalar();
                conn.Close();
                return true;
            }
            catch
            {
                update_failed = true;
            }

            if(update_failed)
            {
                query = "UPDATE summoner SET " 
                + "profileIcon=" +profileIcon + ","
                + "summonerLevel=" +summonerLevel + ","
                + "revisionData="  +revisionData  
                +" WHERE summonerId="
                + summonerId + ";";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteScalar();
                    conn.Close();
                    return true;
                }
                catch
                {
                    //cant update
                }
                conn.Close();
                update_failed = false;
            }
            return found_in_database;
        }

        public bool AddSummonerToDB(string id)
        {
            string query;

            //DB members
            string summonerName;
            string summonerId;
            string profileIcon;
            string summonerLevel;
            string revisionData;
            mysql sql = new mysql();
            MySql.Data.MySqlClient.MySqlConnection conn = sql.mysql_Connection();
            //Query the Database to grab the user information
            try
            {
                query = "SELECT * FROM summoner WHERE summonerName="
                      + "'" + id + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
               MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    summonerName = reader.GetString(reader.GetOrdinal("summonerName")).ToLower();
                    summonerId = reader.GetString(reader.GetOrdinal("summonerId"));
                    profileIcon = reader.GetString(reader.GetOrdinal("profileIcon"));
                    summonerLevel = reader.GetString(reader.GetOrdinal("summonerLevel"));
                    revisionData = reader.GetString(reader.GetOrdinal("revisionData"));
                }
            }
            catch
            {
                //if it does not work then update the DB
            }
            return true;

        }

        public bool check_Summoner_DB(string username)
        {
            string query;
            mysql sql = new mysql();
            MySql.Data.MySqlClient.MySqlConnection conn = sql.mysql_Connection();

            try
            {
                query = "SELECT * FROM summoner WHERE summonerName="
                      + "'" + username + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    return true;
                else
                    return false;

                
            }
            catch
            {
                return false;
            }
        }
    }
}