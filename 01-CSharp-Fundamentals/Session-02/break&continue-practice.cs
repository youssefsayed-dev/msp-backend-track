using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Negative number entered. Program stopped.");
                break;
            }

            if (number == 0)
            {
                continue;
            }

            Console.WriteLine("You entered: " + number);
        }
    }
}