using System;

public class ReflectingActivity: Activity {
    
    private static Random random = new Random();
    private List<string> _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
            
        };


    private List<string> _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
            
        };


    public ReflectingActivity(): base("Reflecting Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",6){
        DisplayStartingMessage();
    }


     public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");


        string option = Convert.ToString(Console.ReadLine());

        if (option == ""){
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write($"You may begin in: ");
            for (int j = 5; j>=1; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        DateTime startTime = DateTime.Now;
        while  ((DateTime.Now - startTime). TotalSeconds <_seconds){

        Console.Clear();
        DisplayQuestions();
        Console.WriteLine();
        if ((DateTime.Now - startTime). TotalSeconds >=_seconds){

                DisplayEndingMessage();
                
                break;
            }
        }
        
    }

     public string GetRandomPrompt(){
         
        string promptRandom = _prompts[random.Next(_prompts.Count)];
        return $"--- {promptRandom} ---";
    
    
        
    }

      public string GetRandomQuestion(){
         string questionRandom = _questions[random.Next(_questions.Count)];
        return $"> {questionRandom} ";
        
    }

     public void DisplayPrompt(){
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: "); 
        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt()); 
        
        
    }

     public void DisplayQuestions(){
        Console.Write(GetRandomQuestion()); 
        ShowSpinner(5);
        
    }

    
}