// I used AI Meta to do this assignment.
//Exceeding Requirements: I added a (Invalid option) for the menu, this is very helpful in case the user put an invalid option, he will be able to return again into the menu.
using System;
class Program
{
    static void Main(string[] args)
    {
               
    while (true){
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        int option = Convert.ToInt32(Console.ReadLine());

         
             if (option == 1)
            {
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity();
                Console.Clear();
                breathingActivity.Run();
                Console.Clear();
                
                
            }
              else if(option == 2)
            {
                Console.Clear();
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                Console.Clear();
                reflectingActivity.Run();
                Console.Clear();
            }

            else if(option == 3)
            {
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity(6);
                Console.Clear();
                listingActivity.Run();
                Console.Clear();
            }


            else if(option == 4)
            {
            return;
            }

            else {
                Console.WriteLine("Invalid option, please try again.");
                List<string> animationStrings = new List<string>();
                animationStrings.Add("|");
                animationStrings.Add("/");
                animationStrings.Add("-");
                animationStrings.Add("\\");
                animationStrings.Add("|");
                animationStrings.Add("/");
                animationStrings.Add("-");
                animationStrings.Add("\\");

                foreach (string s in animationStrings)
                {
                    Console.Write(s);
                    Thread.Sleep(900);
                    Console.Write("\b \b");
                }
                Console.Clear();
            }
    }

    }
}