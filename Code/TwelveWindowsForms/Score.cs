using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using Twelve.GameEngine;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TwelveWindowsForms
{
 
    public partial class frmScore : Form
    {
        [Serializable]
        public struct Player
        {
            public string name;
            public string score;
            public string higher;
            public string time;
            public GameMode mode;
            public Player(string n, string s, string h, string t, GameMode m)
            {
                name = n;
                score = s;
                higher = h;
                time = t;
                mode = m;
            }
            
        }

        [Serializable]
        struct Score
        {
            public List<Player> Players;
            public int countNormalMode;
            public int countAggressiveMode;
            
        }

        Score GameScore;
        RowComparer Comparer = new RowComparer();
        //SoundPlayer player = new SoundPlayer();
        
        public Player BestPlayerNormal = new Player();
        public Player BestPlayerAggressive = new Player();

        public frmScore()
        {
            
            InitializeComponent();
            GameScore = new Score();
            GameScore.Players = new List<Player>();
            GameScore.countAggressiveMode = 0;
            GameScore.countNormalMode = 0;
           

            if (LoadData())
            {
                string[] data;
                for (int i = 0; i < GameScore.countAggressiveMode + GameScore.countNormalMode; i++)
                {
                    data = new string[] { GameScore.Players[i].name, GameScore.Players[i].score, GameScore.Players[i].higher, GameScore.Players[i].time };
                    if (GameScore.Players[i].mode == GameMode.Normal)
                    {
                        dgvScoresNormal.Rows.Add(data);
                    }
                    else
                        dgvScoresAggressive.Rows.Add(data);
                }
            }
            dgvScoresNormal.Sort(Comparer);
            dgvScoresAggressive.Sort(Comparer);
            if (dgvScoresNormal.Rows.Count > 0)
            {
                BestPlayerNormal.name = dgvScoresNormal.Rows[0].Cells[0].Value.ToString();
                BestPlayerNormal.score = dgvScoresNormal.Rows[0].Cells[1].Value.ToString();
                BestPlayerNormal.higher = dgvScoresNormal.Rows[0].Cells[2].Value.ToString();
                BestPlayerNormal.time = dgvScoresNormal.Rows[0].Cells[3].Value.ToString();
            }
            if (dgvScoresAggressive.Rows.Count > 0)
            {
                BestPlayerAggressive.name = dgvScoresAggressive.Rows[0].Cells[0].Value.ToString();
                BestPlayerAggressive.score = dgvScoresAggressive.Rows[0].Cells[1].Value.ToString();
                BestPlayerAggressive.higher= dgvScoresAggressive.Rows[0].Cells[2].Value.ToString();
                BestPlayerAggressive.time = dgvScoresAggressive.Rows[0].Cells[3].Value.ToString();
            }
         }

        public frmScore(string name,string sc, string higher, string time,GameMode mode)
        {
            InitializeComponent();
            GameScore = new Score();
            GameScore.Players = new List<Player>();
            GameScore.countAggressiveMode = 0;
            GameScore.countNormalMode = 0;
            
            
            if (LoadData())
            {
                string[] dataplayer;
                
                for(int i=0;i<GameScore.countAggressiveMode + GameScore.countNormalMode; i++)
                {
                    dataplayer = new string[] { GameScore.Players[i].name, GameScore.Players[i].score, GameScore.Players[i].higher, GameScore.Players[i].time };
                    if (GameScore.Players[i].mode == GameMode.Normal)
                    {
                        dgvScoresNormal.Rows.Add(dataplayer);
                    }
                    else
                        dgvScoresAggressive.Rows.Add(dataplayer);
                }

            }


            string[] data = new string[] {name, sc, higher, time };

            if (mode == GameMode.Normal)
            {
                dgvScoresNormal.Rows.Add(data);
                GameScore.Players.Add(new Player(name, sc, higher, time,GameMode.Normal));
                GameScore.countNormalMode++;
                dgvScoresNormal.Rows[dgvScoresNormal.Rows.Count - 1].Selected = true;
            }
            else
            {
                dgvScoresAggressive.Rows.Add(data);
                GameScore.Players.Add(new Player(name, sc, higher, time,GameMode.Aggressive));
                GameScore.countAggressiveMode++;
                dgvScoresAggressive.Rows[dgvScoresAggressive.Rows.Count - 1].Selected = true;
            }
            

            dgvScoresNormal.Sort(Comparer);
            dgvScoresAggressive.Sort(Comparer );
            for (int i = 0; i < dgvScoresAggressive.Rows.Count; i++)
                if ( (dgvScoresAggressive.Rows[i].Cells[0].Value.ToString() == name) && (dgvScoresAggressive.Rows[i].Cells[1].Value.ToString() == sc) )
                    dgvScoresAggressive.CurrentCell = dgvScoresAggressive.Rows[i].Cells[0];

            for (int i = 0; i < dgvScoresNormal.Rows.Count; i++)
                if (dgvScoresNormal.Rows[i].Cells[0].Value.ToString() == name && dgvScoresNormal.Rows[i].Cells[1].Value.ToString() == sc)
                    dgvScoresNormal.CurrentCell = dgvScoresNormal.Rows[i].Cells[0];


        }


        private bool LoadData()
        {
            if (File.Exists("Scores.dat"))
            {
                Stream stream = File.Open("Scores.dat", FileMode.Open);
                try
                {

                    BinaryFormatter formatter = new BinaryFormatter();
                    GameScore = (Score)formatter.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch
                {
                    stream.Close();
                    return false;
                }
            }
            return false;
        }

        private void SaveData()
        {
            Stream stream = File.Open("Scores.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, GameScore);
            stream.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SaveData();
            this.Close();
        }

        private void frmScore_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private class RowComparer : System.Collections.IComparer
        {
            public int Compare(object a, object b)
            {
                DataGridViewRow rowA = (DataGridViewRow)a;
                DataGridViewRow rowB = (DataGridViewRow)b;
                int scoreA = int.Parse(rowA.Cells[1].Value.ToString());
                int scoreB = int.Parse(rowB.Cells[1].Value.ToString());
                int HigherA = int.Parse(rowA.Cells[2].Value.ToString());
                int HigherB = int.Parse(rowB.Cells[2].Value.ToString());
                int TimeA = int.Parse(rowA.Cells[3].Value.ToString());
                int TimeB = int.Parse(rowB.Cells[3].Value.ToString());
                int result;
                if (scoreA > scoreB)
                    result= -1;
                else if (scoreA < scoreB)
                    result= 1;
                else if (HigherA > HigherB)
                    result =-1;
                else if (HigherA < HigherB)
                    result= 1;
                else if (TimeA > TimeB)
                    result= -1;
                else if (TimeA < TimeB)
                    result= 1;
                else
                    result = 0;
                return result;
            }
        }

        private void btnClearRecord_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("If you delete all the records the information will be lost","Clear",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                dgvScoresAggressive.Rows.Clear();
                dgvScoresNormal.Rows.Clear();
                GameScore.countAggressiveMode =0;
                GameScore.countNormalMode = 0;
                GameScore.Players.Clear();
            }

        }
    }
}
