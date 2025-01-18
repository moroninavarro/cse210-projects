using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> questions = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the worst thing of my day?",
        
    };

    public Random random = new Random();
    public string GetRandomPrompt()
    {
        return questions[random.Next(0, questions.Count)];
    }
}