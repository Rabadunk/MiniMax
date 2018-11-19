namespace MiniMax
{
    public class Coordinates
    {
        private int _rowPos;
        private int _colPos;
        private string _symbol;

        public Coordinates(int rowPos, int colPos, string symbol)
        {
            this._rowPos = rowPos;
            this._colPos = colPos;
            this._symbol = symbol;
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