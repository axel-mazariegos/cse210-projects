using System;

class Program
{
    static void Main(string[] args)
    {
        //Core requirement #1 
        Console.WriteLine("");
        // Console.Write("What is the magic number? ");
        // string randomNumber = Console.ReadLine();
        // int magicNumber = int.Parse(randomNumber);

        
        //Stretch Challenge #2
        string play = "yes";

        do
        {
            //Core requirement #3
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guessNumber = 0;
            int attempts = 0;
            
            //Core requirement #2
            do
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);

                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("You guessed it!");
                }
                attempts++;
                
            } while (guessNumber != magicNumber);

            // Stretch Challenge #1
            Console.WriteLine($"It took you {attempts} attempts to guess the magic number {magicNumber}");
            Console.WriteLine("");

            Console.Write("Do you want to play again? (yes/no) ");
            play = Console.ReadLine();
            Console.WriteLine("");

        } while (play == "yes");
    }
    
}