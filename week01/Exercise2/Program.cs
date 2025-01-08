using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);
       
        string letter = "";
        

        if (x >= 90)
        {
           letter = "A";
        }

        else if (x >= 80)
        {
            letter = "B";
        }

        else if (x >= 70)
        {
            letter = "C";
        }

        else if (x >= 60)
        {
           letter = "D";

        }
       
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (x >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course.");
        }
        
        else
        {
            Console.WriteLine("Sorry, you missed the course, we encourage you to try it again.");
        }

        
    }
        
}