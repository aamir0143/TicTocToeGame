using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TicTocToeGame
{
    public class TicTocGame
    {
<<<<<<< HEAD
       
=======
        public const char X = 'X';
        public const char O = 'O';
>>>>>>> UC2_LetterXOrO
        public void StartGame()
        {
            char[] board = new char[10];
            {
                for (int i = 1; i < 10; i++)
                {
                    board[i] = ' ';
                }
            }
        }
        public void playerinput()
        {
            Console.WriteLine("Enter you select from X Or O: ");
            char playerChoice = Convert.ToChar(Console.ReadLine());
            if (playerChoice == 'X')
            {
                Console.WriteLine("Player select" + playerChoice);
                Console.WriteLine("Computer select" + O);
            }
            else if (playerChoice == 'O')
            {
                Console.WriteLine("Player select"+ playerChoice);
                Console.WriteLine("Computer select" + X);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
