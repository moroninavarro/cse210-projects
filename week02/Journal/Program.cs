// I used AI and this video from Youtube https://youtu.be/sWfe80Fj9Pg to do this assignment.
//I readed that is allowed so I did it and reflected about the code to understand better.
//Exceeding Requirements: I think that one of the other problems that keep people from writing in their journal
//could be because they forgot the purpose, so in this program I added a new option (option 6) to be able to remember the importance of writing in our Journal.
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
            Console.WriteLine("6. Purpose");
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

                case 6:
                Console.WriteLine("Why is important writing a Journal? ");
                Console.WriteLine("Writing a Journal will help you to remember things, such as your goals, your dreams and important events during your life.");
                Console.WriteLine("keeping a journal reduce symptoms of depression and anxiety, keeping a journal is beneficial for mental well-being.");
                Console.WriteLine("I invite you to keep your personal journal, I know it will help you a lot, remember this purpose, thank you.");
                break;

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