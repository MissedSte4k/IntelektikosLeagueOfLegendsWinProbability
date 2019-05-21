using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Intelektika
{
    public partial class Form1 : Form
    {
        public string file = @"..\Debug\Data\games.csv";

        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
            List<FullData> fullDataList = ReadFile(file);
            
        }

        public List<FullData> ReadFile(string file)
        {
            List<FullData> fullDataList = new List<FullData>();

            using (StreamReader reader = new StreamReader(file))
            {
                string line = null;
                line = reader.ReadLine();

                while (null != (line = reader.ReadLine()))
                {
                    FullData temp = new FullData();

                    string[] values = line.Split(',');
                    temp.GameID = double.Parse(values[0]);
                    temp.CreationTime= double.Parse(values[1]);
                    temp.GameDuration= int.Parse(values[2]);
                    temp.Season= int.Parse(values[3]);
                    temp.Winner= int.Parse(values[4]);
                    temp.FirstBlood= int.Parse(values[5]);
                    temp.FirstTower= int.Parse(values[6]);
                    temp.FirstInhibitor= int.Parse(values[7]);
                    temp.FirstBaron= int.Parse(values[8]);
                    temp.FirstDragon= int.Parse(values[9]);
                    temp.FirstRiftHerald= int.Parse(values[10]);
                    temp.t1_champ1id= int.Parse(values[11]);
                    temp.t1_champ1_sum1= int.Parse(values[12]);
                    temp.t1_champ1_sum2= int.Parse(values[13]);
                    temp.t1_champ2id= int.Parse(values[14]);
                    temp.t1_champ2_sum1= int.Parse(values[15]);
                    temp.t1_champ2_sum2= int.Parse(values[16]);
                    temp.t1_champ3id= int.Parse(values[17]);
                    temp.t1_champ3_sum1= int.Parse(values[18]);
                    temp.t1_champ3_sum2= int.Parse(values[19]);
                    temp.t1_champ4id= int.Parse(values[20]);
                    temp.t1_champ4_sum1= int.Parse(values[21]);
                    temp.t1_champ4_sum2= int.Parse(values[22]);
                    temp.t1_champ5id= int.Parse(values[23]);
                    temp.t1_champ5_sum1= int.Parse(values[24]);
                    temp.t1_champ5_sum2= int.Parse(values[25]);
                    temp.t1_towerKill= int.Parse(values[26]);
                    temp.t1_inhibitorKills= int.Parse(values[27]);
                    temp.t1_baronKills= int.Parse(values[28]);
                    temp.t1_dragonKills= int.Parse(values[29]);
                    temp.t1_riftHeraldKills= int.Parse(values[30]);
                    temp.t1_ban1= int.Parse(values[31]);
                    temp.t1_ban2= int.Parse(values[32]);
                    temp.t1_ban3= int.Parse(values[33]);
                    temp.t1_ban4= int.Parse(values[34]);
                    temp.t1_ban5= int.Parse(values[35]);
                    temp.t2_champ1id= int.Parse(values[36]);
                    temp.t2_champ1_sum1= int.Parse(values[37]);
                    temp.t2_champ1_sum2= int.Parse(values[38]);
                    temp.t2_champ2id= int.Parse(values[39]);
                    temp.t2_champ2_sum1= int.Parse(values[40]);
                    temp.t2_champ2_sum2= int.Parse(values[41]);
                    temp.t2_champ3id= int.Parse(values[42]);
                    temp.t2_champ3_sum1= int.Parse(values[43]);
                    temp.t2_champ3_sum2= int.Parse(values[44]);
                    temp.t2_champ4id= int.Parse(values[45]);
                    temp.t2_champ4_sum1= int.Parse(values[46]);
                    temp.t2_champ4_sum2= int.Parse(values[47]);
                    temp.t2_champ5id= int.Parse(values[48]);
                    temp.t2_champ5_sum1= int.Parse(values[49]);
                    temp.t2_champ5_sum2= int.Parse(values[50]);
                    temp.t2_towerKill= int.Parse(values[51]);
                    temp.t2_inhibitorKills= int.Parse(values[52]);
                    temp.t2_baronKills= int.Parse(values[53]);
                    temp.t2_dragonKills= int.Parse(values[54]);
                    temp.t2_riftHeraldKills= int.Parse(values[55]);
                    temp.t2_ban1= int.Parse(values[56]);
                    temp.t2_ban2= int.Parse(values[57]);
                    temp.t2_ban3= int.Parse(values[58]);
                    temp.t2_ban4= int.Parse(values[59]);
                    temp.t2_ban5= int.Parse(values[60]);

                    fullDataList.Add(temp);
                }
            }
            return fullDataList;
        }
    }

    //public class 
    public class FullData
    {
        public double GameID { get; set; }
        public double CreationTime { get; set; }
        public int GameDuration { get; set; }
        public int Season { get; set; }
        public int Winner { get; set; }
        public int FirstBlood { get; set; }
        public int FirstTower { get; set; }
        public int FirstInhibitor { get; set; }
        public int FirstBaron { get; set; }
        public int FirstDragon { get; set; }
        public int FirstRiftHerald { get; set; }
        public int t1_champ1id { get; set; }
        public int t1_champ1_sum1 { get; set; }
        public int t1_champ1_sum2 { get; set; }
        public int t1_champ2id { get; set; }
        public int t1_champ2_sum1 { get; set; }
        public int t1_champ2_sum2 { get; set; }
        public int t1_champ3id { get; set; }
        public int t1_champ3_sum1 { get; set; }
        public int t1_champ3_sum2 { get; set; }
        public int t1_champ4id { get; set; }
        public int t1_champ4_sum1 { get; set; }
        public int t1_champ4_sum2 { get; set; }
        public int t1_champ5id { get; set; }
        public int t1_champ5_sum1 { get; set; }
        public int t1_champ5_sum2 { get; set; }
        public int t1_towerKill { get; set; }
        public int t1_inhibitorKills { get; set; }
        public int t1_baronKills { get; set; }
        public int t1_dragonKills { get; set; }
        public int t1_riftHeraldKills { get; set; }
        public int t1_ban1 { get; set; }
        public int t1_ban2 { get; set; }
        public int t1_ban3 { get; set; }
        public int t1_ban4 { get; set; }
        public int t1_ban5 { get; set; }
        public int t2_champ1id { get; set; }
        public int t2_champ1_sum1 { get; set; }
        public int t2_champ1_sum2 { get; set; }
        public int t2_champ2id { get; set; }
        public int t2_champ2_sum1 { get; set; }
        public int t2_champ2_sum2 { get; set; }
        public int t2_champ3id { get; set; }
        public int t2_champ3_sum1 { get; set; }
        public int t2_champ3_sum2 { get; set; }
        public int t2_champ4id { get; set; }
        public int t2_champ4_sum1 { get; set; }
        public int t2_champ4_sum2 { get; set; }
        public int t2_champ5id { get; set; }
        public int t2_champ5_sum1 { get; set; }
        public int t2_champ5_sum2 { get; set; }
        public int t2_towerKill { get; set; }
        public int t2_inhibitorKills { get; set; }
        public int t2_baronKills { get; set; }
        public int t2_dragonKills { get; set; }
        public int t2_riftHeraldKills { get; set; }
        public int t2_ban1 { get; set; }
        public int t2_ban2 { get; set; }
        public int t2_ban3 { get; set; }
        public int t2_ban4 { get; set; }
        public int t2_ban5 { get; set; }
    }


}
