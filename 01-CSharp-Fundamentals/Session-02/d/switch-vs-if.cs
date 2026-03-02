using System;

class Program
{
    static void Main()
    {
        // Console.WriteLine("Enter a character (A, B, or C):");
        Console.WriteLine("Enter a character (A, B, or C): ");
        // Console.WriteLine("A- Add Item:");
        // Console.WriteLine("B- Delete Item:");
        // Console.WriteLine("C- Exit:");
        
        // Read the input as a string and take the first character
        string input = Console.ReadLine();
        
        if (!string.IsNullOrEmpty(input))
        {
            char choice = input[0]; // Take the first character
            
            switch (char.ToUpper(choice)) // Convert to uppercase for case-insensitive comparison
            {
                case 'A':
                    Console.WriteLine("Add Item");
                    break;
                case 'B':
                    Console.WriteLine("Delete Item");
                    break;
                case 'C':
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid Option");
        }
        
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

// /*
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a character (A, B, or C):");
        
//         string input = Console.ReadLine();
        
//         if (!string.IsNullOrEmpty(input))
//         {
//             char choice = char.ToUpper(input[0]);
            
//             if (choice == 'A')
//             {
//                 Console.WriteLine("Add Item");
//             }
//             else if (choice == 'B')
//             {
//                 Console.WriteLine("Delete Item");
//             }
//             else if (choice == 'C')
//             {
//                 Console.WriteLine("Exit");
//             }
//             else
//             {
//                 Console.WriteLine("Invalid Option");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Invalid Option");
//         }
        
//         Console.WriteLine("Press any key to exit...");
//         Console.ReadKey();
//     }
// }
// */



// Console.WriteLine("1");
// Console.WriteLine("2");
// Console.WriteLine("3");
// Console.WriteLine("4"); 
// Console.WriteLine("5");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}


i