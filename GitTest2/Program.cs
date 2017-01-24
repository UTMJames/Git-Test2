/*James Smith
 *1/24/2017
 *Program.cs
 *practice with github
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            int numbGuesses = 0;
            Console.WriteLine("Please enter the bounds for the game.");
            Console.WriteLine("Start:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("End:");
            int end = Convert.ToInt32(Console.ReadLine());
            int number = randNum.Next(start, end+1);
            Console.WriteLine("I'm thinking of a number from " + start + "-" + end + ":");
            int numbChosen = Convert.ToInt32(Console.ReadLine());
            while(numbChosen != number)
            {
                if(numbChosen > number)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                else
                {
                    Console.WriteLine("Your guess is too low.");
                }
                numbGuesses++;
                Console.WriteLine("Please choose again:");
                numbChosen = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Congratulations you guessed the number");
            Console.WriteLine("You guessed " + numbGuesses + " times.");
            if(numbGuesses < 10)
            {
                Console.WriteLine("Wow that didn't take you long");
            }
            else if(numbGuesses > 10 && numbGuesses < 30)
            {
                Console.WriteLine("That took you about average amount of tries");
            }
            else
            {
                Console.WriteLine("That too you forever to guess");
            }
            Console.ReadKey();
        }
    }
}
