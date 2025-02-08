using System;
using System.Data.Common;

public class BreathingActivity : Activity{

   public BreathingActivity(): base("BreathingActivity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 6){ 
    
    Console.WriteLine($"Breathe in...");
    for (int i = 5; i> 0; i--)
   {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
   }

   Console.WriteLine($"Now Breathe out...");
    for (int i = 5; i> 0; i--)
   {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
   }

    Console.WriteLine();
    Console.WriteLine($"Breathe in...");
    for (int i = 5; i> 0; i--)
   {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
   }
    
   Console.WriteLine($"Now Breathe out...");
    for (int i = 5; i> 0; i--)
   {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
   }


     Console.WriteLine();
    Console.WriteLine($"Breathe in...");
    for (int i = 5; i> 0; i--)
   {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
   }
    
   Console.WriteLine($"Now Breathe out...");
    for (int i = 5; i> 0; i--)
   {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
   }
 }

    public void Run(){
         DisplayStartingMessage();
    }
}