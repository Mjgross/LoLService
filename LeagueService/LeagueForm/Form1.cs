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
namespace LeagueForm
{
    public partial class Form1 : Form
    {
        List<string> sum;
        List<string> sum2;
        public Form1()
        {
            InitializeComponent();
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
            string iconURL = String.Format(summonData.First().Value.iconURL, summonData.First().Value.name);
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
            if (!string.IsNullOrWhiteSpace(textBox3.Text.ToString()))
            {
                string champ = textBox3.Text.ToString();
                champ = champ.First().ToString().ToUpper() + champ.Substring(1);

                updateChamp(champ);
            }
        }

        private void updateChamp(string champ)
        {
            if(champ.Equals("wukong", StringComparison.InvariantCultureIgnoreCase))
            {
                champ = "MonkeyKing";
            }
            string url = "http://ddragon.leagueoflegends.com/cdn/5.2.1/img/champion/" + champ + ".png";
            pictureBox3.Load(url); //CAPS MATTERS
            //wukong = MoneyKing
            int champId = (int)Enum.Parse(typeof(Champions.ChampID), champ);
            grabChampInfo(sum, champId, 0); //summoner 1
            grabChampInfo(sum2, champId, 1); //summoner2
        }
        private void grabChampInfo(List<string> summ, int id, int summm)
        {
            int idNum = 0 ;

            if (summm == 0)
            {
                var champ = JsonConvert.DeserializeObject<Ranked>(sum[3]);
                for (int i = 0; i < champ.ChampionStats[i].id; i++)
                {
                    if (id == champ.ChampionStats[i].id)
                    {
                        idNum = i;
                    }

                }
                label5.Text = "total Damage Dealt: " + champ.ChampionStats[idNum].aggregatedStats.totalDamageDealt;
                label6.Text = "total Damage Taken: " + champ.ChampionStats[idNum].aggregatedStats.totalDamageTaken;
                label7.Text = "total Deaths: " + champ.ChampionStats[idNum].aggregatedStats.totalDeathsPerSession;
                label8.Text = "total Gold Earned: " + champ.ChampionStats[idNum].aggregatedStats.totalGoldEarned;

                //update chart
                chart1.Series["Summoner1"].Points.AddXY("Total Damage", champ.ChampionStats[idNum].aggregatedStats.totalDamageDealt);
                chart1.Series["Summoner1"].Points.AddXY("Damage Taken", champ.ChampionStats[idNum].aggregatedStats.totalDamageTaken);
            }
            else if (summm == 1)
            {
                var champ = JsonConvert.DeserializeObject<Ranked>(sum2[3]);
                for (int i = 0; i < champ.ChampionStats[i].id; i++)
                {
                    if (id == champ.ChampionStats[i].id)
                    {
                        idNum = i;
                    }
                }
                label12.Text = "total Damage Dealt: " + champ.ChampionStats[idNum].aggregatedStats.totalDamageDealt;
                label11.Text = "total Damage Taken: " + champ.ChampionStats[idNum].aggregatedStats.totalDamageTaken;
                label10.Text = "total Deaths: " + champ.ChampionStats[idNum].aggregatedStats.totalDeathsPerSession;
                label9.Text = "total Gold Earned: " + champ.ChampionStats[idNum].aggregatedStats.totalGoldEarned;
                chart1.Series["Summoner2"].Points.AddXY("Total Damage", champ.ChampionStats[idNum].aggregatedStats.totalDamageDealt);
                chart1.Series["Summoner2"].Points.AddXY("Damage Taken", champ.ChampionStats[idNum].aggregatedStats.totalDamageTaken);
            }
        }
    }
}
