using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
       static Journal myJournal = new Journal();
       static PromptGenerator questions = new PromptGenerator(); 
    static void Main(string[] args)
    {
        string file = "";
        
       while(true)
       {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                AddEntry();
                break;

                case 2:
                myJournal.Display();
                break;

                case 3:
                Console.Write("What is the filename? ");
                file = Console.ReadLine();
                myJournal.LoadFromFile(file);
                myJournal.Display();
                break;


                case 4:
                Console.Write("What is the filename? ");
                file = Console.ReadLine();
                Console.WriteLine();
                myJournal.SaveToFile(file);
                Console.WriteLine("Saving...");
                break;





                case 5:
                return;

                default:
                Console.WriteLine("Invalid Option. Please try again");
                break;


            }
       }


    }
       static void AddEntry()
       {
        string question = questions.GetRandomPrompt();
        Console.WriteLine($"Prompt: {question}");
        Console.Write("> ");
        string answer = Console.ReadLine(); 
        


        Entry myEntry = new Entry(question, answer);
        myJournal.AddEntry(myEntry);
        
        Console.WriteLine("Task Complete.");

       }
}