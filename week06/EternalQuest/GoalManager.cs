using System;
using System.IO;
public class GoalManager
{
public List<Goal> goals = new List<Goal>();

 public void SaveGoals(string file)

    {
    using (StreamWriter writer = new StreamWriter(file))
    {
    foreach (var goal in goals)
    {
        writer.WriteLine(goal.GetStringRepresentation());
    }
    }
    }


     public void LoadGoals(string file)

    {
        goals.Clear();
        if (File.Exists(file))
        {
             using (StreamReader reader = new StreamReader(file))
        {
       string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(':');
                string typeGoal = parts [0];
                if (typeGoal == "SimpleGoal")
                {
                    SimpleGoal simpleGoal = new SimpleGoal();

                    simpleGoal.GetStringRepresentation();
                    goals.Add(simpleGoal);

                }

                else if (typeGoal == "EternalGoal")
                {EternalGoal eternalGoal = new EternalGoal();
                
                eternalGoal.GetStringRepresentation();
                    goals.Add(eternalGoal);}

                    else if (typeGoal == "ChecklistGoal")
                {ChecklistGoal checklistGoal= new ChecklistGoal(10,10);
                
                checklistGoal.GetStringRepresentation();
                    goals.Add(checklistGoal);
                }
            }
        }
    }
    
    }
}