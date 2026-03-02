using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Continue Example:");

        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                continue;
            }

            Console.WriteLine(i);
        }
    }
}