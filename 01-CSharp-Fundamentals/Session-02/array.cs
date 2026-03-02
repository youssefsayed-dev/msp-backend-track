using System;

class Program
{
    static void Main()
    {
        int[] grades = { 90, 80, 70, 85, 100 };

        Console.WriteLine("First grade: " + grades[0]);
        Console.WriteLine("Array length: " + grades.Length);

        for (int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine("Grade " + i + ": " + grades[i]);
        }
    }
}