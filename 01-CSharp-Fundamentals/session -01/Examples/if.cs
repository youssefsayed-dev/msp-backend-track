using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        Console.Write("Enter age: ");
        string ageInput = Console.ReadLine();

        int age = int.Parse(ageInput);

//         if (!int.TryParse(ageInput, out int age))
//       {
//     Console.WriteLine("Invalid age input.");
//     return;
//      }

        if (username == "admin" && password == "1234" && age >= 18)
        {
            Console.WriteLine("Access Granted");
        }
        else
        {
            Console.WriteLine("Access Denied");
        }
    }
}