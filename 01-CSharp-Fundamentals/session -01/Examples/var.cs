using System;

class Program
{
    static void Main()
    {
        string name = "Ali";
        int age = 20;
        double gpa = 3.5;
        bool isBackendStudent = true;

        const int MinimumAge = 18;
        // MinimumAge = 20; // Error: cannot assign to a constant

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        
        Console.WriteLine(MinimumAge);
        if (age >= MinimumAge)
        {
            Console.WriteLine("You are eligible.");
        }
        else
        {
            Console.WriteLine("You are not eligible.");
        }
    }
}