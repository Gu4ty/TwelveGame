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

    #region class Piece
    public class Piece
    {
        const int limit = 20;
        private int Number;
        private string Color;
        static private string[] ColorNumber = { "AntiqueWhite", "Yellow", "Green", "Blue", "Aqua","Orange","Gray" };
        public Piece(int number = 0)
        {
            if (number >= 0 && number <= limit)
            {
                Number = number;
                Color = ColorNumber[number];
            }
            else
            {
                Number = 0;
                Color = ColorNumber[0];
            }
        }

        public string ColorOfPiece
        {
            get
            {
                return Color;
            }
        }


        public int NumberOfPiece
        {
            get
            {
                return Number;
            }
        }
    }
    #endregion

    #region class Board
    public class Board
    {

        GameMode Dificulty;
        private Piece[,] Grid;
        private int Width;
        private int Height;
        private int EmptyCells;
        private int Turns;
        Random RandomNumber = new Random();

        public Board(int H = 4, int W = 4, GameMode D = GameMode.Normal)
        {
            Dificulty = new GameMode();
            Dificulty = D;
            Turns = 0;
            Grid = new Piece[H, W];
            Width = W;
            Height = H;
            for (int row = 0; row < H; row++)
                for (int col = 0; col < W; col++)
                {
                    Grid[row, col] = new Piece();
                }
            EmptyCells = H * W;
        }

        public GameMode gameMode
        {
            get
            {
                return Dificulty;
            }
            
        }

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

        public int H { get { return Height; } }

        public int W { get { return Width; } }

        public Piece this[int x, int y]
        {
            get
            {
                return Grid[x, y];
            }
            set
            {
                if (value.NumberOfPiece >= 0 && value.NumberOfPiece <= 20)
                {
                    Grid[x, y] = value;
                    if (value.NumberOfPiece != 0)
                        EmptyCells--;
                }
            }

        }

        public static Board MakeRandomBoard(int H, int W, int NumberOfPieces)
        {
            Board r = new Board(H, W);
            for (int i = 0; i < NumberOfPieces; i++)
                r.PutRandomPiece();
            return r;
        }

        public void MovePiece(int i0, int j0, int i, int j)
        {
            if (Grid[i, j].NumberOfPiece == 0)
            {
                Grid[i, j] = new Piece(Grid[i0, j0].NumberOfPiece);
                Grid[i0, j0] = new Piece(0);

            }
            else if ((Grid[i0, j0].NumberOfPiece == Grid[i, j].NumberOfPiece) && (Grid[i, j].NumberOfPiece != 0))
            {
                Grid[i, j] = new Piece(Grid[i, j].NumberOfPiece + 1);
                Grid[i0, j0] = new Piece(0);
                EmptyCells++;
            }
        }

        public void MovePiece(Tuple<int, int> ini, Tuple<int, int> fin)
        {
            int i0 = ini.Item1; int i = fin.Item1;
            int j0 = ini.Item2; int j = fin.Item2;

            MovePiece(i0, j0, i, j);

        }

        public Tuple<int, int>[] Path(Tuple<int, int> source, Tuple<int, int> end)
        {
            //Case: source=end
            if (source.Item1 == end.Item1 && source.Item2 == end.Item2)
                return (new Tuple<int, int>[] { source });

            // Case: Number of pieces dont match
            if (Grid[source.Item1, source.Item2].NumberOfPiece != Grid[end.Item1, end.Item2].NumberOfPiece && Grid[end.Item1,end.Item2].NumberOfPiece!=0)
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
                    if (Grid[i, j].NumberOfPiece == 0)
                    {
                        count++;
                        if (count == pos)
                        {
                            Grid[i, j] = new Piece(RandomNumber.Next(1, 4));
                            EmptyCells--;
                            return;
                        }
                    }

        }

        public void PerturbBoard()
        {
            Board NewBoard = new Board(Height, Width);
            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                    if (Grid[i, j].NumberOfPiece != 0)
                        NewBoard.PutPieceInRandomPosition(Grid[i, j]);
            Grid = NewBoard.Grid;
        }

        //Utility functions...
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
            return ((Grid[next_i, next_j].NumberOfPiece == 0) || (next == fin));

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

        private void PutPieceInRandomPosition(Piece p)
        {
            int pos = RandomNumber.Next(1, EmptyCells + 1);
            int count = 0;
            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                    if (Grid[i, j].NumberOfPiece == 0)
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


    }
    #endregion
}
