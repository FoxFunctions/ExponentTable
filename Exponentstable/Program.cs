using System;

namespace Exponentstable
{
    public sealed class Program
    {
        static bool userRunAgain = true;
        static int userInteger = 0;

        public static void Main()
        {
            Console.WriteLine("Welcome to the Exponent table.");
            while (userRunAgain)
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter an integer greater than zero");
                    Console.WriteLine();
                    int userInput = int.Parse(Console.ReadLine());
                    if (userInput <= 0)
                    {
                        Console.WriteLine("That integer is less than or equal to 0. Please enter an integer that is greater than 0");
                        continue;
                    }
                    else if (userInput > 1290)
                    {
                        Console.WriteLine();
                        Console.WriteLine("This number is too large. Please choose a smaller number");
                        continue;
                    }
                    else
                    {
                        userInteger = userInput;
                        Console.WriteLine();
                        Console.WriteLine($"The following table will show you the square and cube values for the numbers 1 - {userInteger}.");
                        break;
                    }
                }
                Console.WriteLine();
                Console.Write("Numbers" + "     \t" + "Squares" + "     \t" + "Cubes");
                Console.WriteLine();
                Console.Write("=======" + "     \t" + "=======" + "     \t" + "=======");
                Console.WriteLine();
                for (int i = 1; i <= userInteger; i++)
                {
                    Console.WriteLine(i + "\t" + "\t" + Math.Pow(i, 2) + "\t" + "\t" + Math.Pow(i, 3));
                }
                userRunAgain = RunAgain();
            }
        }
        public static bool RunAgain()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to run again? please enter y/n");
            string userPreference = Console.ReadLine().ToLower();
            if (userPreference == "y")
            {
                return true;
            }
            else if (userPreference == "n")
            {
                Console.WriteLine("Goodbye");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry. I didn't quite get that.");
                return RunAgain();
            }
        }
    }
}