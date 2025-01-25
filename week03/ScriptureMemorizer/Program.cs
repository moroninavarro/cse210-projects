using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

// I used Meta AI to do this assignment.
//Exceeding Requirements: I added a stopwatch to know the time that you taked to be able to memorize the scripture.
//I think that this could be like a game to have more fun.
class Program
{   
   
    static void Main(string[] args)
    {   

       DateTime startTime = DateTime.Now;

        Scripture escritura = new Scripture(new Reference("Proverbios", 3, 5, 6),"Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        
        while (!escritura.IsCompletelyHidden())
        {   
            Console.Clear();

            Console.WriteLine(escritura.GetDisplayText());
            
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();



            if (input == "")
            {
                
                escritura.HideRandomWords(3);
            }

            else if(input.ToLower() == "quit")
            {
            break;
            }

            if (escritura.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(escritura.GetDisplayText());
                Console.ReadLine();
                break;
            }
        }

        DateTime endTime = DateTime.Now;
        TimeSpan elapsedTime = endTime - startTime;
        Console.WriteLine("Time you have spend on the program:  " + elapsedTime.ToString(@"hh\:mm\:ss"));
    }
}