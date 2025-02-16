using System;


public class EternalGoal: Goal{


    public EternalGoal():base ("","", 0)
    {
       
    }

    public override void CompleteEvent()
    {   
        
        Console.WriteLine($"Congratulations! You have earned {_points} points! ");
        Console.WriteLine();
        Console.WriteLine($"You now have {_points}");
    }



      public override void RecordEvent()
    {
        Console.WriteLine();
        Console.Write("What is the name of your goal? ");
        _shortName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _points = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }


       public override bool IsComplete()
    {
        return false;
    }
   
    public override string GetStringRepresentation()
    {
       return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}