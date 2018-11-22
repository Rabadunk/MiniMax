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
    }
}