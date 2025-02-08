using System;
using System.Data.Common;

public class BreathingActivity : Activity{

   public BreathingActivity(): base("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 6){ 
        DisplayStartingMessage();
    


 }

    public void Run(){
        Console.WriteLine("Get ready...");
        ShowSpinner(5);


        int time = _seconds;
        int breaths = time / 4;
        for (int i = 0; i < breaths; i++)
        {
            Console.Write($"Breathe in...");
            
            for (int j = 3; j>=1; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            
            Console.WriteLine();
            Console.Write($"Now Breathe out...");
            for (int j = 6; j>=1; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        Console.WriteLine();
        Console.WriteLine();
        }
        DisplayEndingMessage();
        Thread.Sleep(4000);
            

    }
}