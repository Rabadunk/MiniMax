using System;
using System.Linq;

namespace MiniMax
{
    public class Player : IPlayer<Player>
    {
        private readonly string _symbol;
        private readonly int _id;

        public Player(int id, string symbol)
        {
            _id = id;
            _symbol = symbol;
        }

        public Coordinates GetMove()
        {
            var input = Console.ReadLine();
            // I'm returning an invalid coordinate object if it isn't a valid input.
            return CheckForValidMove(input) ? ConvertToValidCoordinate(input) : new Coordinates(123, 123, "InvalidInput");
        }

        private static bool CheckForValidMove(string input)
        {
            if (input.Length != 3) return false;
            if (input[1].ToString() != ",") return false;
            if(!int.TryParse(input[0].ToString(), out var row)) return false;
            if(!int.TryParse(input[2].ToString(), out var col)) return false;
            return Enumerable.Range(0,2).Contains(row - 1) && Enumerable.Range(0,2).Contains(col - 1);
        }

        private Coordinates ConvertToValidCoordinate(string move)
        {
            return new Coordinates(int.Parse(move[0].ToString()) - 1, int.Parse(move[2].ToString()) - 1, _symbol);
        }


    }
}