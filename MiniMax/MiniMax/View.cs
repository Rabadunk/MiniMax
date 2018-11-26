using System;

namespace MiniMax
{
    public class View
    {
        public View(Grid grid)
        {
            Console.WriteLine("Welcome to TicTacToe!!\n");
            Console.WriteLine("Here's the current board: \n");
            DrawGrid(grid);
        }

        private static void DrawGrid(Grid grid)
        {
            for (var row = 0; row < grid.GetSize(); row++)
            {
                for (var col = 0; col < grid.GetSize(); col++)
                {
                    Console.Write(grid.GetGrid()[row, col]);
                    Console.Write(" ");
                }   
                Console.Write("\n");
            }      
            Console.WriteLine();
        }

        public static void GetPlayerMove(Player player)
        {
            Console.Write("Player {0} enter a coord x,y to place your {1} or enter 'q' to give up: ", 
                player.GetId(), player.GetSymbol());
        }

    }
}