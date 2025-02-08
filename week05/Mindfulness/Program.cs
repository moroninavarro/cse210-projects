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
                Activity activity = new Activity("BreathingActivity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",5);
                activity.DisplayStartingMessage();
                Console.Clear();
                Console.WriteLine("Get ready...");
                activity.ShowSpinner(6);
                Console.WriteLine();
                BreathingActivity breathingActivity = new BreathingActivity();
                Console.WriteLine();
                activity.DisplayEndingMessage();
                activity.ShowSpinner(6);
                Console.Clear();
                
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