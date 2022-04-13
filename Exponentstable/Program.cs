using System;

namespace Exponentstable
{
    public sealed class Program
      {
        static bool runAgain = true;
        static int userInteger = 0;

        public static void Main()
        {
            Console.WriteLine("Welcome to the Exponent table.");
            while (runAgain)
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
                    //Console.WriteLine(i + "      " + "    " + Math.Pow(i, 2) + "     " + "       " + Math.Pow(i, 3));
                    Console.WriteLine(i + "\t" + "\t" + Math.Pow(i, 2) + "\t" + "\t" + Math.Pow(i, 3));
                }
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Would you like to run again? please enter y/n");
                    string userPreference = Console.ReadLine().ToLower();
                    if (userPreference == "y")
                    {
                        break;
                    }
                    else if (userPreference == "n")
                    {
                        Console.WriteLine("Goodbye");
                        runAgain = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry. I didn't quite get that.");
                        continue;
                    }
                } 
            }
        }
    }
}



/*EXPONENTS / Powers Table
Objectives: User input, calculations

NOTE: Points will still be awarded for items that are written correctly but don’t actually work due to other things being broken. There are a total of 10 points available for this lab.

Task: Display a table of powers. Ask the user if they would like to go again, and if so loop back to the beginning.

What will the application do?
1 Point: The application prompts the user to enter an integer.
3 Point: The application displays a table of squares and cubes from 1 to the value entered.
1 Point: The application prompts the user to continue.

Build Specifications:
1 Point: Assume that the user will enter valid data.
1 Point: The application should continue only if the user agrees to.

Additional Requirements:
1 Point: For answering the Lab Summary when submitting to the LMS
-2 Points: if there are any syntax errors or if the program does not run (for example, in a Main method). 

Hints:
Don’t mess up the difference between squares and cubes! 
Use \t to tab to line up columns properly
Your instructor will provide you with sample loops during class regarding how to ask the user if they would like to go again.

Extra Challenges:
1 Point: Provide validation by rejecting 0 or negative numbers as user input; keep prompting the user until they enter a valid number.
1 Point: Research formatted strings and right-align the numbers in columns instead of left-aligning them
1 Point: Find out the maximum number whose cube will fit in an int, and limit the user input to that number or less*/