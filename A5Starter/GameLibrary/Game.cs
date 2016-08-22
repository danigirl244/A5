using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Game
    {
        
        Player[] players;
        Board b = new Board();
        ITicTac game;

        public Game(ITicTac t)
        {
            game = t;
        }

        public void Start()
        {
            players = new Player[game.NumPlayers()];
            Player activePlayer;
            players[0] = new Player() { Name = "Player 1: Meow", Token = 'X' };
            players[1] = new Player() { Name = "Player 1: Woof", Token = '0' };

            int currentPlayerIndex = 0;
            activePlayer = players[currentPlayerIndex];

            while (!game.GameOver(b.board))
            {
                Console.WriteLine("Here is the board:");
                b.PrintBoard();

                TakeTurn(activePlayer);
                //select the other player
                currentPlayerIndex = (currentPlayerIndex == 0) ? 1 : 0;
                activePlayer = players[currentPlayerIndex];

                //Added this slight delay for user experience.  Without it it's harder to notice the board repaint
                //try commenting it out and check out the difference.  Which do you prefer?
                System.Threading.Thread.Sleep(300);

                Console.Clear();
            }
        }

        private void TakeTurn(Player activePlayer)
        {
            int[] position = b.PiecePlacement(activePlayer);
            b.board[position[0], position[1]] = activePlayer.Token;
        }
    }
}
