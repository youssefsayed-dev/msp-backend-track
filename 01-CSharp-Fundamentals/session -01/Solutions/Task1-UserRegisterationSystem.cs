using System;

class Program
{
    static void Main()
    {
        // 1 Take Inputs
        Console.Write("Enter Full Name: ");
        string fullName = Console.ReadLine();

        Console.Write("Enter Age: ");
        string ageInput = Console.ReadLine();

        Console.Write("Enter Email Address: ");
        string email = Console.ReadLine();

        // 2 Validate Age
        if (!int.TryParse(ageInput, out int age))
        {
            Console.WriteLine("Invalid age format.");
            return;
        }

        if (age < 18)
        {
            Console.WriteLine("Access denied. You must be at least 18.");
            return;
        }

        // 3 Validate Email
        if (!email.Contains("@"))
        {
            Console.WriteLine("Invalid email address.");
            return;
        }

        // 4 Final Output
        Console.WriteLine($"Welcome {fullName}! Your age ({age}) is successfully saved.");
    }
}