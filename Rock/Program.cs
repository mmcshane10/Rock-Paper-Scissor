using System;
using RPS.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Rock, Paper, Scissors. Type the number of the mode you'd like to play:");
        Console.WriteLine("1. Player vs. Player");
        Console.WriteLine("2. Player vs. Computer");
        string gameMode = Console.ReadLine();
        if (gameMode == "1")
        {
            Game.PlayervPlayer();
        }
        else{
            Game.PlayervComputer();
        }
    }
}