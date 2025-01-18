using System;
using System.Collections.Generic;
public class Entry
{
    public string _date;
    
    public string _promptText;
    public string _entries;
     
    public Entry(string promptText, string entries)
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        _promptText = promptText;
        _entries = entries;
        

    }
    public void Display()
    {
       
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entries}.");
    }
}

