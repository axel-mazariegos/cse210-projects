using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);

        // FUNCTIONS
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput); 
            return userNumber;
        }

        static int SquareNumber(int num)
        {
            int squ = num * num;
            return squ;
        }

        static void DisplayResult (string userName, int num)
        {
            Console.WriteLine($"{userName}, the square of your number is {num}");
        }


    }
}