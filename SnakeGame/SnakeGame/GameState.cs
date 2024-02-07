
using Microsoft.VisualBasic;

namespace SnakeGame
{
    internal class GameState
    {
        public int Rows { get; }
        public int Cols { get; }
        public GridValues[,] Grid { get; }
        public Directions Dir { get; private set; }
        public int Score {  get; private set; }
        public bool GameOver { get; private set; }

        private readonly LinkedList<Position> SnakePosition = new LinkedList<Position>();
        private readonly Random random = new Random();

        public GameState(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            Grid = new GridValues[rows, cols];
            Dir = Directions.Right;

            AddSnake();
            AddFood();
        }

        private void AddSnake()
        {
            int r = Rows / 2;
            for(int c = 1; c < 3; c++)
            {
                Grid[r, c] = GridValues.Snake;
                SnakePosition.AddFirst(new Position(r, c));
            }
        }

        private IEnumerable<Position> EmptyPosition()
        {
            for(int r = 0; r < Rows; r++)
            {
                for(int c = 0; c < Cols; c++)
                {
                    if (Grid[r,c] == GridValues.Empty)
                    {
                        yield return new Position(r, c);
                    }
                }
            }
        }

        private void AddFood()
        {
            List<Position> empty = new List<Position>(EmptyPosition());
            if(empty.Count == 0)
            {
                return;
            }
            Position pos = empty[random.Next(empty.Count)];
            Grid[pos.Row,pos.Col] = GridValues.Food;
        }

        public Position HeadPosition()
        {
            return SnakePosition.First.Value;
        }

        public Position TailPosition()
        {
            return SnakePosition.Last.Value;
        }

        public IEnumerable<Position> Snake_Position()
        {
            return SnakePosition;
        }

        private void AddHead(Position pos)
        {
            SnakePosition.AddFirst(pos);
            Grid[pos.Row, pos.Col] = GridValues.Snake;
        }

        private void RemaoveTail()
        {
            Position tail = SnakePosition.Last.Value;
            Grid[tail.Row, tail.Col] = GridValues.Empty;
            SnakePosition.RemoveLast();
        }

        public void ChangeDirection(Directions dir)
        {
            Dir = dir;
        }

        public bool OutSideGrid(Position pos)
        {
            return pos.Row < 0 || pos.Row >= Rows || pos.Col < 0 || pos.Col >= Cols;
        }

        private GridValues WiilHit(Position newPos)
        {
            if (OutSideGrid(newPos))
            {
                return GridValues.OutGrid;
            }
            if(newPos == TailPosition())
            {
                return GridValues.Empty;
            }
            return Grid[newPos.Row, newPos.Col];
        }

        public void Move()
        {
            Position newPos = HeadPosition().Translate(Dir);
            GridValues hit = WiilHit(newPos);

            if(hit == GridValues.OutGrid || hit == GridValues.Snake)
            {
                GameOver = true;
            }else if(hit == GridValues.Empty)
            {
                RemaoveTail();
                AddHead(newPos);
            }else if(hit == GridValues.Food)
            {
                AddHead(newPos);
                Score++;
                AddFood();
            }
        }
    }
        
}
