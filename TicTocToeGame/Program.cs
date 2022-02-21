using System;
namespace TicTocToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTocToe Game");
            TicTocGame game = new TicTocGame();//object
            game.StartGame();//call the method
            game.playerinput();
            Console.ReadLine();
        }
    }
}