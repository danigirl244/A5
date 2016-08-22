using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Board
    {

        public ITicTac t;
        public char[,] board = new char[3, 3];


        public void PrintBoard()
        {
            Console.WriteLine();
            for (int row = 0; row <= board.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= board.GetUpperBound(1); column++)
                {
                    Console.Write(board[row, column]);

                    if (column < board.GetUpperBound(1))
                    {
                        Console.Write(" - ");
                    }
  
                }
                Console.WriteLine();
            }
        }

        public int[] PiecePlacement(Player activePlayer)
        {
            Console.WriteLine();
            Console.WriteLine($"{activePlayer.Name}, it's your turn:");
            Console.WriteLine("Make your move by entering the number of the sqaure you'd like to take:");
            PrintBoardMap();
            Console.Write("Enter the number: ");

            return ConvertToArrayLocation(Console.ReadLine());
        }

        private int[] ConvertToArrayLocation(string boardPosition)
        {
            int position = Int32.Parse(boardPosition);
            position--; 
            int row = position / 3;
            int column = position % 3;
            return new int[] { row, column }; 
        }

        private void PrintBoardMap()
        {
            int position = 1; 
            for (int row = 0; row <= board.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= board.GetUpperBound(1); column++)
                {
                    Console.Write(position++);
                    if (column < board.GetUpperBound(1))
                    {
                        Console.Write(" - ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
