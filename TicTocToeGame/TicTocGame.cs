using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TicTocToeGame
{
    public class TicTocGame
    {
        char[] board = new char[10];
        public void StartGame()
        {
            {
                for (int i = 1; i < 10; i++)
                {
                    board[i] = ' ';
                }
            }
        }
    }
}
