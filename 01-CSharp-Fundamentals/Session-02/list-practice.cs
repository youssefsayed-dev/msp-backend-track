using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> grades = new List<int>();
        int sum = 0;

        while (true)
        {
            Console.Write("Enter grade (or type exit): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            int grade = int.Parse(input);
            grades.Add(grade);
            sum += grade;
        }

        if (grades.Count > 0)
        {
            double average = (double)sum / grades.Count;
            Console.WriteLine("Average: " + average);
        }
        else
        {
            Console.WriteLine("No grades entered.");
        }
    }
}