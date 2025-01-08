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
        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;
        string letter;
        

        if (x >= a)
        {
            Console.WriteLine("Your grade is an A "{letter});
        }

        else if (x >= b)
        {
            Console.WriteLine("Your grade is an B ");
        }

        else if (x >= c)
        {
            Console.WriteLine("Your grade is an C ");
        }

        else if (x >= d)
        {
            Console.WriteLine("Your grade is an D ");

        }
       
        else
        {
            Console.WriteLine("Your grade is an F ");
        }

        if (x >= d || x >= c ||x >= b ||x >= a)
        {
            Console.WriteLine("Congratulations, you passed the course.");
        }
        
        else
        {
            Console.WriteLine("Sorry, you missed the course, we encourage you to try it again.");
        }

        
    }
        
}