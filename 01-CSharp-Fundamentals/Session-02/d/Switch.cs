using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1- Add Student");
        Console.WriteLine("2- Delete Student");
        Console.WriteLine("3- Update Student");
        Console.WriteLine("4- Exit");

        Console.Write("Enter choice: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int choice))
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Student Added");
                    break;
                case 2:
                    Console.WriteLine("Student Deleted");
                    break;
                case 3:
                    Console.WriteLine("Student Updated");
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}