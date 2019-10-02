using System;
using RPS.Models;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Rock, Paper, Scissors!");
        
        string password = null;
        while (!(password == "rock" || password == "paper" || password == "scissors"))
        {
            Console.Clear();
            password = null;
            Console.Write("Player 1, choose what you want to throw [Press Enter To Submit]:");
            while (true)
            {
            var key = System.Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter)
                break;
            password += key.KeyChar;
            }
        }
        

        string password2 = null;
        while (!(password2 == "rock" || password2 == "paper" || password2 == "scissors"))
        {
            Console.Clear();
            password2 = null;
            Console.Write("Player 2, choose what you want to throw [Press Enter To Submit]:");
            while (true)
            {
            var key = System.Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter)
                break;
            password2 += key.KeyChar;
            }
        }



        Console.Clear();
        Game newGame = new Game(password, password2);
        Console.WriteLine($"Player 1 threw {password}.");
        Console.WriteLine($"Player 2 threw {password2}.");
        Console.WriteLine(newGame.DetermineWinner());
    }
}