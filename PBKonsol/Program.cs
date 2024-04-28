using System;
using System.Collections.Generic;

namespace PBKonsol
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        
        // Declare int
        int squatPB = 150;
        int benchPB = 80;
        int deadliftPB = 120;
        string userInput;
        // Userinput2 for View
        string userInput2;
        // Userinput3 for Add JUST NU under input2
        string userInput3;
    
        // Create a new dictionary to store the PBs
        Dictionary<string, int> gymPBs = new Dictionary<string, int>();
    
        // Add PBs to the dictionary
        gymPBs.Add("Squat", squatPB);
        gymPBs.Add("Bench press", benchPB);
        gymPBs.Add("Dead lift", deadliftPB);

        while (true)
        {
            Console.WriteLine("Welcome, what would you like to do?");
            Console.WriteLine("[V]iew PBs");
            Console.WriteLine("[A]dd a new PB");
            Console.WriteLine("[R]emove a PB");
            Console.WriteLine("[E]xit");

            // Read the user's input
            userInput = Console.ReadLine();
            if (userInput.ToLower() == "v")
            {
                Console.WriteLine("Which one would you like to view?");
                userInput2 = Console.ReadLine();
                if (gymPBs.TryGetValue(userInput2, out var b))
                {
                    Console.WriteLine("Your PB for " + userInput2 + " is " + b);
                }
                else
                {
                    Console.WriteLine("You don't have a PB for " + userInput2 + ", would you like to add one? (y/n)");
                    userInput3 = Console.ReadLine();
                    if (userInput3.ToLower() == "yes" || userInput3.ToLower() == "y")
                    {
                        Console.WriteLine("What is your PB for " + userInput2 + " in kg?");
                        gymPBs.Add(userInput2, Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Your PB for " + userInput2 + " has been added");
                    }
                    else
                    {
                        Console.WriteLine("Ok, have a nice day!");
                    }
                }
            }
            else if (userInput.ToLower() == "e")
            {
                break;
            }
            else // If the user didn't enter any of the valid actions
            {
                Console.WriteLine("Invalid action, please try again.");
            }


            Console.ReadKey();
        }
        }
    }
}
