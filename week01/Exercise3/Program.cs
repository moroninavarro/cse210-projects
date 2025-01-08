using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        int guess = -1;


        while (guess != magic)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magic)
            {
                Console.WriteLine("Lower");
                
            }

            else if (guess < magic)
            {
                Console.WriteLine("higher");
            }
            
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}