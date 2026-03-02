using System;

class Program
{
    static void Main()
    {
        int count;

        while (true)
        {
            Console.Write("Enter number of students: ");
            if (int.TryParse(Console.ReadLine(), out count) && count > 0)
                break;

            Console.WriteLine("Invalid number. Try again.");
        }

        int[] grades = new int[count];

        for (int i = 0; i < count; i++)
        {
            while (true)
            {
                Console.Write($"Enter grade for student {i + 1}: ");

                if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
                {
                    grades[i] = grade;
                    break;
                }

                Console.WriteLine("Invalid grade. Enter a number between 0 and 100.");
            }
        }

        int sum = 0;
        int max = grades[0];
        int min = grades[0];

        foreach (int grade in grades)
        {
            sum += grade;
            if (grade > max) max = grade;
            if (grade < min) min = grade;
        }

        double average = (double)sum / count;

        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Highest: {max}");
        Console.WriteLine($"Lowest: {min}");
    }
}