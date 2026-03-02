using System;

class Program
{
    static void Main()
    {
        int number;
        bool isValid;

        do
        {
            Console.Write("Enter a number greater than 0: ");
            string input = Console.ReadLine();

            isValid = int.TryParse(input, out number);

            if (!isValid)
                Console.WriteLine("Invalid input. Please enter a number.");
            else if (number <= 0)
                Console.WriteLine("Number must be greater than 0.");

        } while (!isValid || number <= 0);

        Console.WriteLine("Valid number entered!");
    }
}