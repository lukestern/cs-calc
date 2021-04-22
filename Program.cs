using System;

namespace cs_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the Calculator!");
            
            Console.Write("\nPlease enter an operator (+, -, *, /): ");
            string operation = Console.ReadLine();

            Console.Write("Please enter a number: ");
            string firstValue = Console.ReadLine();
            bool firstIntParsed = Int32.TryParse(firstValue, out int firstInt);
            
            Console.Write("Please enter another number: ");
            string secondValue = Console.ReadLine();
            bool secondIntParsed = Int32.TryParse(secondValue, out int secondInt);

            if (firstIntParsed && secondIntParsed)
            {
                Console.WriteLine("Result:");
                switch (operation)
                {
                    case "+":
                        Console.WriteLine(firstInt + secondInt);
                        break;
                    case "-":
                        Console.WriteLine(firstInt - secondInt);
                        break;
                    case "*":
                        Console.WriteLine(firstInt * secondInt);
                        break;
                    case "/":
                        Console.WriteLine(firstInt / secondInt);
                        break;
                }
            }

        }
    }
}
