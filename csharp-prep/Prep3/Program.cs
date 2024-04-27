using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);

        int guessNumber = -1;

        while (guessNumber != magicNumber)
        {
            Console.WriteLine("What's your guess? ");
                guessNumber = int.Parse(Console.ReadLine());

                if (magicNumber > guessNumber)
                {
                    Console.WriteLine("Guess higher");

                }
                else if (magicNumber < guessNumber)
                {
                    Console.WriteLine("Guess lower");
                }
                else 
                {
                    Console.WriteLine("You guessed it!");
                }

        }
    }
       
}