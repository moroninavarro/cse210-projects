using System;

public class ListingActivity : Activity{
    private static Random random = new Random();
    public int _count;
    
   private List<string> _prompts;


   public ListingActivity(int count) : base("Listing Activity","This activity will help you reflect on the good things in your life by having you List as many things as you can in a certain area.", 6)
   {
        DisplayStartingMessage();
        _count = count;
    }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        Console.WriteLine("List as many responses you can to the following prompt: "); 
        
        int time = _seconds;
        int answers = time / 3;

            for (int i = 0; i < answers; i++)
            {

                for (int j = 3; j>=1; j--){
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                 }

                
            }

            Console.WriteLine();
        
        DisplayEndingMessage();
        Thread.Sleep(4000);
    }

    public void GetRandomPrompt(){
         string[] prompts = new string[]
         {
            "When you have felt the Holy Ghost this month?",
            "When was the last time you helped someone else?",
            "What are the things you do to have a great day?",
            "What are the most important things in your life?",
            "What things motivates and inspires you?"
         };
        string promptRandom = prompts[random.Next(prompts.Length)];
    }

  
}
