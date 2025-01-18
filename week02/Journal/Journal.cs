using System;
using System.Collections.Generic;
using System.Formats.Asn1;


public class Journal

{
  static PromptGenerator questions = new PromptGenerator(); 
  public List<Entry> _entries;

  public Journal()
   {
    _entries = new List<Entry>();
   }

  public void AddEntry(Entry newEntry)
  {
    _entries.Add(newEntry);
  }

  public void Display()
  {
    foreach (var newEntry in _entries)
    {
        
      newEntry.Display();
      Console.WriteLine();
    }
  }


  public void LoadFromFile(string file)
  {
      _entries.Clear();
      using (StreamReader reader = new StreamReader(file))
      {
        string line;
        Entry newEntry = null;
        while ((line = reader.ReadLine()) !=null)
        {
          if (line == "")
          {
            newEntry = null;
          }
          else if (newEntry == null)
          {
            newEntry = new Entry("","");
            newEntry._date = line;

          }
          else if (newEntry._promptText == "")
          {
            newEntry._promptText = line;
          }
          else
          {
            newEntry._entries = line;
            _entries.Add(newEntry);
          }
        }
      }
  }
  public void SaveToFile(string file)
  {
      string fileName = "Journal.txt";
      using (StreamWriter write = new StreamWriter(fileName))
      {
        foreach (var entry in _entries)
        {
          write.WriteLine(entry._date);
          write.WriteLine(entry._promptText);
          write.WriteLine(entry._entries);
          write.WriteLine();
        }
      }
  }

}