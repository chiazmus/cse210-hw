using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumberGenerator = new Random();
        int magicNumber = randomNumberGenerator.Next(1, 100);
        int guess;
        
        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber) {
                Console.WriteLine("Higher!");
            } else if (guess > magicNumber) {
                Console.WriteLine("Lower!");
            } else {
                Console.WriteLine("You guessed it!");
            }

        } while (guess != magicNumber);

    }
}