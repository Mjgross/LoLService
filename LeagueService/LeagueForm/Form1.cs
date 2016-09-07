using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeagueForm.ServiceReference1;
using Newtonsoft.Json;
using System.Drawing.Drawing2D;
namespace LeagueForm
{
    public partial class Form1 : Form
    {
        List<string> sum;
        List<string> sum2;
        public Form1()
        {
            InitializeComponent();

            //transparency setup
            //label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
           // label3.Parent = pictureBox2;
            label3.BackColor = Color.Transparent;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text.ToString()))
            {
                //sum.Clear();
                ServiceReference1.IService1 serv = new ServiceReference1.Service1Client();
                sum = new List<string>();
                sum = serv.update(textBox1.Text.ToString()).ToList();
                deserialize(sum);
            }
        }

        //Deserialize Function
        private void deserialize(List<string> sum)
        {
            //Summoner Data
            var summonData = JsonConvert.DeserializeObject<Dictionary<string, Summoner>>(sum[0]);
            //Summoner Masteries
            var summonMastery = JsonConvert.DeserializeObject<Dictionary<string,MasteryPages>>(sum[1]);
            //Summoner Runes
            var summonRunes = JsonConvert.DeserializeObject<Dictionary<string, RunePages>>(sum[2]);
            //Ranked Stats
            var summonRanked = JsonConvert.DeserializeObject<Ranked>(sum[3]);
            //Recent stats

            //DISPLAY

            //Sum name
            label1.Text = summonData.First().Value.name;
            //Sum Rank
            label2.Text = "rank: " + summonData.First().Value.summonerLevel;
            //summon Icon
            string iconURL = String.Format(summonData.First().Value.iconURL, summonData.First().Value.name.Replace(" ", ""));
            pictureBox1.Load(iconURL);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text.ToString()))
            {
                //sum2.Clear();
                ServiceReference1.IService1 serv = new ServiceReference1.Service1Client();
                sum2 = new List<string>();
                sum2 = serv.update(textBox2.Text.ToString()).ToList();
                deserialize2(sum2);
            }
        }
        private void deserialize2(List<string> sum)
        {
            //Summoner Data
            var summonData = JsonConvert.DeserializeObject<Dictionary<string, Summoner>>(sum[0]);
            //Summoner Masteries
            var summonMastery = JsonConvert.DeserializeObject<Dictionary<string, MasteryPages>>(sum[1]);
            //Summoner Runes
            var summonRunes = JsonConvert.DeserializeObject<Dictionary<string, RunePages>>(sum[2]);

            //DISPLAY

            //Sum name
            label4.Text = summonData.First().Value.name;
            //Sum Rank
            label3.Text = "rank: " + summonData.First().Value.summonerLevel;
            //summon Icon
            string iconURL = String.Format(summonData.First().Value.iconURL, summonData.First().Value.name);
            pictureBox2.Load(iconURL);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
 
        }


        private void grabChampInfo(List<string> summ, int id, int summm)
        {
            int idNum = 0 ;

            //SUMMONER 1
            if (summm == 1)
            {
                var champ = JsonConvert.DeserializeObject<Ranked>(sum[3]);
                for (int i = 0; i < champ.ChampionStats[i].id; i++)
                {
                    if (id == champ.ChampionStats[i].id)
                    {
                        idNum = i;
                        break;
                    }

                }
                //KDA
                double champ_ASSIST =  Convert.ToDouble(champ.ChampionStats[idNum].aggregatedStats.totalAssists);
                double champ_KILLS =   Convert.ToDouble(champ.ChampionStats[idNum].aggregatedStats.totalChampionKills);
                double champ_DEATHS =  Convert.ToDouble(champ.ChampionStats[idNum].aggregatedStats.totalDeathsPerSession);
                double champ_PLAYED =  Convert.ToDouble(champ.ChampionStats[idNum].aggregatedStats.totalSessionsPlayed);
                
                double champ_ASSIST_AVG     =       (champ_ASSIST / champ_PLAYED);
                double champ_KILLS_AVG      =       (champ_KILLS  / champ_PLAYED);
                double champ_DEATHS_AVG     =       (champ_DEATHS / champ_PLAYED);
                double champ_KDA = Math.Round((champ_KILLS_AVG + champ_ASSIST_AVG) / champ_DEATHS_AVG, 1);

                leftKDA.Text = "avg KDA: " + champ_KDA.ToString();
                string champ_DEATHS_AVG_col = champ_DEATHS_AVG.ToString("#.##");

                leftKDAcolor.Text = champ_KILLS_AVG.ToString("#.##") + " / " + champ_DEATHS_AVG_col + " / " + champ_ASSIST_AVG.ToString("#.##");
                leftKDAcolor.Select(7, 4);
                leftKDAcolor.SelectionColor = Color.Red;

  
                //change color depending if good/bad


                graph1(summ, idNum, 1);
                recentGame(summ, idNum, 1);
            }

            //SUMMONER 2
            else if (summm == 2)
            {
                var champ = JsonConvert.DeserializeObject<Ranked>(sum2[3]);
                for (int i = 0; i < champ.ChampionStats[i].id; i++)
                {
                    if (id == champ.ChampionStats[i].id)
                    {
                        idNum = i;
                        break;
                    }
                }
                    //KDA
                    double champ_ASSIST2 = Convert.ToDouble(champ.ChampionStats[idNum].aggregatedStats.totalAssists);
                    double champ_KILLS2 = Convert.ToDouble(champ.ChampionStats[idNum].aggregatedStats.totalChampionKills);
                    double champ_DEATHS2 = Convert.ToDouble(champ.ChampionStats[idNum].aggregatedStats.totalDeathsPerSession);
                    double champ_PLAYED2 = Convert.ToDouble(champ.ChampionStats[idNum].aggregatedStats.totalSessionsPlayed);

                    double champ_ASSIST_AVG2 = (champ_ASSIST2 / champ_PLAYED2);
                    double champ_KILLS_AVG2 = (champ_KILLS2 / champ_PLAYED2);
                    double champ_DEATHS_AVG2 = (champ_DEATHS2 / champ_PLAYED2);
                    double champ_KDA2 = Math.Round((champ_KILLS_AVG2 + champ_ASSIST_AVG2) / champ_DEATHS_AVG2, 1);

                    rightKDA.Text = "avg KDA: " + champ_KDA2.ToString();
                    string champ_DEATHS_AVG_col2 = champ_DEATHS_AVG2.ToString("#.##");

                    rightKDAcolor.Text = champ_KILLS_AVG2.ToString("#.##") + " / " + champ_DEATHS_AVG_col2 + " / " + champ_ASSIST_AVG2.ToString("#.##");
                    rightKDAcolor.Select(7, 4);
                    rightKDAcolor.SelectionColor = Color.Red;


                    graph1(summ, idNum, 2);
                

  

            }
        }

        private void graph1(List<string> summ, int champID, int sumNum)
        {
            string chartSumID = "Summoner" + sumNum;
            var champ = JsonConvert.DeserializeObject<Ranked>(summ[3]);
            chart1.Series[chartSumID].Points.AddXY("Total Damage Dealth", champ.ChampionStats[champID].aggregatedStats.totalDamageDealt);
            chart1.Series[chartSumID].Points.AddXY("Total Damage Taken", champ.ChampionStats[champID].aggregatedStats.totalDamageTaken);
            chart1.Series[chartSumID].Points.AddXY("Total Gold Earned", champ.ChampionStats[champID].aggregatedStats.totalGoldEarned);
            chart1.Series[chartSumID].Points.AddXY("Max Time PLayed", champ.ChampionStats[champID].aggregatedStats.maxTimePlayed);
            //update champ 2
        }

        private void recentGame(List<string> summ, int champID, int sumNum)
        {
            var champ = JsonConvert.DeserializeObject<Ranked>(summ[4]);
        }
        private void champBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string champ = (champBox1.SelectedItem.ToString()).Replace(" ", "");
            if (champ.Equals("wukong", StringComparison.InvariantCultureIgnoreCase))
            {
                champ = "MonkeyKing";
            }
            string url = "http://ddragon.leagueoflegends.com/cdn/5.2.1/img/champion/" + champ + ".png";
            pictureBox3.Load(url); //CAPS MATTERS
            //wukong = MoneyKing
            int champId = (int)Enum.Parse(typeof(Champions.ChampID), champ);
            try {
                grabChampInfo(sum, champId, 1); //summoner 1
                grabChampInfo(sum2, champId, 2); //summoner2
            }
            catch
            {
                MessageBox.Show("Error: Summoner Data not found.");
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
