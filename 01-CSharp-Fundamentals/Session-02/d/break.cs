using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out int num))
            {
                if (num < 0)
                {
                    Console.WriteLine("Negative number entered. Stopping program.");
                    break;
                }
                
                if (num == 0)
                {
                    continue;
                }
                
                Console.WriteLine($"You entered: {num}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}