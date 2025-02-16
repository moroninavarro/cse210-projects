using System;
using System.IO;
public class GoalManager
{

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


     public List<Goal> LoadGoals(string file)

    {
    
        List<Goal> loadedGoals = new List<Goal>();
        if (File.Exists(file))
        {
             using (StreamReader reader = new StreamReader(file))
        {
       string line;
            while ((line = reader.ReadLine()) !== null)
            {
                string[] parts = line.Split(':');
                string typeGoal = parts [0];
                if (typeGoal == "SimpleGoal")
                {
                    SimpleGoal simpleGoal = new SimpleGoal();

                    simpleGoal.LoadFromStringRepresentation(line);
                    loadedGoals.Add(simpleGoal);

                }

                else if (typeGoal == "EternalGoal")
                {EternalGoal eternalGoal = new EternalGoal();
                
                eternalGoal.LoadFromStringRepresentation(line);
                    loadedGoals.Add(eternalGoal);}

                    else if (typeGoal == "ChecklistGoal")
                {ChecklistGoal checklistGoal= new ChecklistGoal();
                
                checklistGoal.LoadFromStringRepresentation(line);
                    loadedGoals.Add(checklistGoal);
                }
            }
        }
    }
    return loadedGoals;
    }
}