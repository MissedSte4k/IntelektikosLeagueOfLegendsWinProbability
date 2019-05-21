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

        public const int MaxTime = 16;
        public const int LearnData = 1000;
        List<List<int>> fullList = new List<List<int>>();
        List<Dictionary<int, Dictionary<int, Instant>>> visas = new List<Dictionary<int, Dictionary<int, Instant>>>();
        public const int MaxNumberOfNormalizedData = 57;
        public int WinCount = 0;
        public int DefeatCount = 0;
        public double pirmas = 0.5;


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
            var Data = ReadLinesAsString();
            
            for (int o = 1; o <= 10; o++)
            {
                WinCount = 0;
                DefeatCount = 0;
                visas = new List<Dictionary<int, Dictionary<int, Instant>>>();
                for (int i = 0; i < MaxNumberOfNormalizedData; i++)//kintamuju skaicius
                {
                    Dictionary<int, Dictionary<int, Instant>> a = new Dictionary<int, Dictionary<int, Instant>>();
                    for (int j = 0; j < MaxTime; j++)//laiko intervalai
                    {
                        Dictionary<int, Instant> b = new Dictionary<int, Instant>();
                        a.Add(j, b);
                    }
                    visas.Add(a);
                }
                ApsimokykBajes(Data, o);
                addProbab(visas);
                
            }
        }


        static double P(List<double> topas)
        {
            double virsus = 1;
            double apacia2 = 1;
            foreach (double top in topas)
            {
                virsus = (double)virsus * top;
                apacia2 = (double)apacia2 * (1 - top);
            }

            return (double)(virsus / (virsus + apacia2));

        }
       

        public double chekWinProb(int eile, int variable, int time)
        {
            if(visas[eile][SplitTime(time)].ContainsKey(variable))
            {
                return visas[eile][SplitTime(time)].Single(e => e.Key == variable).Value.tikimybe;
            }
            else
            return pirmas;

        }


        public int SplitTime(int time)
        {
            for (int i = 1; i <= MaxTime; i++)
            {
                if(time/60 < (i * 5) )
                {
                    return i-1;
                }
            }
            return 0;

        }

        public void ApsimokykBajes(List<string> list, int o)
        {
            fullList = new List<List<int>>();
            string line = null;
            for (int i = 0; i < list.Count; i++)
            {
                line = list[i];
                string[] values = line.Split(',');
                if (i >= (o * LearnData / 10) || i < ((o - 1) * LearnData / 10))
                {
                    int j = 0;

                    for (int l = 5; l < MaxNumberOfNormalizedData; l++)
                    {
                        visas = add(j, int.Parse(values[2]), int.Parse(values[l]), int.Parse(values[4]), visas);
                        j++;
                        if(int.Parse(values[4]) == 1)
                        {
                            WinCount++;
                        }
                        else
                            DefeatCount++;
                    }
                }
                else
                {
                    List<int> intList = new List<int>();
                    intList.Add(int.Parse(values[2]));
                    intList.Add(int.Parse(values[3]));
                    intList.Add(int.Parse(values[4]));
                    intList.Add(int.Parse(values[5]));
                    intList.Add(int.Parse(values[6]));
                    intList.Add(int.Parse(values[7]));
                    intList.Add(int.Parse(values[8]));
                    intList.Add(int.Parse(values[9]));
                    intList.Add(int.Parse(values[10]));
                    intList.Add(int.Parse(values[11]));
                    intList.Add(int.Parse(values[12]));
                    intList.Add(int.Parse(values[13]));
                    intList.Add(int.Parse(values[14]));
                    intList.Add(int.Parse(values[15]));
                    intList.Add(int.Parse(values[16]));
                    intList.Add(int.Parse(values[17]));
                    intList.Add(int.Parse(values[18]));
                    intList.Add(int.Parse(values[19]));
                    intList.Add(int.Parse(values[20]));
                    intList.Add(int.Parse(values[21]));
                    intList.Add(int.Parse(values[22]));
                    intList.Add(int.Parse(values[23]));
                    intList.Add(int.Parse(values[24]));
                    intList.Add(int.Parse(values[25]));
                    intList.Add(int.Parse(values[26]));
                    intList.Add(int.Parse(values[27]));
                    intList.Add(int.Parse(values[28]));
                    intList.Add(int.Parse(values[29]));
                    intList.Add(int.Parse(values[30]));
                    intList.Add(int.Parse(values[31]));
                    intList.Add(int.Parse(values[32]));
                    intList.Add(int.Parse(values[33]));
                    intList.Add(int.Parse(values[34]));
                    intList.Add(int.Parse(values[35]));
                    intList.Add(int.Parse(values[36]));
                    intList.Add(int.Parse(values[37]));
                    intList.Add(int.Parse(values[38]));
                    intList.Add(int.Parse(values[39]));
                    intList.Add(int.Parse(values[40]));
                    intList.Add(int.Parse(values[41]));
                    intList.Add(int.Parse(values[42]));
                    intList.Add(int.Parse(values[43]));
                    intList.Add(int.Parse(values[44]));
                    intList.Add(int.Parse(values[45]));
                    intList.Add(int.Parse(values[46]));
                    intList.Add(int.Parse(values[47]));
                    intList.Add(int.Parse(values[48]));
                    intList.Add(int.Parse(values[49]));
                    intList.Add(int.Parse(values[50]));
                    intList.Add(int.Parse(values[51]));
                    intList.Add(int.Parse(values[52]));
                    intList.Add(int.Parse(values[53]));
                    intList.Add(int.Parse(values[54]));
                    intList.Add(int.Parse(values[55]));
                    intList.Add(int.Parse(values[56]));
                    intList.Add(int.Parse(values[57]));
                    intList.Add(int.Parse(values[58]));
                    intList.Add(int.Parse(values[59]));
                    intList.Add(int.Parse(values[60]));

                    fullList.Add(intList);
                }
            }
            
        }
        

        public List<Dictionary<int, Dictionary<int, Instant>>> addProbab(List<Dictionary<int, Dictionary<int, Instant>>> visas)
        {
            foreach(Dictionary<int, Dictionary<int, Instant>> dict in visas)
            {
                foreach (var item in dict.Values)
                {
                    foreach (Instant instant in item.Values)
                    {
                        double ws = (double) instant.t1_win / WinCount;
                        double wh = (double) instant.t2_win / DefeatCount;
                        double tik = (double)ws / (ws + wh);
                        if (ws == 0)
                        {
                            tik = 0.01;
                        }
                        if (wh == 0)
                        {
                            tik = 0.99;
                        }
                        instant.tikimybe = tik;
                    }
                }
            }
            return visas;
        }

        public List<Dictionary<int, Dictionary<int, Instant>>> add(int eile, int time, int variable, int win, List<Dictionary<int, Dictionary<int, Instant>>> visas)
        {
            if (visas[eile][SplitTime(time)].ContainsKey(variable))
            {
                if (win == 1)
                    visas[eile][SplitTime(time)].Single(e => e.Key == variable).Value.t1_win++;
                else visas[eile][SplitTime(time)].Single(e => e.Key == variable).Value.t2_win++;
            }
            else
            {
                Instant a = new Instant() { t1_win = 0, t2_win = 0, tikimybe = 0 };
                if (win == 1)
                    a.t1_win++;
                else
                    a.t2_win++;
                visas[eile][SplitTime(time)].Add(variable, a);
            }
            return visas;
        }
        public List<string> ReadLinesAsString()
        {
            List<string> temp = new List<string>();

            using (StreamReader reader = new StreamReader(file))
            {
                string line = null;
                line = reader.ReadLine();

                for (int i = 0; i < LearnData; i++)
                {
                    temp.Add(reader.ReadLine());
                }
            }

            return temp;
        }

        public List<List<int>> ReadLinesAsInt()
        {
            List<List<int>> fullList = new List<List<int>>();

            using (StreamReader reader = new StreamReader(file))
            {
                string line = null;
                line = reader.ReadLine();

                List<int> intList = new List<int>();

                while (null != (line = reader.ReadLine()))
                {
                    string[] values = line.Split(';');
                    intList.Add(int.Parse(values[2]));
                    intList.Add(int.Parse(values[3]));
                    intList.Add(int.Parse(values[4]));
                    intList.Add(int.Parse(values[5]));
                    intList.Add(int.Parse(values[6]));
                    intList.Add(int.Parse(values[7]));
                    intList.Add(int.Parse(values[8]));
                    intList.Add(int.Parse(values[9]));
                    intList.Add(int.Parse(values[10]));
                    intList.Add(int.Parse(values[11]));
                    intList.Add(int.Parse(values[12]));
                    intList.Add(int.Parse(values[13]));
                    intList.Add(int.Parse(values[14]));
                    intList.Add(int.Parse(values[15]));
                    intList.Add(int.Parse(values[16]));
                    intList.Add(int.Parse(values[17]));
                    intList.Add(int.Parse(values[18]));
                    intList.Add(int.Parse(values[19]));
                    intList.Add(int.Parse(values[20]));
                    intList.Add(int.Parse(values[21]));
                    intList.Add(int.Parse(values[22]));
                    intList.Add(int.Parse(values[23]));
                    intList.Add(int.Parse(values[24]));
                    intList.Add(int.Parse(values[25]));
                    intList.Add(int.Parse(values[26]));
                    intList.Add(int.Parse(values[27]));
                    intList.Add(int.Parse(values[28]));
                    intList.Add(int.Parse(values[29]));
                    intList.Add(int.Parse(values[30]));
                    intList.Add(int.Parse(values[31]));
                    intList.Add(int.Parse(values[32]));
                    intList.Add(int.Parse(values[33]));
                    intList.Add(int.Parse(values[34]));
                    intList.Add(int.Parse(values[35]));
                    intList.Add(int.Parse(values[36]));
                    intList.Add(int.Parse(values[37]));
                    intList.Add(int.Parse(values[38]));
                    intList.Add(int.Parse(values[39]));
                    intList.Add(int.Parse(values[40]));
                    intList.Add(int.Parse(values[41]));
                    intList.Add(int.Parse(values[42]));
                    intList.Add(int.Parse(values[43]));
                    intList.Add(int.Parse(values[44]));
                    intList.Add(int.Parse(values[45]));
                    intList.Add(int.Parse(values[46]));
                    intList.Add(int.Parse(values[47]));
                    intList.Add(int.Parse(values[48]));
                    intList.Add(int.Parse(values[49]));
                    intList.Add(int.Parse(values[50]));
                    intList.Add(int.Parse(values[51]));
                    intList.Add(int.Parse(values[52]));
                    intList.Add(int.Parse(values[53]));
                    intList.Add(int.Parse(values[54]));
                    intList.Add(int.Parse(values[55]));
                    intList.Add(int.Parse(values[56]));
                    intList.Add(int.Parse(values[57]));
                    intList.Add(int.Parse(values[58]));
                    intList.Add(int.Parse(values[59]));
                    intList.Add(int.Parse(values[60]));                   
                }

                fullList.Add(intList);
            }

            return fullList;
        }
    }


    
    public class Instant
    {
        public int t1_win { get; set; }
        public int t2_win { get; set; }
        public double tikimybe { get; set; }
    }

   public class NormilizedData
    {
        public int GameDuration { get; set; }
        public int Winner { get; set; }
        public int FirstBlood { get; set; }
        public int FirstTower { get; set; }
        public int FirstInhibitor { get; set; }
        public int FirstBaron { get; set; }
        public int FirstDragon { get; set; }
        public int FirstRiftHerald { get; set; }
        public int t1_towerKill { get; set; }
        public int t1_inhibitorKills { get; set; }
        public int t1_baronKills { get; set; }
        public int t1_dragonKills { get; set; }
        public int t1_riftHeraldKills { get; set; }
        public int t2_towerKill { get; set; }
        public int t2_inhibitorKills { get; set; }
        public int t2_baronKills { get; set; }
        public int t2_dragonKills { get; set; }
        public int t2_riftHeraldKills { get; set; }
        public int t1_champ1id { get; set; }
        public int t1_champ2id { get; set; }
        public int t1_champ3id { get; set; }
        public int t1_champ4id { get; set; }
        public int t1_champ5id { get; set; }
        public int t2_champ1id { get; set; }
        public int t2_champ2id { get; set; }
        public int t2_champ3id { get; set; }
        public int t2_champ4id { get; set; }
        public int t2_champ5id { get; set; }
    }
    


}
