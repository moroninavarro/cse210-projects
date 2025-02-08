using System;

public class ListingActivity : Activity{
    private static Random random = new Random();
    public int _count;
    
   private List<string> _prompts = new List<string>()
        {
            "When you have felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "Who are people that you appreciate?",
            "What are the most important things in your life?",
            "What are personal strengths of yours?"
        };



   public ListingActivity(int count) : base("Listing Activity","This activity will help you reflect on the good things in your life by having you List as many things as you can in a certain area.", 6)
   {
        DisplayStartingMessage();
        _count = count;
    }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();


        GetRandomPrompt();
        
        Console.Write($"You may begin in: ");
        for (int j = 5; j>=1; j--)
        {
            Console.Write(j);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
       
        Console.WriteLine();
        GetListFromUser();
        Console.WriteLine();
        DisplayEndingMessage();
        
    }

    public void GetRandomPrompt(){
        
         Console.WriteLine("List as many responses you can to the following prompt: "); 

    
        string promptRandom = _prompts[random.Next(_prompts.Count)];
         Console.WriteLine($"--- {promptRandom} ---");
    }

    public List<string> GetListFromUser(){
        List<string>answers = new List<string>();

         DateTime startTime = DateTime.Now;
        while  ((DateTime.Now - startTime). TotalSeconds <_seconds)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();
            if (answer == ""){
                break;
            }
            else if ((DateTime.Now - startTime). TotalSeconds >=_seconds){
                break;
            }
            answers.Add(answer);
        }
        Console.WriteLine($"You listed {answers.Count + 1} items.");
        return answers;
      
    }
}
