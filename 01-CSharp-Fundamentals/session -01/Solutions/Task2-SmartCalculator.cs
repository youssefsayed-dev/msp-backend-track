using System;

class Program
{
    static void Main()
    {
        // 1 Take Numbers
        Console.Write("Enter first number: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter second number: ");
        string input2 = Console.ReadLine();

        if (!double.TryParse(input1, out double num1) ||
            !double.TryParse(input2, out double num2))
        {
            Console.WriteLine("Invalid number entered.");
            return;
        }

        // 2 Ask for Operation
        Console.WriteLine("Choose operation:");
        Console.WriteLine("1 → Addition");
        Console.WriteLine("2 → Multiplication");

        string operationInput = Console.ReadLine();

        if (!int.TryParse(operationInput, out int operation))
        {
            Console.WriteLine("Invalid operation selected.");
            return;
        }

        // 3 Use Conditions
        if (operation == 1)
        {
            double result = num1 + num2;
            Console.WriteLine("Result = " + result);
        }
        else if (operation == 2)
        {
            double result = num1 * num2;
            Console.WriteLine("Result = " + result);
        }
        else
        {
            Console.WriteLine("Invalid operation selected.");
        }
    }
}