using System.Linq;

namespace MiniMax
{
    public class Grid
    {
        private readonly int _size;
        private string[,] _grid;
        

        public Grid(int size)
        {
            _size = size;           
            _grid = new string[size, _size];
            for (var rowPos = 0; rowPos < _size; rowPos++)
            {
                for (var colPos = 0; colPos < _size; colPos++)
                {   
                    _grid[rowPos, colPos] = ".";
                }
            }        
        }

        public bool PlaceTile(Coordinates coordinate)
        {
            if (!CoordinateCheck(coordinate)) return false;
            _grid[coordinate.GetRow(), coordinate.GetCol()] = coordinate.GetSymbol();
            return true;
        }

        public bool CoordinateCheck(Coordinates coordinate)
        {
            if (coordinate.GetRow() > _size || coordinate.GetCol() > _size)
            {
                return false;
            }
            
            return coordinate.GetRow() >= 0 && coordinate.GetCol() >= 0;
        }

        public string[,] GetGrid()
        {
            return _grid;
        }

        public int GetSize()
        {
            return _size;
        }

        public bool CheckRowWinCondition()
        {
            for (var i = 0; i < 3; i++)
            {
                var list = new[] {_grid[i, 0], _grid[i, 1], _grid[i, 2]};
                var allAreSame = list.All(x => x == list.First() && x != ".");
                
                if (allAreSame) return true;
            }

            return false;          
        }
        
    }
}