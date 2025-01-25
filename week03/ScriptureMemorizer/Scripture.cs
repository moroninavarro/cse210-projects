using System;
using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference;
    private Random _random = new Random(2);
    private List<Word> _words;
    
        

    public Scripture( Reference Reference, string text)
    {
        _reference = Reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
       



            if (numberToHide > _words.Count)
            {
                numberToHide = _words.Count;
            }
        
            for (int i = 0; i < numberToHide; i++)
            {
                int index = _random.Next(_words.Count);
                Word word = _words[index];
               
               if (!word.IsHidden())
               {
                word.Hide();

               }

               else
               {
                i--;
               }
            }
    }

    public string GetDisplayText()
    {
        string textDisplay = "";
        textDisplay+= _reference.GetDisplayText() + " ";
        foreach (Word words in _words)
        {
            textDisplay+= words.GetDisplayText() + " ";
        }
        return textDisplay.Trim();
    }

    public bool IsCompletelyHidden(){
        foreach (Word word in _words)
        if (!word.IsHidden())
        {
            return false;
        }
        return true;
    }
}