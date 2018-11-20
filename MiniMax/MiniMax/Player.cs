using System;
using System.Linq;

namespace MiniMax
{
    public class Player
    {
        private string _move;
        private int _movesRow;
        private int _movesCol;
        
        public Player()
        {
            _move = "Initial Move";
            _movesRow = 0;
            _movesCol = 0;
        }

        public bool IsValid()
        {
            if (!_move.Contains(","))
            {
                return false;
            }

            var numbers = _move.Split(",");

            if (numbers.Length > 2)
            {
                return false;
            }

            return int.TryParse(numbers[0], out var i) && int.TryParse(numbers[1], out var j);
        }

        public void SetMove(string move)
        {
            _move = move;
            if (!IsValid()) return;
            
            var numbers = _move.Split(",");
            int.TryParse(numbers[0], out _movesRow);
            int.TryParse(numbers[1], out _movesCol);
        }

        public void MakeMove()
        {
            _move = Console.ReadLine();
            if (!IsValid()) return;
            
            var numbers = _move.Split(",");
            int.TryParse(numbers[0], out _movesRow);
            int.TryParse(numbers[1], out _movesCol);
        }

        public int GetRowMove()
        {
            return _movesRow;
        }

        public int GetColMove()
        {
            return _movesCol;
        }

    }
}