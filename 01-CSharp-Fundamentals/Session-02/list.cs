using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> grades = new List<int>();

        grades.Add(90);
        grades.Add(80);
        grades.Add(70);

        foreach (int grade in grades)
        {
            Console.WriteLine(grade);
        }

        Console.WriteLine("Count: " + grades.Count);
    }
}