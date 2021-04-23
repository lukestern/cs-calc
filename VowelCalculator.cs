using System.Linq;
using System;

namespace cs_calc
{
    class VowelCalculator
    {
        static string GetInput()
        {
            string inputString;
            do
            {
                Console.WriteLine("Please enter a string:");
                inputString = Console.ReadLine();
                if (String.IsNullOrEmpty(inputString))
                {
                    Console.WriteLine("Invalid string input. Please try again.");

                }
            } while (String.IsNullOrEmpty(inputString));
            return inputString;
        }

        static int[] Calculate(string inputString)
        {
            var input = inputString;
            int[] vowelCount = new int[5];
            vowelCount[0] = input.Where(x => Char.ToLower(x) == 'a').Count();
            vowelCount[1] = input.Where(x => Char.ToLower(x) == 'e').Count();
            vowelCount[2] = input.Where(x => Char.ToLower(x) == 'i').Count();
            vowelCount[3] = input.Where(x => Char.ToLower(x) == 'o').Count();
            vowelCount[4] = input.Where(x => Char.ToLower(x) == 'u').Count();
            return vowelCount;
        }

        static void PrintResult(int[] result)
        {
            Console.WriteLine("\nThe vowel counts are:");
            Console.WriteLine($"A: {result[0]}");
            Console.WriteLine($"E: {result[1]}");
            Console.WriteLine($"I: {result[2]}");
            Console.WriteLine($"O: {result[3]}");
            Console.WriteLine($"U: {result[4]}");
        }

        public static void DoOneCalculation()
        {
            string inputString = GetInput();
            int[] result = Calculate(inputString);
            PrintResult(result);
        }
    }
}
