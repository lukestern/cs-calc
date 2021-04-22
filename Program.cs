using System;

namespace cs_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");

            Console.WriteLine("Please enter a number:");
            string firstValue = Console.ReadLine();
            bool firstIntParsed = Int32.TryParse(firstValue, out int firstInt);
            
            Console.WriteLine("Please enter another number:");
            string secondValue = Console.ReadLine();
            bool secondIntParsed = Int32.TryParse(secondValue, out int secondInt);

            if (firstIntParsed && secondIntParsed)
            {
                Console.WriteLine("Result:");
                Console.WriteLine(firstInt * secondInt);
            }

        }
    }
}
