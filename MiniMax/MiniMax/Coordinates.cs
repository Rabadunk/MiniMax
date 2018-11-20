namespace MiniMax
{
    public class Coordinates
    {
        private readonly int _rowPos;
        private readonly int _colPos;
        private readonly string _symbol;

        public Coordinates(int rowPos, int colPos, string symbol)
        {
            _rowPos = rowPos;
            _colPos = colPos;
            _symbol = symbol;
        }

        public int GetRow()
        {
            return _rowPos;
        }

        public int GetCol()
        {
            return _colPos;
        }

        public string GetSymbol()
        {
            return _symbol;
        }
    }
}