using System;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
       
        

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int SquaredNumber = SquareNumber(userNumber);
        
        DisplayResult(userName, SquaredNumber);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program! ");
    }


    static string PromptUserName()
    {
       
        Console.Write("Please enter your name: ");
        string names = Console.ReadLine();
        return names;
    }


    static int PromptUserNumber()
    {
       Console.Write("Please enter your favorite number: ");
       int number = int.Parse(Console.ReadLine());
       return number;
    }



    static int SquareNumber (int number)
    {
       int Square = number * number;
       return Square;
    }


   static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
        
    }


}


