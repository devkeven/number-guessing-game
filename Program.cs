using System;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Number Guessing Game! \nI'm thinking of a number between 1 and 100. \nYou have 5 chances to guess the correct number.");
        Console.WriteLine("Please select the difficulty level: \n1. Easy (10 chances) \n2. Medium (5 chances) \n3. Hard (3 chances))");

        int numberToGuess = new Random().Next(1, 101);
        string? enteredDifficulty;
        string difficulty = string.Empty;
        int chances = 0;
        bool hasGessedCorrectly = false;
        do
        {
            Console.Write("Enter your choice: ");
            enteredDifficulty = Console.ReadLine();

            switch (enteredDifficulty)
            {
                case "1":
                    difficulty = "Easy";
                    chances = 10;
                    break;
                case "2":
                    difficulty = "Medium";
                    chances = 5;
                    break;
                case "3":
                    difficulty = "Hard";
                    chances = 3;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                    break;
            }

        } while (enteredDifficulty != "1" && enteredDifficulty != "2" && enteredDifficulty != "3");

        Console.WriteLine($"Great! You have selected the {difficulty} difficulty level.");
        Console.WriteLine("Let's start the game!");

        for (int i = 0; i < chances; i++)
        {
            Console.Write("Enter your guess: ");
            var guessedNumber = Console.ReadLine();

            if (int.TryParse(guessedNumber, out int guessedNum))
            {
                if (guessedNum < 1 || guessedNum > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                    i--;
                }
                else if (guessedNum == numberToGuess)
                {
                    hasGessedCorrectly = true;
                    Console.WriteLine($"Congratulations! You guessed the correct number in {i + 1} attempts.");
                    break;
                }
                else if (guessedNum < numberToGuess)
                {
                    Console.WriteLine($"Incorrect! The number is greater than {guessedNum}.");
                }
                else if (guessedNum > numberToGuess)
                {
                    Console.WriteLine($"Incorrect! The number is less than {guessedNum}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                i--;
            }
        }

        if (!hasGessedCorrectly)
        {
            Console.WriteLine($"\nSorry, you've used all your chances. The correct number was {numberToGuess}. Better luck next time!\n");
        }
       
    }
}