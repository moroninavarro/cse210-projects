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
        //Console.ReadLine();
         int option = Convert.ToInt32(Console.ReadLine());

         
             if (option == 1)
            {
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity();
                Console.Clear();
                breathingActivity.Run();
                Console.Clear();
                
                
            }

            else if(option == 3)
            {
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity(6);
                Console.Clear();
                listingActivity.Run();
                Console.Clear();
                //string name = listingActivity.GetRandomPrompt();
                //Console.WriteLine(name);
            }
            else if(option == 4)
            {
            return;
            }
    }

            

       //BreathingActivity breathingActivity = new BreathingActivity();
       // Console.WriteLine(breathingActivity.DisplayStartingMessage);
        //Console.WriteLine();
    }
}