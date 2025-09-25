using System;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Number Guessing Game! \nI'm thinking of a number between 1 and 100. \nYou have 5 chances to guess the correct number.");
        Console.WriteLine("Please select the difficulty level: \n1. Easy (10 chances) \n2. Medium (5 chances) \n3. Hard (3 chances))");

        string difficulty = string.Empty;
        string? enteredDifficulty;
        do
        {
            Console.Write("Enter your choice: ");
            enteredDifficulty = Console.ReadLine();

            switch (enteredDifficulty)
            {
                case "1":
                    difficulty = "Easy";
                    break;
                case "2":
                    difficulty = "Medium";
                    break;
                case "3":
                    difficulty = "Hard";
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                    break;
            }

        } while (enteredDifficulty != "1" && enteredDifficulty != "2" && enteredDifficulty != "3");

        Console.WriteLine($"Great! You have selected the {difficulty} difficulty level.");
        Console.WriteLine("Let's start the game!");
    }
}