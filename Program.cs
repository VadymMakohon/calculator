using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("🖩 Simple .NET Calculator");
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            if (choice == "5")
            {
                Console.WriteLine("Goodbye! 👋");
                break;
            }

            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input! Press any key to try again.");
                Console.ReadKey();
                continue;
            }

            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input! Press any key to try again.");
                Console.ReadKey();
                continue;
            }

            double result = 0;
            bool validOperation = true;

            switch (choice)
            {
                case "1":
                    result = num1 + num2;
                    break;
                case "2":
                    result = num1 - num2;
                    break;
                case "3":
                    result = num1 * num2;
                    break;
                case "4":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed!");
                        validOperation = false;
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again!");
                    validOperation = false;
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine($"Result: {result}");
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}