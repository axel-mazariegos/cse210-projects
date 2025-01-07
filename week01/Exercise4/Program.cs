using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = 1;

        do 
        {
            Console.Write("Enter number: ");
                    string userInput = Console.ReadLine();
                    number = int.Parse(userInput);
                    if (number != 0)
                    {
                        numbers.Add(number);
                    }
        } while (number !=0);

        // Core requirement #1
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Core requirement #2
        float average = 0;
        average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Core requirement #3
        int max = 0;
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
        
        // Stretch Challenge #1
        float smallest = float.PositiveInfinity;
         foreach (int num in numbers)
        {
            if (num < smallest && num > 0)
            {
                smallest = num;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallest}");

        // Stretch Challenge #2
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("");

    }
}