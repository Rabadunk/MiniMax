namespace MiniMax
{
    public class Grid
    {
        private readonly int _numOfCols;
        private readonly int _numOfRows;
        private string[,] _grid;
        

        public Grid(int width, int height)
        {
            _numOfRows = height;
            _numOfCols = width;
            
            _grid = new string[width, _numOfRows];

            for (var rowPos = 0; rowPos < _numOfRows; rowPos++)
            {
                for (var colPos = 0; colPos < _numOfCols; colPos++)
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

            if (coordinate.GetSymbol().Length > 1)
            {
                return false;
            }

            if (coordinate.GetRow() > _numOfRows || coordinate.GetCol() > _numOfCols)
            {
                return false;
            }

            return coordinate.GetRow() >= 0 && coordinate.GetCol() >= 0;
        }

    }
}