using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Media;
using Twelve.GameEngine;

namespace TwelveWindowsForms
{
    public enum Sounds
    {
        Click,
        Error,
        GameOver,
        Menu,
        MenuClick,
        Succes,
        WinGame,
        NewRecord,
    }

    public partial class frmDrawing : Form
    {
        Board GameBoard;
        Tuple<int, int> PointClicked;
        Tuple<int, int> UnderMouse;
        public SoundPlayer player = new SoundPlayer();


        public frmDrawing()
        {
            if(!LoadData())
                GameBoard = Board.MakeRandomBoard(5, 4, 3,GameMode.Normal);
            PointClicked= new Tuple<int, int>(-1, -1);
            UnderMouse = new Tuple<int, int>(-1, -1);
            InitializeComponent();
            Crono.Enabled = false;
            Crono.Enabled = true;


        }

        private void pbxGrid_Paint(object sender, PaintEventArgs e)
        {
            
            //Draw Borders
            int countwidth = this.GameBoard.W;
            int countheight =this.GameBoard.H;
            int limitWidth = this.Width -  2 * grbGame.Width;
            int limitheight = this.Height - 2 * 23;
            int celldimension = Math.Min(limitheight/(countheight+1) , limitWidth / (countwidth+1) );
            
            Graphics g = e.Graphics;
            pbxGrid.Width = celldimension * countwidth+1;
            pbxGrid.Height = celldimension * countheight+1;
            pbxGrid.Location = new Point(  this.Width / 2 - pbxGrid.Width /2 , this.Height / 2 - pbxGrid.Height/2 );
            int penwidth = 120/(GameBoard.H+GameBoard.W) ;
            Pen p = new Pen(Color.Black, penwidth);

            for (int i = 0; i <= countwidth; i++)
                g.DrawLine(p, i * celldimension, 0, i * celldimension, pbxGrid.Height);
            for (int i = 0; i <= countheight; i++)
                g.DrawLine(p, 0, i * celldimension, pbxGrid.Width, i * celldimension);
           

            //Draw Board
            for(int i=0;i<this.GameBoard.H;i++)
                for(int j = 0; j < this.GameBoard.W; j++)
                {
                    SolidBrush ColorPiece = new SolidBrush(ColorOfPiece(GameBoard[i,j]) );
                    Font NumberFont = new Font("Calibri", Math.Min(celldimension, celldimension) / 3, FontStyle.Bold);
                    if (UnderMouse.Item1 == i && UnderMouse.Item2 == j && PointerShadow.Checked)
                        g.FillRectangle(Brushes.LimeGreen, j * celldimension + penwidth / 2 + 1, i * celldimension + penwidth / 2 + 1, celldimension - penwidth, celldimension - penwidth);
                   else if (PointClicked.Item1 == i && PointClicked.Item2 == j)
                        g.FillRectangle(Brushes.LightCoral, j * celldimension + penwidth / 2 + 1, i * celldimension + penwidth / 2 + 1, celldimension - penwidth, celldimension - penwidth);
                    else
                        g.FillRectangle(ColorPiece, j*celldimension + penwidth / 2 + 1, i*celldimension + penwidth / 2 + 1, celldimension - penwidth,celldimension  - penwidth);
                    if(this.GameBoard[i,j]!=0)
                        g.DrawString(this.GameBoard[i,j].ToString(), NumberFont,Brushes.Black , j*celldimension +celldimension/4 +penwidth/2+1 ,i* celldimension+celldimension/4 + penwidth / 2 + 1);
                }

            //Update Game State
            UpdateGameState();
        }

        private void pbxGrid_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X * GameBoard.W / pbxGrid.Width;
            int y = e.Y * GameBoard.H / pbxGrid.Height;
            

