using System; 
namespace MiniMax
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new Grid(3);
            var display = new View(grid);
            var playerOne = new Player("X", 1);
            var playerTwo = new Player("O", 2);
            
            View.GetPlayerMove(playerOne);
        }
    }
}