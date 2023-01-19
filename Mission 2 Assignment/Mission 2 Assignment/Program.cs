using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables and Arrays
            int numRolls = 0;
            int[] rollResults = new int[11];
            string[] rollResultsWithAsterisk = new string[11];
            Random rnd = new Random();

            // Get user input
            Console.WriteLine("Welcome to the Dice throwing simulator!\n");
            Console.WriteLine("How many dice rolls would you like to simulate?");

            numRolls = Convert.ToInt32(Console.ReadLine());

            // Roll dice and populate array
            for (int i = 0; i < numRolls; i++)
            {
                //int roll = rnd.Next(11);
                int roll1 = rnd.Next(6);
                int roll2 = rnd.Next(6);
                int sum = roll1 + roll2;
                rollResults[sum]++;
                rollResultsWithAsterisk[sum] = rollResultsWithAsterisk[sum] + "*";
            }
            

            // Output results
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls + ".");

            
            for (int i = 0; i < rollResults.Length; i++)
            {
                Console.WriteLine((i + 2).ToString() + ": " + rollResultsWithAsterisk[i]);
            }

            Console.WriteLine("\nThank you for using the dice simulator. Goodbye!");

        }
    }
}
