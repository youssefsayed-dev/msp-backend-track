using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Break Example:");

        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                Console.WriteLine("Loop stopped at 5");
                break;
            }

            Console.WriteLine(i);
        }
    }
}