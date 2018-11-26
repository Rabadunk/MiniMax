using System;
using System.Linq;

namespace MiniMax
{
    public class Player : IPlayer
    {
        private readonly string _symbol;
        private string _input;
        private readonly int _id;

        public Player(string symbol, int id)
        {
            _symbol = symbol;
            _id = id;
        }

        public Coordinates GetMove()
        {
            _input = Console.ReadLine();
            if (!CheckIfValidMove(_input)) throw new InvalidCoordinateException("That coordinate is invalid.");
            return ConvertToValidCoordinate(_input);
        }
        
        public Coordinates FakeMove(string _input)
        {
            if (!CheckIfValidMove(_input)) throw new InvalidCoordinateException("That coordinate is invalid.");
            return ConvertToValidCoordinate(_input);
        }
        
        public bool CheckIfValidMove(string input)
        {
            if (input.Length != 3) return false;
            if (input[1].ToString() != ",") return false;
            if(!int.TryParse(input[0].ToString(), out var row)) return false;
            if(!int.TryParse(input[2].ToString(), out var col)) return false;
            var validRow = row - 1;
            var validCol = col - 1;
            return Enumerable.Range(0,3).Contains(validRow) && Enumerable.Range(0,3).Contains(validCol);
        }

        private Coordinates ConvertToValidCoordinate(string move)
        {
            return new Coordinates(int.Parse(move[0].ToString()) - 1, int.Parse(move[2].ToString()) - 1, _symbol);
        }

        public int GetId()
        {
            return _id;
        }

        public string GetSymbol()
        {
            return _symbol;
        }


    }
}