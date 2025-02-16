using System;


public class ChecklistGoal: Goal{


    protected int _amountCompleted;

    private int _target;

    private int _bonus;

    public ChecklistGoal(int target, int bonus): base("","", 0)
    {

        _target = target;
        _bonus = bonus;
    }

    public override void CompleteEvent()
    {
        _amountCompleted++;
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

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _target = Convert.ToInt32(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
    }


       public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public new string GetDetailsString(){
        
        return $"{_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";

        
     }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }



}