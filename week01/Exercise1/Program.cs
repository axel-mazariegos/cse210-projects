using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine($"Your names is {last_name}, {first_name} {last_name}.");
        Console.WriteLine("");
    }
}