using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What is the magic number: ");
        // string userMagicNumber = Console.ReadLine();
        // int magicNumber = int.Parse(userMagicNumber);
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);


        bool guessed = false;

        while (!guessed)
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            int guess = int.Parse(userGuess);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                guessed = true;
                Console.WriteLine("You guessed it!");
            }
        }
    }
}