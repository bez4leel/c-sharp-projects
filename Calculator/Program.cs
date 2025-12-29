using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool programRunning = true;

            while (programRunning)
            {
                Console.WriteLine("Calculator");
                Console.Write("Enter first number (or Q to quit): ");
                string menuInput = Console.ReadLine();

                if (menuInput.ToLower() == "q")
                {
                    programRunning = false;
                    break;
                }

                if (!double.TryParse(menuInput, out double firstNumber))
                {
                    Console.WriteLine("Invalid number.");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                Console.Write("Enter second number: ");
                string menuInput2 = Console.ReadLine();

                if (!double.TryParse(menuInput2, out double secondNumber))
                {
                    Console.WriteLine("Invalid number.");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                Console.Clear();

                Console.WriteLine("Select operation");
                Console.WriteLine("1. +");
                Console.WriteLine("2. -");
                Console.WriteLine("3. /");
                Console.WriteLine("4. *");
                Console.Write("Select option: ");
                string operationInput = Console.ReadLine();

                if (!int.TryParse(operationInput, out int operationNumber))
                {
                    Console.WriteLine("Invalid operation.");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                Console.Clear();

                if (operationNumber == 1)
                    Console.WriteLine($"Result : {firstNumber + secondNumber}");
                else if (operationNumber == 2)
                    Console.WriteLine($"Result : {firstNumber - secondNumber}");
                else if (operationNumber == 3)
                    Console.WriteLine($"Result : {firstNumber / secondNumber}");
                else if (operationNumber == 4)
                    Console.WriteLine($"Result : {firstNumber * secondNumber}");
                else
                    Console.WriteLine("Invalid operation.");

                Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine("Calculator closed.");
        }
    }
}
