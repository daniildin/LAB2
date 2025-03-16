using System;
using System.Collections.Generic;

/*UML Diagram 



DiceGame            
 - dice1: Dice                
 - dice2: Dice                
 - rounds: int                
 - dice1Wins: int             
 - dice2Wins: int             

 + PlayGame(): void           
 + GetWinner(): string        


Dice                 

 - sides: int                
 - topSide: int               

 + Roll(): int                
 + GetTopSide(): int          
 + IsNumberInArray(rolls: int[], number: int): bool
 + GenerateUniqueNumbersArray(): List<int>

*/


namespace DiceRollingGame
{
    public class Dice
    {
        // I renamed these variables to avoid using underscores, following the standard C# naming conventions.
        private int sides;
        private int topSide;

        // Constructor to initialize dice with a specified number of sides (default is 6)
        public Dice(int sides = 6)
        {
            this.sides = sides;  // I use 'this' to reference the current instance of the class
        }

        // Simulates a roll of the dice and returns the top side value
        public int Roll()
        {
            Random rand = new Random();  // I create a random object to generate random numbers
            topSide = rand.Next(1, sides + 1);  // I generate a random number between 1 and the number of sides
            return topSide;  // I return the value of the roll
        }

        // Returns the current top side value after the last roll
        public int GetTopSide()
        {
            return topSide;  // I simply return the value stored in 'topSide'
        }

        // Checks if a given number exists in an array of rolls
        public bool IsNumberInArray(int[] rolls, int number)
        {
            // I use Array.Exists to check if the number is present in the rolls array
            return Array.Exists(rolls, roll => roll == number);
        }

        // Generates a list of unique numbers by rolling the dice until all sides have been rolled at least once
        public List<int> GenerateUniqueNumbersArray()
        {
            List<int> rolls = new List<int>();  // I create a list to track the unique rolls
            while (rolls.Count < sides)  // I continue rolling until I have all unique numbers
            {
                int roll = Roll();  // I roll the dice
                if (!rolls.Contains(roll))  // I check if the number has already been rolled
                {
                    rolls.Add(roll);  // I add the new unique roll to the list
                }
            }
            return rolls;  // I return the list of unique rolls
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // I create two dice objects to simulate two different dice
            Dice dice1 = new Dice();
            Dice dice2 = new Dice();

            // I set up variables to track the number of wins for each dice and ties
            int dice1Wins = 0;
            int dice2Wins = 0;
            int ties = 0;

            // I roll both dice 5 times and compare the results
            for (int i = 0; i < 5; i++)
            {
                int roll1 = dice1.Roll();  // I roll dice1
                int roll2 = dice2.Roll();  // I roll dice2

                // I compare the results and track the number of wins and ties
                if (roll1 > roll2)
                    dice1Wins++;  // I increment dice1's win counter if dice1 rolls higher
                else if (roll2 > roll1)
                    dice2Wins++;  // I increment dice2's win counter if dice2 rolls higher
                else
                    ties++;  // I increment the tie counter if both rolls are equal
            }

            // I print out the number of wins and ties for each dice
            Console.WriteLine($"Dice 1 wins: {dice1Wins} times");
            Console.WriteLine($"Dice 2 wins: {dice2Wins} times");
            Console.WriteLine($"Ties: {ties} times");

            // I roll dice1 5 times and store the results in an array
            int[] rolls = { dice1.Roll(), dice1.Roll(), dice1.Roll(), dice1.Roll(), dice1.Roll() };
            // I check if the number 3 is in the rolls and print the result
            Console.WriteLine(dice1.IsNumberInArray(rolls, 3) ? "Number 3 is in the rolls" : "Number 3 is not in the rolls");

            // I generate a list of unique numbers by rolling dice1 until all numbers are rolled
            List<int> uniqueNumbers = dice1.GenerateUniqueNumbersArray();
            // I print the unique numbers rolled
            Console.WriteLine("Unique numbers rolled: " + string.Join(", ", uniqueNumbers));
        }
    }
}
