using System;
using System.Linq;

namespace cs_calc
{
    class Program
    {
        static int numOfOperations = 0;

        static void PrintWelcomeMessage()
        {
            if (numOfOperations == 0)
            {
            Console.WriteLine("\nWelcome to the Calculator!");
            }
        }

        static string GetOperation()
        {
            string operation;
            bool operationValid;
            do
            {
                Console.Write("\nPlease enter an operator (+, -, *, /): ");
                operation = Console.ReadLine();
                operationValid = (operation == "+" || operation == "-" || operation == "*" || operation == "/");
                if (! operationValid)
                {
                    Console.WriteLine("Invalid operator given. Please try again.");
                }
            } while (! operationValid);
            return operation;
        }

        static int GetRepetitions(string operation)
        {
            string repetitions = null;
            bool repetitionsParsed;
            int repetitionsInt;
            do {
                Console.Write($"\nHow many numbers do you want to {operation}? ");
                repetitions = Console.ReadLine();
                repetitionsParsed = Int32.TryParse(repetitions, out repetitionsInt);
                if (! repetitionsParsed) 
                {
                    Console.WriteLine("Invalid value for repetitions given. Please try again.");
                }
            } while (! repetitionsParsed);
            return repetitionsInt;
        }

        static int[] GetValues(int repetitions)
        {
            int [] values = new int[repetitions];
            for (int i = 0; i < values.Length; i++)
            {
                string valueStr = null;
                bool valueParsed;
                int valueInt;
                do {
                    Console.Write($"Please enter number {i + 1}: ");
                    valueStr = Console.ReadLine();
                    valueParsed = Int32.TryParse(valueStr, out valueInt);
                    if (! valueParsed)
                    {
                        Console.WriteLine($"Invalid value given. Please try again.");
                    }
                } while (! valueParsed);
                values[i] = valueInt;
            }
            return values;
        }

        static int Calculate(int[] values, string operation)
        {
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
            return result;
        }

        static void DoOneCalculation()
        {
            string operation = GetOperation();
            int repetitions = GetRepetitions(operation);
            int[] values = GetValues(repetitions);
            int result = Calculate(values, operation);
            Console.Write($"Result: {result}\n");
            numOfOperations++;
        }

        static void Main(string[] args)
        {
            do 
            {
            PrintWelcomeMessage();
            DoOneCalculation();
            } while (numOfOperations > 0);
        }
    }
}
