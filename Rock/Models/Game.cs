using System;

namespace RPS.Models
{
    public class Game
    {
        private Item _player1Item;
        private Item _player2Item;

        public Game(string player1, string player2)
        {
            _player1Item =  new Item(player1);
            _player2Item = new Item(player2);
        }

        public static void PlayervPlayer()
        {
            Console.Clear();
                    
            string playerOneThrow = null;
            while (!(playerOneThrow == "rock" || playerOneThrow == "paper" || playerOneThrow == "scissors"))
            {
            Console.Clear();
            playerOneThrow = null;
            Console.Write("Player 1, choose what you want to throw [Press Enter To Submit]:");
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                playerOneThrow += key.KeyChar;
                }
            }

            string playerTwoThrow = null;
            while (!(playerTwoThrow == "rock" || playerTwoThrow == "paper" || playerTwoThrow == "scissors"))
            {
            Console.Clear();
            playerTwoThrow = null;
            Console.Write("Player 2, choose what you want to throw [Press Enter To Submit]:");
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                playerTwoThrow += key.KeyChar;
                }
            }

            Console.Clear();
            Game newGame = new Game(playerOneThrow, playerTwoThrow);
            Console.WriteLine($"Player 1 threw {playerOneThrow}.");
            Console.WriteLine($"Player 2 threw {playerTwoThrow}.");
            Console.WriteLine(newGame.DetermineWinner());
        }

        public static void PlayervComputer()
        {
            Console.Clear();
            string userThrow = null;
            while (!(userThrow == "rock" || userThrow == "paper" || userThrow == "scissors"))
            {
                Console.Clear();
                Console.Write("Player 1, choose what you want to throw [Press Enter To Submit]:");
                userThrow = Console.ReadLine();
            }
            string computerThrow = Game.ComputerThrow();

            Console.Clear();
            Game newGame = new Game(userThrow, computerThrow);
            Console.WriteLine($"Player 1 threw {userThrow}.");
            Console.WriteLine($"Computer threw {computerThrow}.");
            Console.WriteLine(newGame.DetermineWinner());
        }

        public static string ComputerThrow()
        {
            string[] throws = {"rock", "paper", "scissors"};
            Random rnd = new Random();
            int choice = rnd.Next(1,4);

            return throws[choice];
        }

        public string DetermineWinner()
        {
            string resultString = "";

            int result = _player1Item.Number + _player2Item.Number;

            if (result == 2 || result == 4 || result == 8)
            {
                resultString = "Game ends in a tie";
            }
            else if (result == 3)
            {
                resultString = "paper wins";
            } 
            else if ( result == 5)
            {
                resultString = "rock wins";
            } 
            else if (result == 6)
            {
                resultString = "scissors wins";
            }
            return resultString;
        }


    }

}