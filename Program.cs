using System;

namespace cs_calc
{
    class Program
    {
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("\nWelcome to the Calculator!");
        }

        static string GetCalculationMode()
        {
            string mode;
            bool modeValid;
            do 
            {
                Console.WriteLine("\nPlease select the calculator mode:\n1) Arithmetic\n2) Vowel Counting");
                mode  = Console.ReadLine();
                modeValid = (mode == "1" || mode == "2");
                if (! modeValid)
                {
                    Console.WriteLine("Calculation mode invalid. Please try again.");
                }
            } while (! modeValid);
            return mode;
        }

        static void Main(string[] args)
        {
            PrintWelcomeMessage();
            string mode;
            do 
            {
                mode = GetCalculationMode();
                if (mode == "1") {
                    ArithmeticCalculator.DoOneCalculation();
                } else if (mode == "2") {
                    VowelCalculator.DoOneCalculation();
                }
            } while (true);
        }
    }
}
