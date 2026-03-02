Console.Write("Enter your age: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int age))
{
    Console.WriteLine("Valid age: " + age);
}
else
{
    Console.WriteLine("Invalid number entered.");
}