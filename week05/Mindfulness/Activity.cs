using System;

public class Activity{

    protected string _name;
    protected string _description;
    protected int _duration;
    
    protected int _seconds;
    public Activity(string name, string description, int duration){
        _name = name;
        _description = description;
        _duration = duration;
    }


    public void DisplayStartingMessage(){
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.WriteLine($"How long, in seconds would you like for your session?");
        int time = Convert.ToInt32(Console.ReadLine());
    }

     public void DisplayEndingMessage(){
        Console.WriteLine($"Well done!!");
        ShowSpinner(6);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the Listing Activity.");
        Console.WriteLine();
    }

   
     public void ShowSpinner(int seconds){
        
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
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
     
     }

     public void ShowCountDown(int seconds){
        Console.WriteLine($"We.");
        Console.WriteLine();
        
    }
}