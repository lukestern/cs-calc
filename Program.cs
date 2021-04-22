using System;
using System.Linq;

namespace cs_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the Calculator!");
            
            Console.Write("\nPlease enter an operator (+, -, *, /): ");
            string operation = Console.ReadLine();

            Console.Write($"\nHow many numbers do you want to {operation}? ");
            string repetitions = Console.ReadLine();
            bool repetitionsParsed = Int32.TryParse(repetitions, out int repetitionsInt);

            int[] values = null;
            if (repetitionsParsed)
            {
                values = new int[repetitionsInt];
                for (int i = 0; i < values.Length; i++)
                {
                    Console.Write("Please enter a number: ");
                    string valueStr = Console.ReadLine();
                    bool valueParsed = Int32.TryParse(valueStr, out int valueInt);
                    if (valueParsed)
                    {
                        values[i] = valueInt;
                    }
                }
            }

            int result = values[0];
            switch (operation)
            {
                case "+":
                    for (int i = 1; i < values.Length; i++)
                    {
                        result += values[i];
                    }
                    break;
                case "-":
                    for (int i = 1; i < values.Length; i++)
                    {
                        result -= values[i];
                    }
                    break;
                case "*":
                    for (int i = 1; i < values.Length; i++)
                    {
                        result *= values[i];
                    }
                    break;
                case "/":
                    for (int i = 1; i < values.Length; i++)
                    {
                        result /= values[i];
                    }
                    break;
                default:
                    result = 0;
                    break;
            }
            Console.Write($"Result: {result}");

        }
    }
}
