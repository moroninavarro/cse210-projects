using System;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment("Samuel Benett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();


        MathAssignment mathAssignment = new MathAssignment("7.3","8-19","Roberto Rodriguez","Fractions");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();


        WritingAssignment writingAssignment = new WritingAssignment("The Causes of World War II","Mary Waters","European History");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}