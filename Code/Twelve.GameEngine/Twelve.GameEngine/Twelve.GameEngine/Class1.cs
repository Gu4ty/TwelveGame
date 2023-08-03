using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twelve.GameEngine
{

    public enum GameMode
    {
        Normal,
        Aggressive,
    }

    [Serializable]  
    public class Board
    {
        public bool IsRecord;

        GameMode Dificulty;
        private int[,] Grid;
        private int Width;
        private int Height;
        private int EmptyCells;
        private int Turns;
        int Score;
        int TimeElapsed;
        int HigherNumber;
        bool Win;
        Random RandomNumber = new Random();


        public Board(int H = 4, int W = 4, GameMode D = GameMode.Normal)
        {
            Dificulty = new GameMode();
            Dificulty = D;
            Turns = 0;
            Grid = new int[H, W];
            Width = W;
            Height = H;
            EmptyCells = H * W;
            HigherNumber = 0;
            Score = 0;
            TimeElapsed = 0;
            IsRecord = false;
            Win = false;
            
        }

        public GameMode gameMode
        {
            get
            {
                return Dificulty;
            }

        }

        public bool GameIsWin { get { return Win; } }

        
            
        public int turns
        {
            get
            {
                return Turns;
            }
            set
            {
                if (value >= 0)
                    Turns = value;
            }
        }

        public int time
        {
            get { return TimeElapsed; }
            set { if (value >= 0) TimeElapsed = value; }
        }

        public int score { get { return Score; } }
         
        public int Higher { get { return HigherNumber; } }

        public int H { get { return Height; } }

        public int W { get { return Width; } }

        public int this[int x, int y]
        {
            get
            {
                return Grid[x, y];
            }
        }

        public static Board MakeRandomBoard(int H, int W, int NumberOfPieces,GameMode m)
        {
            Board r = new Board(H, W,m);
            for (int i = 0; i < NumberOfPieces; i++)
                r.PutRandomPiece();
            return r;
        }

        public void MovePiece(int i0, int j0, int i, int j, bool WithScore)
        {
            if (WithScore)
                UpdateScore(Grid[i, j]);

            if (Grid[i, j]== 0 && Grid[i0,j0]!=0)
            {
                Grid[i, j] = Grid[i0, j0];
                Grid[i0, j0] = 0;
            }
            else if ((Grid[i0, j0]== Grid[i, j]) && (Grid[i, j]!= 0))
            {
                Grid[i, j] = Grid[i, j] + 1;
                Grid[i0, j0] = 0;
                EmptyCells++;
                if (Grid[i, j] > HigherNumber)
                    HigherNumber = Grid[i, j];
            }


        }

        public void MovePiece(Tuple<int, int> ini, Tuple<int, int> fin,bool WithScore)
        {
            int i0 = ini.Item1; int i = fin.Item1;
            int j0 = ini.Item2; int j = fin.Item2;

            MovePiece(i0, j0, i, j,WithScore);

        }

        public Tuple<int, int>[] Path(Tuple<int, int> source, Tuple<int, int> end)
        {
            //Case: source=end
            if (source.Item1 == end.Item1 && source.Item2 == end.Item2)
                return (new Tuple<int, int>[] { source });

            // Case: Number of pieces dont match
            if (Grid[source.Item1, source.Item2] != Grid[end.Item1, end.Item2] && Grid[end.Item1, end.Item2] != 0)
                return (new Tuple<int, int>[] { new Tuple<int, int>(-1, -1) });

            // Initializations
            bool[] visited = new bool[Width * Height];
            int ini = source.Item1 * Width + source.Item2;
            int fin = end.Item1 * Width + end.Item2;
            int[] parent = new int[Width * Height];
            int[] direction = new int[] { 1, -1, Width, -Width };
            for (int i = 0; i < parent.Length; i++)
                parent[i] = -1;

            //BFS
            visited[ini] = true;
            Queue<int> q = new Queue<int>();
            q.Enqueue(ini);

            while (q.Count > 0)
            {
                int vertex = q.Dequeue();
                foreach (int d in direction)
                {
                    int next = vertex + d;
                    if (CanGo(vertex, next, fin, visited))
                    {
                        parent[next] = vertex;
                        visited[next] = true;
                        q.Enqueue(next);
                        if (next == fin)
                            return ToPathTuples(MakePath(parent, fin));

                    }
                }

            }
            return (new Tuple<int, int>[] { new Tuple<int, int>(-1, -1) });
        }

        public void PutRandomPiece()
        {
            int pos = 0;
            pos = RandomNumber.Next(1, EmptyCells + 1);

            int count = 0;
            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                    if (Grid[i, j]== 0)
                    {
                        count++;
                        if (count == pos)
                        {
                            Grid[i, j] = RandomNumber.Next(1, 4);
                            EmptyCells--;
                            if (Grid[i, j] > HigherNumber)
                                HigherNumber = Grid[i, j];
                            return;
                        }
                    }

        }

        public void PerturbBoard()
        {
            Board NewBoard = new Board(Height, Width);
            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                    if (Grid[i, j] != 0)
                        NewBoard.PutPieceInRandomPosition(Grid[i, j]);
            Grid = NewBoard.Grid;
        }

        public bool LostGame()
        {
            if (EmptyCells != 0) return false;

            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                    if (CanMove(i, j))
                        return false;
            return true;
        }

        public bool WinGame()
        {
            if (HigherNumber == 12)
                return Win = true;
            return false;
        }

       //Utility functions...

        private bool CanMove(int i, int j)
        {
            if ( (i + 1) < Height)
            {
                if (Grid[i, j] == Grid[i + 1, j])
                    return true;
            }
            if( (j+1)<Width)
            {
                if (Grid[i, j] == Grid[i, j + 1])
                    return true;
            }
            return false;
        }

        private bool CanGo(int from, int next, int fin, bool[] see)
        {
            if ((next < 0) || (next >= Width * Height))
                return false;
            if (see[next])
                return false;
            if ((next == from + 1 || next == from - 1) && ((next / Width) != (from / Width)))
                return false;

            int next_i = next / Width;
            int next_j = next % Width;
            return ((Grid[next_i, next_j]== 0) || (next == fin));

        }

        private int[] MakePath(int[] p, int end)
        {
            Stack<int> s = new Stack<int>();
            s.Push(end);
            int parent = p[end];
            while (parent != -1)
            {
                s.Push(parent);
                parent = p[parent];
            }

            int[] path = new int[s.Count];
            for (int i = 0; i < path.Length; i++)
                path[i] = s.Pop();
            return path;
        }

        private Tuple<int, int>[] ToPathTuples(int[] path)
        {
            Tuple<int, int>[] TuplePath = new Tuple<int, int>[path.Length];
            for (int i = 0; i < TuplePath.Length; i++)
                TuplePath[i] = new Tuple<int, int>(path[i] / Width, path[i] % Width);
            return TuplePath;
        }

        private void PutPieceInRandomPosition(int p )
        {
            int pos = RandomNumber.Next(1, EmptyCells + 1);
            int count = 0;
            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                    if (Grid[i, j] == 0)
                    {
                        count++;
                        if (count == pos)
                        {
                            Grid[i, j] = p;
                            EmptyCells--;
                            return;
                        }
                    }
        }

        private void UpdateScore(int FinalPosition)
        {
            if (FinalPosition!=0)
            {
                
                Score += FinalPosition + 1 + (60/(TimeElapsed+1));
            }

        }

       
        
    }
}
