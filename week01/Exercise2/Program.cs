using System;

class Program
{
    static void Main(string[] args)
    {
        //Core requirement #1 and #3
        Console.WriteLine("");
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        
        string letter = "";

        if (grade >= 90)
        {
            //Console.WriteLine("A");
            letter = "A";
            
        }
        else if (grade >= 80)
        {
            //Console.WriteLine("B");
            letter = "B";
        }
        else if (grade >= 70)
        {
            //Console.WriteLine("C");
            letter = "C";
        }
        else if (grade >= 60)
        {
            //Console.WriteLine("D");
            letter = "D";
        }
        else
        {
            //Console.WriteLine("F");
            letter = "F";
        }

        //Stretch Challenge #1, #2 and #3
        int lastDigit = grade % 10;
        string sign = "";

        if (lastDigit >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (lastDigit < 3 && letter != "F")
        {
            sign = "-";
        }

        Console.WriteLine("Your grade is: " + letter + sign);

        //Core requirement #2
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass this time, but you will do better next time!");
        }
        Console.WriteLine("");


        


        
    }
}