            if (PointClicked.Item1 == -1  )
            {
                if (GameBoard[y, x] != 0)
                {
                    PointClicked = new Tuple<int, int>(y, x);
                    Play_Sound(Sounds.Click);
                }


            }
            else if (PointClicked.Item1 == y && PointClicked.Item2 == x)
            {
                PointClicked = new Tuple<int, int>(-1, -1);
                Play_Sound(Sounds.Click);
            }
            else
            {
                Tuple<int, int> FinalPoint = new Tuple<int, int>(y, x);
                Tuple<int, int>[] path = GameBoard.Path(PointClicked, FinalPoint);
                if (path.Length <= 1)
                {
                    PointClicked = new Tuple<int, int>(-1, -1);
                    Play_Sound(Sounds.Error);
                }
                else
                {
                    bool WasBadMove = GameBoard[FinalPoint.Item1, FinalPoint.Item2] == 0;
                    PointClicked = new Tuple<int, int>(-1, -1);
                    int speed = 0;
                    if (Animations.Checked)
                        speed = 400 / path.Length;
                    MoveAnimated(path,speed);
                    if(!WasBadMove)
                        Play_Sound(Sounds.Succes);
                    int limit =  (GameBoard.H + GameBoard.W) / 8;
                    if (WasBadMove)
                        limit *= 2;
                    for (int i = 0; i < limit; i++)
                        GameBoard.PutRandomPiece();
                    
                    GameBoard.turns++;

                    if (GameBoard.gameMode == GameMode.Aggressive)
                    {
                        if(GameBoard.turns % 18 == 0)
                            GameBoard.PerturbBoard();
                                               
                    }
                        
                }
            }
            pbxGrid.Refresh();
            if(!GameBoard.IsRecord && GameBoard.score > int.Parse(lblBestScore.Text))
            {
                GameBoard.IsRecord = true;
                Play_Sound(Sounds.NewRecord);
                MessageBox.Show("CONGRATULATIONS, YOU HAVE A NEW RECORD!!!!!", "NEW RECORD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            if (GameBoard.LostGame())
            {
                if (pbxGrid.Cursor != Cursors.No)
                {
                    Play_Sound(Sounds.GameOver);
                    MessageBox.Show("YOU LOST THE GAME", "GAME OVER", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    SaveScore();
                }
                
            }
            if ( !GameBoard.GameIsWin &&  GameBoard.WinGame())
            {
                Play_Sound(Sounds.WinGame);
                MessageBox.Show("CONGRATULATIONS!!! YOU WIN THE GAME!!!","WINNER",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                SaveScore();
            }
           
        }

        private void MoveAnimated(Tuple<int,int> []path, int speed)
        {
            
            for(int i = 0; i < path.Length - 1; i++)
            {
                System.Threading.Thread.Sleep(speed);
                GameBoard.MovePiece(path[i],path[i+1],i==path.Length-2);
                pbxGrid.Refresh();
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Play_Sound(Sounds.MenuClick);
            frmOptions OptionsForm = new frmOptions();
            OptionsForm.ShowDialog();
             
            if (OptionsForm.start)
            {
                if (MessageBox.Show("If you start a new game you will lose all the progress", "New Game", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    GameBoard = Board.MakeRandomBoard(OptionsForm.height, OptionsForm.width, OptionsForm.height * OptionsForm.width / 5, OptionsForm.mode);
                    PointClicked = new Tuple<int, int>(-1, -1);
                    UnderMouse = new Tuple<int, int>(-1, -1);
                    pbxGrid.Refresh();
                }
            }
        }

        private void Crono_Tick(object sender, EventArgs e)
        {
            int time = GameBoard.time++;
            lblTime.Text = TimeFormat(time);
         }

        private Color ColorOfPiece(int P)
        {
            if (P == 0)
                return Color.White;
            if (P > 27)
                return Color.Purple;
            int BlueValue = 27;
            int RedValue = 1;
            int ColorP = 1023 * (P - RedValue) / (BlueValue - RedValue);
            if (ColorP < 256)
            {
                return Color.FromArgb(255, ColorP, 0);
            }
            if (ColorP < 512)
            {
                ColorP -= 256;
                return Color.FromArgb(255-ColorP, 255,0);
            }
            if (ColorP < 768)
            {
                ColorP -= 512;
                return Color.FromArgb(0, 255, ColorP);
            }
            ColorP -= 768;
            return Color.FromArgb(0, 255 - ColorP, 255);

        }

        private void SaveData()
        {
            Stream stream = File.Open("saveTwelve.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, GameBoard);
            stream.Close();
        }

        private bool LoadData()
        {
            if (File.Exists("saveTwelve.dat"))
            {
                Stream stream = File.Open("saveTwelve.dat", FileMode.Open);
                try
                {
                    
                    BinaryFormatter formatter = new BinaryFormatter();
                    GameBoard = (Board)formatter.Deserialize(stream);
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Play_Sound(Sounds.MenuClick);
            this.Close();
        }

        private void frmDrawing_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            
            if (MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                if (MessageBox.Show("Save Game?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    SaveData();
            }
            else
                e.Cancel = true;
         
        }

        private void pbxGrid_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X * GameBoard.W / pbxGrid.Width;
            int y = e.Y * GameBoard.H / pbxGrid.Height;
            UnderMouse = new Tuple<int, int>(y, x);

            if (GameBoard.LostGame())
                pbxGrid.Cursor = Cursors.No;
            else if (PointClicked.Item1 != -1 && (GameBoard[UnderMouse.Item1, UnderMouse.Item2] != 0) && (GameBoard[UnderMouse.Item1, UnderMouse.Item2] != GameBoard[PointClicked.Item1, PointClicked.Item2]))
                pbxGrid.Cursor = Cursors.No;
            else if (GameBoard[UnderMouse.Item1, UnderMouse.Item2] != 0)
                pbxGrid.Cursor = Cursors.Hand;
            else
                pbxGrid.Cursor = Cursors.Default;
            pbxGrid.Refresh();
            
            
        }

        private void pbxGrid_MouseLeave(object sender, EventArgs e)
        {
            UnderMouse = new Tuple<int, int>(-1, -1);
            pbxGrid.Refresh();
       
        }

        private void restartGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Play_Sound(Sounds.MenuClick);
            if (!GameBoard.LostGame())
            {
                if (MessageBox.Show("Want to Restart? You will lose all the progress", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    GameBoard = Board.MakeRandomBoard(GameBoard.H, GameBoard.W, GameBoard.H * GameBoard.W / 5, GameBoard.gameMode);
                    PointClicked = new Tuple<int, int>(-1, -1);
                    UnderMouse = new Tuple<int, int>(-1, -1);
                    pbxGrid.Refresh();

                }
            }
            else
            {
                GameBoard = Board.MakeRandomBoard(GameBoard.H, GameBoard.W, GameBoard.H * GameBoard.W / 5, GameBoard.gameMode);
                pbxGrid.Refresh();
            }
        }

        private void UpdateGameState()
        {
            // Update Labels and progress bar

            //labels (Game state)
            lblExit.Location = new Point(this.Width - lblExit.Width, 0);
            grbGame.Location = new Point(0, this.Height / 2 - grbGame.Height / 2);
            grbBest.Location = new Point(this.Width - grbBest.Width - 1, this.Height / 2 - grbGame.Height / 2);
            lblMoves.Text = GameBoard.turns.ToString();
            lblScore.Text = GameBoard.score.ToString();
            lblHigher.Text = GameBoard.Higher.ToString();
            lblHigher.ForeColor = ColorOfPiece(GameBoard.Higher);
            string name, score, higher, time;
            //Best Game
            if (!GameBoard.IsRecord)
            {
                frmScore best = new frmScore();
               

                if (GameBoard.gameMode == GameMode.Normal)
                {
                    name = best.BestPlayerNormal.name;
                    score = best.BestPlayerNormal.score;
                    higher = best.BestPlayerNormal.higher;
                    time = best.BestPlayerNormal.time;
                }
                else
                {
                    name = best.BestPlayerAggressive.name;
                    score = best.BestPlayerAggressive.score;
                    higher = best.BestPlayerAggressive.higher;
                    time = best.BestPlayerAggressive.time;
                }
                if (name == null)
                {
                    score = lblScore.Text;
                    higher = lblHigher.Text;
                    time = lblTime.Text;
                }

            }
            else
            {
                name = "";
                score = lblScore.Text;
                higher = lblHigher.Text;
                time = GameBoard.time.ToString();
            }



            lblName.Text = name;
            lblBestScore.Text = score;
            lblBestHigher.Text = higher;
            if (name != null)
            {
                int t = int.Parse(time);
                lblBestTime.Text = TimeFormat(t);
            }
            else
                lblBestTime.Text = time;
            lblBestHigher.ForeColor = ColorOfPiece(int.Parse(lblBestHigher.Text));
            
            

            // the "progress bar"
            Graphics g = this.CreateGraphics();
            Rectangle ProgressBar = new Rectangle();
            ProgressBar.Height = 23;
            ProgressBar.Width = 17 * 35;
            ProgressBar.Location = new Point(this.Width / 2 - ProgressBar.Width / 2, this.Height - ProgressBar.Height - 1);

            if (GameBoard.gameMode == GameMode.Aggressive)
            {
               

                g.FillRectangle(Brushes.White, ProgressBar);
                int value = GameBoard.turns % 18;
                ProgressBar.Width = 35 * value;
                SolidBrush progressColor = new SolidBrush(ColorOfPiece(18 - value));
                g.FillRectangle(progressColor, ProgressBar);
            }
            else
                g.FillRectangle(Brushes.Black, ProgressBar);

        }

        private void SaveScore()
        {
            PlayerName player = new PlayerName();
            player.ShowDialog();
            string name = player.name;
            frmScore score = new frmScore(name, GameBoard.score.ToString(), GameBoard.Higher.ToString(), GameBoard.time.ToString(),GameBoard.gameMode);
            score.ShowDialog();
            
        }

        private void ShowScore()
        {
            frmScore score = new frmScore();
            score.ShowDialog();
        }

        private void scoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Play_Sound(Sounds.MenuClick);
            ShowScore();
        }

        private string TimeFormat(int time)
        {
            int hours = time / 3600;
            time %= 3600;
            int minutes = time / 60;
            time %= 60;
            int seconds = time;
            return (hours % 10).ToString() + ":" + (minutes / 10).ToString() + (minutes % 10).ToString() + ":" + (seconds / 10).ToString() + (seconds % 10).ToString();

        }

        private void Play_Sound(Sounds s)
        {
            if (!SoundEffects.Checked)
                return;
            Stream sound;

            switch (s)
            {
                case Sounds.Click:
                    sound = Properties.Resources.Click;
                    break;
                case Sounds.Error:
                    sound = Properties.Resources.Error;
                    break;
                case Sounds.GameOver:
                    sound= Properties.Resources.GameOver;
                    break;
                case Sounds.Menu:
                    sound = Properties.Resources.Menu;
                    break;
                case Sounds.MenuClick:
                    sound = Properties.Resources.Menu_Click;
                    break;
                case Sounds.Succes:
                    sound= Properties.Resources.Succes;
                    break;
                case Sounds.WinGame:
                    sound = Properties.Resources.WinGame;
                    break;
                case Sounds.NewRecord:
                    sound = Properties.Resources.NewRecord;
                    break;
                default:
                    sound = Properties.Resources.Menu;
                    break;
            }
            sound.Position = 0;
            player.Stream = null;
            player.Stream = sound;
            player.Play();
        }

        private void Animations_Click(object sender, EventArgs e)
        {
            Play_Sound(Sounds.MenuClick);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Play_Sound(Sounds.MenuClick);
            bool ok=false;
            if (!GameBoard.LostGame())
            {
                if (MessageBox.Show("Want to Start a New Game? You will lose all the progress", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ok = true;
                    

                }
            }
            if (ok || GameBoard.LostGame())
            {
                GameBoard = Board.MakeRandomBoard(5, 4, 3, GameMode.Normal);
                PointClicked = new Tuple<int, int>(-1, -1);
                UnderMouse = new Tuple<int, int>(-1, -1);
                pbxGrid.Refresh();
            }

        }

        private void aggressiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ok = false;
            if (!GameBoard.LostGame())
            {
                if (MessageBox.Show("Want to Start a New Game? You will lose all the progress", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ok = true;


                }
            }
            if (ok || GameBoard.LostGame())
            {
                GameBoard = Board.MakeRandomBoard(5, 4, 3, GameMode.Aggressive);
                PointClicked = new Tuple<int, int>(-1, -1);
                UnderMouse = new Tuple<int, int>(-1, -1);
                pbxGrid.Refresh();
            }
        }

        
        private void Animations_MouseEnter(object sender, EventArgs e)
        {
            Play_Sound(Sounds.Menu);
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            Play_Sound(Sounds.Menu);
            lblExit.Font= new Font("Kristen ITC",18,FontStyle.Bold);
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.Font= new Font("Kristen ITC", 15, FontStyle.Bold);
        }
    }
}
