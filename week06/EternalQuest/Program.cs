using System;

class Program
{
    static List<Goal> goal = new List<Goal>();
    static void Main(string[] args)
    {
        

         while (true){
        
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        int option = Convert.ToInt32(Console.ReadLine());

         
             if (option == 1)
            {
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. CheckList Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    int typeGoal = Convert.ToInt32(Console.ReadLine());

                    if (typeGoal == 1)
                    {
                        SimpleGoal simpleGoal = new SimpleGoal();
                        
                        simpleGoal.RecordEvent();
                        goal.Add(simpleGoal);
                        
                    }
                    else if (typeGoal == 2)
                    {
                        EternalGoal eternalGoal = new EternalGoal();
                        eternalGoal.RecordEvent();
                        goal.Add(eternalGoal);
                    }

                    else if (typeGoal == 3)
                    {
                        ChecklistGoal checklistGoal = new ChecklistGoal(10,10);
                        checklistGoal.RecordEvent();
                        goal.Add(checklistGoal);

                    }
                
            }
              else if(option == 2)
            {
                
                Console.WriteLine("The goals are: ");
                int i= 1;

                foreach (var goals in goal)
                {
                    ChecklistGoal checklistGoal = goals as ChecklistGoal;
                    string estado = goals.IsComplete() ? "[X]" : "[ ]";
                    if (checklistGoal != null)
                    {
                        Console.WriteLine($"{i}. {estado} {checklistGoal.GetDetailsString()}");
                    }
                    else
                    {

                    Console.WriteLine($"{i}. {estado} {goals.GetDetailsString()}");
                    }
                    i++;
                }

                Console.WriteLine();
            }

            else if(option == 3)
            {
                Console.Write("What is the filename for the goal file? ");
                string file = Console.ReadLine();
                GoalManager manager = new GoalManager();
                manager.SaveGoals(file);
              
            }


            else if(option == 4)
            {
                Console.Write("What is the filename for the goal file? ");
                string file = Console.ReadLine();
                GoalManager manager = new GoalManager();
                List<Goal> goal = manager.LoadGoals(file);
                
            }


            
             else if(option == 5)
            {
              Console.WriteLine("The goals are: ");
                int i= 1;

                foreach (var goals in goal)
                {
                    Console.WriteLine($"{i}. {goals.GetDetailsString()}");
                    i++;
                }

                Console.Write("Which goal did you accomplish? ");
               int selectedIndex = Convert.ToInt32(Console.ReadLine());
               Goal selectedGoal = goal[selectedIndex - 1];
               selectedGoal.CompleteEvent();
               
            }
             else if(option == 6)
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