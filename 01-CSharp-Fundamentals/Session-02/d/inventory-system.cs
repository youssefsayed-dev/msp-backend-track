using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> inventory = new Dictionary<string, int>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n1- Add Product");
            Console.WriteLine("2- Remove Product");
            Console.WriteLine("3- Show All Products");
            Console.WriteLine("4- Exit");

            Console.Write("Enter choice: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid input. Enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter product name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter quantity: ");
                    if (int.TryParse(Console.ReadLine(), out int quantity) && quantity >= 0)
                    {
                        inventory[name] = quantity;
                        Console.WriteLine("Product added/updated.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid quantity.");
                    }
                    break;

                case 2:
                    Console.Write("Enter product name to remove: ");
                    string removeName = Console.ReadLine();

                    if (inventory.Remove(removeName))
                        Console.WriteLine("Product removed.");
                    else
                        Console.WriteLine("Product not found.");
                    break;

                case 3:
                    if (inventory.Count == 0)
                    {
                        Console.WriteLine("Inventory is empty.");
                    }
                    else
                    {
                        foreach (var item in inventory)
                        {
                            Console.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                    break;

                case 4:
                    running = false;
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}