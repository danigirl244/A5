using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
   public interface ITicTac
    {
        char[,] BoardSize();
        bool GameOver(char[,] board);
        int NumPlayers();
    }
}
